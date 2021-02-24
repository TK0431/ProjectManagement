using System;

namespace YiSha.Util
{
    /// <summary>
    /// 异常帮助类
    /// </summary>
    public static class ExceptionHelper
    {
        /// <summary>
        /// 异常写日志
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="func"></param>
        /// <param name="failed"></param>
        /// <returns></returns>
        public static T Log<T>(Func<T> func,T failed)
        {
            try
            {
                if (func == null) return failed;
                return func();
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex);
            }
            return failed;
        }
    }
}
