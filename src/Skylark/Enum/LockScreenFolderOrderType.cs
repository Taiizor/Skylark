namespace Skylark.Enum
{
    /// <summary>
    /// Lock screen playlist order when a directory of videos is selected.
    /// </summary>
    public enum LockScreenFolderOrderType
    {
        /// <summary>
        /// Select a random video on each lock screen display.
        /// </summary>
        Random = 0,
        /// <summary>
        /// Select the next sequential video alphabetically on each lock.
        /// </summary>
        Sequential = 1,
        /// <summary>
        /// Always play the first video alphabetically.
        /// </summary>
        Fixed = 2
    }
}