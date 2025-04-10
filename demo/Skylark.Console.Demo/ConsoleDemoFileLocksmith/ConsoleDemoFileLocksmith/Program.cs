using Skylark.Wing.Helper;
using Skylark.Wing.Model;
using Skylark.Wing.Utility;

namespace ConsoleDemoFileLocksmith
{
    internal class Program
    {
        // Flag to track if the application should exit
        private static bool _shouldExit = false;

        static async Task Main(string[] args)
        {
            Console.WriteLine("FileLocksmith Demo Application");
            Console.WriteLine("============================");
            Console.WriteLine();

            Console.WriteLine("This demo will show you how to use the FileLocksmith library to:");
            Console.WriteLine(" - Check if a file is locked");
            Console.WriteLine(" - Find processes that have locked a file");
            Console.WriteLine(" - Use different detection methods");
            Console.WriteLine(" - Lock a file for testing");
            Console.WriteLine();

            string testFilePath = string.Empty;

            do
            {
                Console.WriteLine("Please enter the path to a test file (or create a new one):");
                testFilePath = Console.ReadLine() ?? null;
            } while (string.IsNullOrWhiteSpace(testFilePath) || !File.Exists(testFilePath));

            while (!_shouldExit)
            {
                try
                {
                    DisplayMenu();
                    string choice = Console.ReadLine() ?? string.Empty;
                    Console.WriteLine();

                    await ProcessMenuChoice(choice, testFilePath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    Console.WriteLine();
                }

                if (!_shouldExit)
                {
                    Console.Write("Press Enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            // Clean up
            try
            {
                if (File.Exists(testFilePath))
                {
                    File.Delete(testFilePath);
                    Console.WriteLine($"Deleted test file: {testFilePath}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Could not delete test file: {ex.Message}");
            }

            Console.WriteLine("Goodbye!");
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Check if a file is locked (with recommended detector)");
            Console.WriteLine("2. Check if a file is locked (with all detectors)");
            Console.WriteLine("3. Get detailed lock information");
            Console.WriteLine("4. Get processes locking a file");
            Console.WriteLine("5. Lock the test file for 10 seconds");
            Console.WriteLine("6. Lock a specific file for a specified duration");
            Console.WriteLine("7. List available detectors");
            Console.WriteLine("0. Exit");
            Console.WriteLine();
            Console.Write("Enter your choice: ");
        }

        private static async Task ProcessMenuChoice(string choice, string testFilePath)
        {
            switch (choice)
            {
                case "1":
                    CheckIfFileLocked(testFilePath);
                    break;

                case "2":
                    CheckWithAllDetectors(testFilePath);
                    break;

                case "3":
                    GetDetailedLockInfo(testFilePath);
                    break;

                case "4":
                    GetLockingProcesses(testFilePath);
                    break;

                case "5":
                    await LockTestFile(testFilePath, 10);
                    break;

                case "6":
                    await LockSpecificFile();
                    break;

                case "7":
                    ListAvailableDetectors();
                    break;

                case "0":
                    _shouldExit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        private static void CheckIfFileLocked(string filePath)
        {
            Console.WriteLine($"Checking if file is locked: {filePath}");
            bool isLocked = FileLocksmith.IsFileLocked(filePath);
            Console.WriteLine($"File is {(isLocked ? "locked" : "not locked")}");
        }

        private static void CheckWithAllDetectors(string filePath)
        {
            Console.WriteLine($"Checking if file is locked using all detectors: {filePath}");
            Console.WriteLine();

            List<(string Name, string Description)> detectors = FileLocksmith.ListAvailableDetectors().ToList();

            foreach ((string name, string description) in detectors)
            {
                bool isLocked = FileLocksmith.IsFileLocked(filePath, name);
                Console.WriteLine($"Detector: {name}");
                Console.WriteLine($"Description: {description}");
                Console.WriteLine($"Result: File is {(isLocked ? "locked" : "not locked")}");
                Console.WriteLine();
            }
        }

        private static void GetDetailedLockInfo(string filePath)
        {
            Console.WriteLine($"Getting detailed lock information for file: {filePath}");
            Console.WriteLine();

            FileLockInfo lockInfo = FileLocksmith.GetFileLockInfo(filePath);

            Console.WriteLine($"File Path: {lockInfo.FilePath}");
            Console.WriteLine($"File Exists: {lockInfo.FileExists}");
            Console.WriteLine($"Is Locked: {lockInfo.IsLocked}");
            Console.WriteLine($"Detection Method: {lockInfo.DetectionMethod}");
            Console.WriteLine($"Check Time: {lockInfo.CheckTime}");

            if (!string.IsNullOrEmpty(lockInfo.ErrorMessage))
            {
                Console.WriteLine($"Error: {lockInfo.ErrorMessage}");
            }

            if (lockInfo.LockingProcesses.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine($"Locking Processes ({lockInfo.LockingProcesses.Count}):");

                foreach (ProcessInfo process in lockInfo.LockingProcesses)
                {
                    Console.WriteLine($"  - {process.ProcessName} (ID: {process.ProcessId})");

                    if (!string.IsNullOrEmpty(process.WindowTitle))
                    {
                        Console.WriteLine($"    Window Title: {process.WindowTitle}");
                    }

                    Console.WriteLine($"    Application Type: {process.ApplicationType}");
                    Console.WriteLine($"    Restartable: {process.IsRestartable}");
                    Console.WriteLine($"    Start Time: {process.StartTime}");
                    Console.WriteLine();
                }
            }
        }

        private static void GetLockingProcesses(string filePath)
        {
            Console.WriteLine($"Getting processes locking file: {filePath}");
            Console.WriteLine();

            IEnumerable<ProcessInfo> processes = FileLocksmith.GetLockingProcesses(filePath);
            List<ProcessInfo> processList = processes.ToList();

            if (processList.Count > 0)
            {
                Console.WriteLine($"Found {processList.Count} processes locking the file:");

                foreach (ProcessInfo process in processList)
                {
                    Console.WriteLine($"  - {process.ProcessName} (ID: {process.ProcessId})");

                    if (!string.IsNullOrEmpty(process.WindowTitle))
                    {
                        Console.WriteLine($"    Window Title: {process.WindowTitle}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No processes found locking the file.");
            }
        }

        private static async Task LockTestFile(string filePath, int durationSeconds)
        {
            Console.WriteLine($"Locking file for {durationSeconds} seconds: {filePath}");
            Console.WriteLine("The file is now locked. Try to open it in another application.");
            Console.WriteLine();

            // Start a task to lock the file
            Task lockTask = FileLocker.LockFileAsync(filePath, durationSeconds);

            // Display a countdown
            for (int i = durationSeconds; i > 0; i--)
            {
                Console.Write($"\rFile will be unlocked in {i} seconds... ");
                await Task.Delay(1000);
            }

            // Wait for the lock task to complete
            await lockTask;

            Console.WriteLine("\rFile has been unlocked.                    ");
        }

        private static async Task LockSpecificFile()
        {
            Console.WriteLine("Enter the path of the file to lock:");
            string filePath = Console.ReadLine()?.Trim() ?? string.Empty;

            if (string.IsNullOrEmpty(filePath))
            {
                Console.WriteLine("No file path entered.");
                return;
            }

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File does not exist: {filePath}");
                return;
            }

            Console.WriteLine("Enter the duration in seconds to lock the file:");
            if (!int.TryParse(Console.ReadLine(), out int duration) || duration <= 0)
            {
                Console.WriteLine("Invalid duration. Using 10 seconds as default.");
                duration = 10;
            }

            await LockTestFile(filePath, duration);
        }

        private static void ListAvailableDetectors()
        {
            Console.WriteLine("Available File Lock Detectors:");
            Console.WriteLine();

            List<(string Name, string Description)> detectors = FileLocksmith.ListAvailableDetectors().ToList();

            foreach ((string name, string description) in detectors)
            {
                Console.WriteLine($"  - {name}");
                Console.WriteLine($"    {description}");
                Console.WriteLine();
            }
        }
    }
}