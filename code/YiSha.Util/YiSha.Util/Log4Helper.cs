//using log4net;
using System;

namespace YiSha.Util
{
    /// <summary>
    /// 日志辅助类(Log4net)
    /// </summary>
    public static class Log4Helper
    {
        //private static readonly ILog log = LogManager.GetLogger(string.Empty);

        ///// <summary>
        ///// 跟踪
        ///// </summary>
        ///// <param name="msg"></param>
        ///// <param name="ex"></param>
        //public static void Trace(object msg, Exception ex = null)
        //    => log.Trace(GetMessage(msg, ex));

        ///// <summary>
        ///// 调试
        ///// </summary>
        ///// <param name="msg"></param>
        ///// <param name="ex"></param>
        //public static void Debug(object msg, Exception ex = null)
        //    => log.Debug(GetMessage(msg, ex));

        ///// <summary>
        ///// 正常情报
        ///// </summary>
        ///// <param name="msg"></param>
        ///// <param name="ex"></param>
        //public static void Info(object msg, Exception ex = null)
        //    => log.Info(GetMessage(msg, ex));

        ///// <summary>
        ///// 警告
        ///// </summary>
        ///// <param name="msg"></param>
        ///// <param name="ex"></param>
        //public static void Warn(object msg, Exception ex = null)
        //    => log.Warn(GetMessage(msg, ex));

        ///// <summary>
        ///// 异常
        ///// </summary>
        ///// <param name="msg"></param>
        ///// <param name="ex"></param>
        //public static void Error(object msg, Exception ex = null)
        //    => log.Error(GetMessage(msg, ex));

        ///// <summary>
        ///// 异常
        ///// </summary>
        ///// <param name="ex"></param>
        //public static void Error(Exception ex)
        //    => log.Error(GetMessage(string.Empty, ex));

        ///// <summary>
        ///// 致命
        ///// </summary>
        ///// <param name="msg"></param>
        ///// <param name="ex"></param>
        //public static void Fatal(object msg, Exception ex = null)
        //    => log.Fatal(GetMessage(msg, ex));

        ///// <summary>
        ///// 致命
        ///// </summary>
        ///// <param name="ex"></param>
        //public static void Fatal(Exception ex)
        //    => log.Fatal(GetMessage(string.Empty, ex));

        ///// <summary>
        ///// 显示信息
        ///// </summary>
        ///// <param name="msg"></param>
        ///// <param name="ex"></param>
        ///// <returns></returns>
        //private static string GetMessage(object msg, Exception ex)
        //    => msg.ParseToString() + (ex == null ? string.Empty : GetExceptionMessage(ex));

        ///// <summary>
        ///// 异常信息
        ///// </summary>
        ///// <param name="ex"></param>
        ///// <returns></returns>
        //private static string GetExceptionMessage(Exception ex)
        //{
        //    string message = string.Empty;
        //    if (ex != null)
        //    {
        //        message += ex.Message;
        //        message += Environment.NewLine;
        //        Exception originalException = ex.GetOriginalException();
        //        if (originalException != null)
        //        {
        //            if (originalException.Message != ex.Message)
        //            {
        //                message += originalException.Message;
        //                message += Environment.NewLine;
        //            }
        //        }
        //        message += ex.StackTrace;
        //        message += Environment.NewLine;
        //    }
        //    return message;
        //}
    }
}