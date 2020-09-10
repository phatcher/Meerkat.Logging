#if NETSTANDARD
using System;

using Microsoft.Extensions.Logging;

namespace Meerkat.Logging
{
    /// <summary>
    /// Static class to provide instance of <see cref="ILoggerFactory"/> to library classes without using dependency injection
    /// </summary>
    public static class LibraryLogger
    {
        /// <summary>
        /// Get or set the logger factory
        /// </summary>
        public static ILoggerFactory Factory { get; set; }

        /// <summary>
        /// Create a new instance of <see cref="ILogger"/> using the full name of the given type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static ILogger GetLogger(Type type)
        {
            if (Factory == null)
            {
                throw new Exception("No LoggerFactory, assign LibraryLogging.Factory in startup");
            }

            return Factory.CreateLogger(type);
        }

        /// <summary>
        /// Create a new instance of <see cref="ILogger"/> using the full name of the given type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static ILogger<T> GetLogger<T>()
        {
            if (Factory == null)
            {
                throw new Exception("No LoggerFactory, assign LibraryLogging.Factory in startup");
            }

            return Factory.CreateLogger<T>();
        }
    }
}
#endif