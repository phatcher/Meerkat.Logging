#if NETSTANDARD
using Microsoft.Extensions.Logging;

namespace Meerkat.Logging
{
    /// <summary>
    /// Logging extensions that use the same naming as <see cref="Meerkat.Logging.ILog"/> to simplify porting.
    /// </summary>
    public static class LoggingExtensions
    {
        /// <summary>
        /// Formats and writes a debug log message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        public static void Debug(this ILogger logger, string message)
        {
            logger.LogDebug(message);
        }

        /// <summary>
        /// Formats and writes a debug log message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void Debug(this ILogger logger, string message, params object[] args)
        {
            logger.LogDebug(message, args);
        }

        /// <summary>
        /// Formats and writes an information log message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        public static void Info(this ILogger logger, string message)
        {
            logger.LogInformation(message);
        }

        /// <summary>
        /// Formats and writes an information log message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void Info(this ILogger logger, string message, params object[] args)
        {
            logger.LogInformation(message, args);
        }

        /// <summary>
        /// Formats and writes a warn log message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        public static void Warn(this ILogger logger, string message)
        {
            logger.LogWarning(message);
        }

        /// <summary>
        /// Formats and writes a warn log message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void Warn(this ILogger logger, string message, params object[] args)
        {
            logger.LogWarning(message, args);
        }

        /// <summary>
        /// Formats and writes a error log message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        public static void Error(this ILogger logger, string message)
        {
            logger.LogError(message);
        }

        /// <summary>
        /// Formats and writes a error log message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void Error(this ILogger logger, string message, params object[] args)
        {
            logger.LogError(message, args);
        }

        /// <summary>
        /// Formats and writes a trace log message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        public static void Trace(this ILogger logger, string message)
        {
            logger.LogTrace(message);
        }

        /// <summary>
        /// Formats and writes a trace log message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void Trace(this ILogger logger, string message, params object[] args)
        {
            logger.LogTrace(message, args);
        }

        /// <summary>
        /// Formats and writes a critical/fatal log message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        public static void Fatal(this ILogger logger, string message)
        {
            logger.LogCritical(message);
        }

        /// <summary>
        /// Formats and writes a critical/fatal log message
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void Fatal(this ILogger logger, string message, params object[] args)
        {
            logger.LogCritical(message, args);
        }
    }
}
#endif