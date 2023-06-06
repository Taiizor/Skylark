#region Imports

using MI = Skylark.Manage.Internal;
using SAE = System.ArgumentException;
using SANE = System.ArgumentNullException;
using SAOORE = System.ArgumentOutOfRangeException;
using SE = System.Exception;

#endregion

// |---------DO-NOT-REMOVE---------|
//
//     Creator: Taiizor
//     Website: www.Vegalya.com
//     Created: 03.Jan.2023
//     Changed: 01.Jun.2023
//     Version: 3.0.0.8
//
// |---------DO-NOT-REMOVE---------|

namespace Skylark
{
    #region Core

    #region Exception

    /// <summary>
    /// Skylark exception class. 
    /// </summary>
    public class Exception : SE
    {
        /// <summary>
        /// 
        /// </summary>
        public Exception() : base()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public Exception(string message) : base(message)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public Exception(string message, SE innerException) : base(message, innerException)
        {
        }
    }

    #endregion

    #region Configuration

    /// <summary>
    /// Skylark configuration class. 
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// 
        /// </summary>
        public Configuration()
        {
            PathLength = MI.PathLength;
            TextLength = MI.TextLength;
            ParameterLength = MI.ParameterLength;
            FileLength = MI.FileLength;
            SplitSpace = MI.SplitSpace;
            SplitNewLine = MI.SplitNewLine;
            SplitSpaceNewLine = MI.SplitSpaceNewLine;
        }

        /// <summary>
        /// 
        /// </summary>
        public int PathLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int TextLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ParameterLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long FileLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string[] SplitSpace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string[] SplitNewLine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string[] SplitSpaceNewLine { get; set; }
    }

    #endregion

    #region ArgumentException

    /// <summary>
    /// Skylark arguemnt exception class. 
    /// </summary>
    public class ArgumentException : SAE
    {
        /// <summary>
        /// 
        /// </summary>
        public ArgumentException() : base()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public ArgumentException(string message) : base(message)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public ArgumentException(string message, SE innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="paramName"></param>
        public ArgumentException(string message, string paramName) : base(message, paramName)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="paramName"></param>
        /// <param name="innerException"></param>
        public ArgumentException(string message, string paramName, SE innerException) : base(message, paramName, innerException)
        {
        }
    }

    #endregion

    #region ArgumentNullException

    /// <summary>
    /// Skylark arguemnt exception class. 
    /// </summary>
    public class ArgumentNullException : SANE
    {
        /// <summary>
        /// 
        /// </summary>
        public ArgumentNullException() : base()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="paramName"></param>
        public ArgumentNullException(string paramName) : base(paramName)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public ArgumentNullException(string message, SE innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="paramName"></param>
        /// <param name="message"></param>
        public ArgumentNullException(string paramName, string message) : base(paramName, message)
        {
        }
    }

    #endregion

    #region ArgumentOutOfRangeException

    /// <summary>
    /// Skylark arguemnt exception class. 
    /// </summary>
    public class ArgumentOutOfRangeException : SAOORE
    {
        /// <summary>
        /// 
        /// </summary>
        public ArgumentOutOfRangeException() : base()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="paramName"></param>
        public ArgumentOutOfRangeException(string paramName) : base(paramName)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public ArgumentOutOfRangeException(string message, SE innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="paramName"></param>
        /// <param name="message"></param>
        public ArgumentOutOfRangeException(string paramName, string message) : base(paramName, message)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="paramName"></param>
        /// <param name="actualValue"></param>
        /// <param name="message"></param>
        public ArgumentOutOfRangeException(string paramName, object actualValue, string message) : base(paramName, actualValue, message)
        {
        }
    }

    #endregion

    #endregion
}