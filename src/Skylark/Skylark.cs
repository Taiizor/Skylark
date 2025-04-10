#region Imports

using System.Runtime.Serialization;
using SAE = System.ArgumentException;
using SANE = System.ArgumentNullException;
using SAOORE = System.ArgumentOutOfRangeException;
using SE = System.Exception;
using SIOE = System.InvalidOperationException;

#endregion

// |---------DO-NOT-REMOVE---------|
//
//     Creator: Taiizor
//     Website: www.vegalya.com
//     Created: 03.Jan.2023
//     Changed: 10.Apr.2025
//     Version: 3.1.5.3
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected Exception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected ArgumentException(SerializationInfo info, StreamingContext context) : base(info, context)
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected ArgumentNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    #endregion

    #region InvalidOperationException

    public class InvalidOperationException : SIOE
    {
        /// <summary>
        /// 
        /// </summary>
        public InvalidOperationException() : base()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public InvalidOperationException(string message) : base(message)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public InvalidOperationException(string message, SE innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected InvalidOperationException(SerializationInfo info, StreamingContext context) : base(info, context)
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected ArgumentOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    #endregion

    #endregion
}