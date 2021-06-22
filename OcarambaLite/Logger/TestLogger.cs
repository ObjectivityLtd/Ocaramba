// <copyright file="TestLogger.cs" company="Objectivity Bespoke Software Specialists">
// Copyright (c) Objectivity Bespoke Software Specialists. All rights reserved.
// </copyright>
// <license>
//     The MIT License (MIT)
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the "Software"), to deal
//     in the Software without restriction, including without limitation the rights
//     to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//     copies of the Software, and to permit persons to whom the Software is
//     furnished to do so, subject to the following conditions:
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
//     THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//     IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//     AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//     LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//     OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//     SOFTWARE.
// </license>

namespace Ocaramba.Logger
{
    using System;
    using System.Globalization;

    using NLog;
#if netcoreapp3_1 || net47
    using AventStack.ExtentReports;
#endif

    /// <summary>
    /// Class for test logger.
    /// </summary>
    public class TestLogger
    {
#if netcoreapp3_1
        /// <summary>
        /// The logger.
        /// </summary>
        public static readonly NLog.Logger Logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
#endif
#if net47 || net45
        /// <summary>
        /// The logger.
        /// </summary>
        public static readonly NLog.Logger Logger = LogManager.GetCurrentClassLogger();
#endif

#if netcoreapp3_1 || net47
        /// <summary>
        /// The ExtentTest logger.
        /// </summary>
#pragma warning disable SA1401 // Fields should be private
        public ExtentTest Test;
#pragma warning restore SA1401 // Fields should be private
#endif

        /// <summary>
        /// The start test time.
        /// </summary>
        private DateTime startTestTime;

        /// <summary>
        /// Logs the test starting.
        /// </summary>
        /// <param name="driverContext">The driver context.</param>
        public void LogTestStarting(DriverContext driverContext)
        {
            this.startTestTime = DateTime.Now;
            this.Info("*************************************************************************************");
            this.Info($"START: {driverContext.TestTitle} starts at {this.startTestTime}.");
        }

        /// <summary>
        /// Logs the test ending.
        /// </summary>
        /// <param name="driverContext">The driver context.</param>
        public void LogTestEnding(DriverContext driverContext)
        {
            var endTestTime = DateTime.Now;
            var timeInSec = (endTestTime - this.startTestTime).TotalMilliseconds / 1000d;
            this.Info($"END: {driverContext.TestTitle} ends at {endTestTime} after {timeInSec.ToString("##,###", CultureInfo.CurrentCulture)} sec..");
            this.Info("*************************************************************************************");
        }

        /// <summary>
        /// Information the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        public void Info(string message, params object[] args)
        {
            Logger.Info(CultureInfo.CurrentCulture, message, args);
#if netcoreapp3_1 || net47
            this.Test.Log(Status.Pass, message);
#endif
        }

        /// <summary>
        /// Information the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        public void Trace(string message, params object[] args)
        {
            Logger.Trace(CultureInfo.CurrentCulture, message, args);
#if netcoreapp3_1 || net47
            this.Test.Log(Status.Pass, message);
#endif
        }

        /// <summary>
        /// Information the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        public void Debug(string message, params object[] args)
        {
            Logger.Debug(CultureInfo.CurrentCulture, message, args);
#if netcoreapp3_1 || net47
            this.Test.Log(Status.Pass, message);
#endif
        }

        /// <summary>
        /// Warns the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        public void Warn(string message, params object[] args)
        {
            Logger.Warn(CultureInfo.CurrentCulture, message, args);
        }

        /// <summary>
        /// Errors the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        public void Error(string message, params object[] args)
        {
            Logger.Error(CultureInfo.CurrentCulture, message, args);
#if netcoreapp3_1 || net47
            this.Test.Log(Status.Pass, message);
#endif
        }

        /// <summary>
        /// Logs the error.
        /// </summary>
        /// <param name="e">The e.</param>
        public void LogError(Exception e)
        {
            this.Error("Error occurred: {0}", e);
            throw e;
        }
    }
}
