namespace ReflectionAndUnmanagedresources
{
    /// <summary>
    /// Our program.cs.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Our entry point.
        /// </summary>
        public static void Main()
        {
            const string originFilePath = "origin.txt";
            const string localFilePath = "local.txt";
            const string remoteFilePath = "remote.txt";

            // Used default path for files which is: "...\bin\Debug\net7.0"
            if (!File.Exists(originFilePath))
            {
                File.WriteAllText("origin.txt", string.Empty);
                Console.WriteLine("The origin file didn't exist and was created");
            }

            if (!File.Exists(localFilePath))
            {
                File.WriteAllText("local.txt", string.Empty);
                Console.WriteLine("The local file didn't exist and was created");
            }

            if (!File.Exists(remoteFilePath))
            {
                File.WriteAllText("remote.txt", string.Empty);
                Console.WriteLine("The remote file didn't exist and was created");
            }

            // Check if the local and remote files were modified before the origin file
            var originLastModified = File.GetLastWriteTime(originFilePath);
            var localLastModified = File.GetLastWriteTime(localFilePath);
            var remoteLastModified = File.GetLastWriteTime(remoteFilePath);

            if (localLastModified < originLastModified || remoteLastModified < originLastModified)
            {
                Console.WriteLine("Local or remote files are outdated and will not be considered for comparison.");
                return;
            }

            // Read the contents of all three files
            var originContent = ReadFileContent(originFilePath);
            var localContent = ReadFileContent(localFilePath);
            var remoteContent = ReadFileContent(remoteFilePath);

            // Compare the contents and update the origin file
            /*// Invoke the CompareContents method using reflection - but this is just optional and not efficient and it's only for demonstration purpose.
            MethodInfo? compareContentsMethod = typeof(Program).GetMethod("CompareContents", BindingFlags.Static | BindingFlags.Public);
            object updatedContent = compareContentsMethod.Invoke(null, new object[] { originContent, localContent, remoteContent });*/
            var updatedContent = CompareContents(originContent, localContent, remoteContent);
            WriteFileContent(originFilePath, updatedContent);

            Console.WriteLine("Origin file updated successfully.");
        }

        /// <summary>
        /// Reads the content of a file located at the specified file path.
        /// </summary>
        /// <param name="filePath">The path to the file.</param>
        /// <returns>A string containing the content of the file.</returns>
        public static string ReadFileContent(string filePath)
        {
            using var reader = new StreamReader(filePath);
            return reader.ReadToEnd();
        }

        /// <summary>
        /// Writes the specified content to a file located at the specified file path.
        /// </summary>
        /// <param name="filePath">The path to the file.</param>
        /// <param name="content">The content to be written to the file.</param>
        public static void WriteFileContent(string filePath, string content)
        {
            using var writer = new StreamWriter(filePath);
            writer.Write(content);
        }

        /// <summary>
        /// Compares the contents of three strings representing the original, local, and remote versions of a document,
        /// and returns an updated version of the document with resolved conflicts.
        /// </summary>
        /// <param name="originContent">The content of the original document.</param>
        /// <param name="localContent">The content of the local document.</param>
        /// <param name="remoteContent">The content of the remote document.</param>
        /// <returns>An updated version of the document with resolved conflicts.</returns>
        public static string CompareContents(string originContent, string localContent, string remoteContent)
        {
            var originLines = originContent.Split(Environment.NewLine);
            var localLines = localContent.Split(Environment.NewLine);
            var remoteLines = remoteContent.Split(Environment.NewLine);

            var updatedLines = new List<string>();

            var maxLines = Math.Max(Math.Max(originLines.Length, localLines.Length), remoteLines.Length);
            for (var i = 0; i < maxLines; i++)
            {
                var originLine = (i < originLines.Length) ? originLines[i] : string.Empty;
                var localLine = (i < localLines.Length) ? localLines[i] : string.Empty;
                var remoteLine = (i < remoteLines.Length) ? remoteLines[i] : string.Empty;

                if (originLine == localLine || originLine == remoteLine)
                {
                    // Line unchanged in both local and remote
                    updatedLines.Add(originLine);
                }
                else if (localLine != remoteLine)
                {
                    // Line changed differently in local and remote
                    Console.WriteLine($"Conflict at line {i + 1}:");
                    Console.WriteLine("Local: " + localLine);
                    Console.WriteLine("Remote: " + remoteLine);

                    Console.WriteLine("Choose the correct option (from 1-3):");
                    Console.WriteLine("1. Use local");
                    Console.WriteLine("2. Use remote");
                    Console.WriteLine("3. Skip this line");

                    var option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            updatedLines.Add(localLine);
                            break;
                        case "2":
                            updatedLines.Add(remoteLine);
                            break;
                        case "3":
                            updatedLines.Add(originLine);
                            break;
                        default:
                            Console.WriteLine("Invalid option. Skipping this line.");
                            updatedLines.Add(originLine);
                            break;
                    }
                }
                else
                {
                    // Line added in local or remote
                    if (localLine != string.Empty)
                    {
                        updatedLines.Add(localLine);
                    }
                    else if (remoteLine != string.Empty)
                    {
                        updatedLines.Add(remoteLine);
                    }
                }
            }

            return string.Join(Environment.NewLine, updatedLines);
        }
    }
}