#region Imports

using SANE = System.ArgumentNullException;
using SAOORE = System.ArgumentOutOfRangeException;
using SE = System.Exception;

#endregion

// |---------DO-NOT-REMOVE---------|
//
//     Creator: Taiizor
//     Website: www.Vegalya.com
//     Created: 03.Jan.2023
//     Changed: 27.Feb.2023
//     Version: 3.0.0.3
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
        public Exception(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    #endregion

    #region ArgumentException

    /// <summary>
    /// Skylark arguemnt exception class. 
    /// </summary>
    public class ArgumentException : SAOORE
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
        /// <param name="paramName"></param>
        public ArgumentException(string paramName) : base(paramName)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public ArgumentException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="paramName"></param>
        /// <param name="message"></param>
        public ArgumentException(string paramName, string message) : base(paramName, message)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="paramName"></param>
        /// <param name="actualValue"></param>
        /// <param name="message"></param>
        public ArgumentException(string paramName, object actualValue, string message) : base(paramName, actualValue, message)
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
        public ArgumentNullException(string message, Exception innerException) : base(message, innerException)
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

    #endregion
}