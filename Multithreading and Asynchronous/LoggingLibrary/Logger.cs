namespace LoggingLibrary
{
    using System.Configuration;

    public class Logger
    {
        private readonly string logFilePath;
        private readonly int backupThreshold;
        private int writeCount;

        public Logger(string configFile)
        {
            logFilePath = ReadLogFilePathFromConfig(configFile);
            backupThreshold = ReadBackupThresholdFromConfig(configFile);
        }

        public event EventHandler BackupRequired;

        public async Task LogAsync(LogLevel level, string message)
        {
            // Create the log entry with the current timestamp
            var logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{level}] {message}";

            // Write the log entry to the file asynchronously
            await WriteLogAsync(logEntry);

            // Increment the write count and check if a backup is required
            if (++writeCount >= backupThreshold)
            {
                writeCount = 0;
                OnBackupRequired();
            }
        }

        private async Task WriteLogAsync(string logEntry)
        {
            try
            {
                Console.WriteLine($"Log file path: {logFilePath}"); // Debug statement

                if (string.IsNullOrEmpty(logFilePath))
                {
                    Console.WriteLine("Log file path is null or empty"); // Debug statement
                    return;
                }

                await using var writer = new StreamWriter(logFilePath);
                await writer.WriteLineAsync(logEntry);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void CreateBackup()
        {
            string backupDirectory = Path.GetDirectoryName(logFilePath);
            string fileName = Path.GetFileNameWithoutExtension(logFilePath);
            string backupFileName = $"{fileName}_{DateTime.Now:yyyyMMddHHmmss}.txt";
            string backupFilePath = Path.Combine(backupDirectory, backupFileName);

            File.Copy(logFilePath, backupFilePath);
        }

        protected virtual void OnBackupRequired()
        {
            // Raise the BackupRequired event
            BackupRequired?.Invoke(this, EventArgs.Empty);
        }

        // Other helper methods to read the configuration file, create backup copies, etc.
        private string ReadLogFilePathFromConfig(string configFile)
        {
            try
            {
                // Load the configuration file
                var config = ConfigurationManager.OpenExeConfiguration(configFile);

                // Read the "LogFilePath" value from the appSettings section
                var logFilePath = config.AppSettings.Settings["LogFilePath"]?.Value;
                Console.WriteLine($"Read LogFilePath: {logFilePath}");

                return logFilePath;
            }
            catch (ConfigurationErrorsException ex)
            {
                // Handle any configuration errors
                Console.WriteLine($"Error reading configuration file: {ex.Message}");
            }

            // Return a default log file path if reading fails
            return string.Empty;
        }

        private int ReadBackupThresholdFromConfig(string configFile)
        {
            try
            {
                // Load the configuration file
                var config = ConfigurationManager.OpenExeConfiguration(configFile);

                // Read the "BackupThreshold" value from the appSettings section
                var backupThresholdStr = config.AppSettings.Settings["BackupThreshold"]?.Value;
                if (int.TryParse(backupThresholdStr, out var backupThreshold))
                {
                    return backupThreshold;
                }
            }
            catch (ConfigurationErrorsException ex)
            {
                // Handle any configuration errors
                Console.WriteLine($"Error reading configuration file: {ex.Message}");
            }

            // Return a default backup threshold value if reading fails or the value is invalid
            return 0;
        }
    }
}