using System;
using System.IO;
using System.Threading.Tasks;

namespace Skylark.Wing.Utility
{
    /// <summary>
    /// Helper utilities for working with file locks
    /// </summary>
    public static class FileLocker
    {
        /// <summary>
        /// Represents a file lock that can be released
        /// </summary>
        public class FileLock : IDisposable
        {
            /// <summary>
            /// 
            /// </summary>
            private bool _disposed;

            /// <summary>
            /// 
            /// </summary>
            private FileStream? _fileStream;

            /// <summary>
            /// Gets the path of the locked file
            /// </summary>
            public string FilePath { get; }

            /// <summary>
            /// Gets the time when the file was locked
            /// </summary>
            public DateTime LockTime { get; }

            /// <summary>
            /// Gets the sharing mode used to lock the file
            /// </summary>
            public FileShare ShareMode { get; }

            /// <summary>
            /// Creates a new FileLock instance
            /// </summary>
            /// <param name="filePath">The path of the file being locked</param>
            /// <param name="fileStream">The FileStream that has the file opened</param>
            /// <param name="shareMode">The FileShare mode used to open the file</param>
            internal FileLock(string filePath, FileStream fileStream, FileShare shareMode)
            {
                FilePath = filePath;
                ShareMode = shareMode;
                LockTime = DateTime.Now;
                _fileStream = fileStream;
            }

            /// <summary>
            /// Releases the file lock
            /// </summary>
            public void Release()
            {
                Dispose();
            }

            /// <summary>
            /// Disposes the file lock, releasing the file
            /// </summary>
            public void Dispose()
            {
                if (!_disposed)
                {
                    _fileStream?.Close();
                    _fileStream?.Dispose();
                    _fileStream = null;
                    _disposed = true;
                }
            }
        }

        /// <summary>
        /// Locks a file for testing
        /// </summary>
        /// <param name="filePath">The path of the file to lock</param>
        /// <param name="shareMode">The FileShare mode to use for locking (default is None)</param>
        /// <returns>A FileLock object that can be used to release the lock</returns>
        public static FileLock LockFile(string filePath, FileShare shareMode = FileShare.None)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("The file to lock does not exist.", filePath);
            }

            // Open the file with the specified sharing mode to lock it
            FileStream fileStream = new(filePath, FileMode.Open, shareMode == FileShare.None ? FileAccess.ReadWrite : FileAccess.Read, shareMode);

            return new FileLock(filePath, fileStream, shareMode);
        }

        /// <summary>
        /// Locks a file for a specified duration
        /// </summary>
        /// <param name="filePath">The path of the file to lock</param>
        /// <param name="durationSeconds">The duration in seconds to keep the file locked</param>
        /// <param name="shareMode">The FileShare mode to use for locking (default is None)</param>
        /// <returns>A task that completes when the file is unlocked</returns>
        public static async Task LockFileAsync(string filePath, int durationSeconds, FileShare shareMode = FileShare.None)
        {
            using FileLock fileLock = LockFile(filePath, shareMode);

            // Keep the file locked for the specified duration
            await Task.Delay(durationSeconds * 1000).ConfigureAwait(false);
            // The file will be automatically unlocked when the FileLock is disposed
        }

        /// <summary>
        /// Locks a file and asynchronously executes the specified action after the lock has been acquired
        /// </summary>
        /// <param name="filePath">The path of the file to lock</param>
        /// <param name="postLockAction">The action to execute after locking the file</param>
        /// <param name="shareMode">The FileShare mode to use for locking (default is None)</param>
        /// <returns>A FileLock object that can be used to release the lock</returns>
        public static async Task<FileLock> LockFileAndDoAsync(string filePath, Func<Task> postLockAction, FileShare shareMode = FileShare.None)
        {
            FileLock fileLock = LockFile(filePath, shareMode);

            try
            {
                // Execute the post-lock action
                await postLockAction().ConfigureAwait(false);

                // Return the file lock for later release
                return fileLock;
            }
            catch
            {
                // If an exception occurs, release the lock and re-throw
                fileLock.Release();
                throw;
            }
        }
    }
}