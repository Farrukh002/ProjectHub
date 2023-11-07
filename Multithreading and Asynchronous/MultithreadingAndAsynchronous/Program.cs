using LoggingLibrary;
using System;

namespace ConsoleApp
{
    class Program
    {
        public static async Task Main()
        {
            // Instantiate the logger by providing the path to the configuration file
            var logger = new Logger(@"E:\C# Applications\.net assignments\MultithreadingAndAsynchronous\bin\Debug\net7.0\App.config");

            // Subscribe to the BackupRequired event
            logger.BackupRequired += LoggerBackupRequired;

            // Start logging user input and informational entries
            await Task.WhenAll(
                LogUserInputAsync(logger),
                LogInfoEntriesAsync(logger)
            );
        }

        public static async Task LogUserInputAsync(Logger logger)
        {
            Console.WriteLine("Enter 'i' for informational log, 'w' for warning log, 'e' for error log, or 'q' to quit");
            while (true)
            {
                var input = Console.ReadLine()?.ToLower();
                if (input == "q")
                    break;

                LogLevel level;
                switch (input.ToLower())
                {
                    case "i":
                        level = LogLevel.Information;
                        break;
                    case "w":
                        level = LogLevel.Warning;
                        break;
                    case "e":
                        level = LogLevel.Error;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Try again.");
                        continue;
                }

                await logger.LogAsync(level, $"User input: {input}");
            }
        }

        public static async Task LogInfoEntriesAsync(Logger logger)
        {
            while (true)
            {
                await logger.LogAsync(LogLevel.Information, "Info entry");

                // Wait for 1000 milliseconds
                await Task.Delay(1000);
            }
        }

        public static void LoggerBackupRequired(object sender, EventArgs e)
        {
            // Handle the backup event
            Console.WriteLine("Backup required");

            if (sender is Logger logger)
            {
                // Create a backup copy of the log file
                logger.CreateBackup();
            }

        }
    }
}