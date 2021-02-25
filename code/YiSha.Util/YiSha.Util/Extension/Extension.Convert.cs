using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace YiSha.Util.Extension
{
    /// <summary>
    /// 类型转换
    /// </summary>
    public static partial class Extensions
    {
        #region 转换为long
        /// <summary>
        /// 将object转换为long，若转换失败，则返回指定值。不抛出异常。  
        /// </summary>
        /// <param name="str"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static long ParseToLong(this string str, long defaultValue)
            => long.TryParse(str, out long result) ? result : defaultValue;

        /// <summary>
        /// 将object转换为long，若转换失败，则返回0。不抛出异常。  
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static long ParseToLong(this object str)
            => ParseToLong(str?.ToString(), 0L);
        #endregion

        #region 转换为int
        /// <summary>
        /// 将object转换为int，若转换失败，则返回指定值。不抛出异常。 
        /// null返回默认值
        /// </summary>
        /// <param name="str"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static int ParseToInt(this object str, int defaultValue)
            => int.TryParse(str?.ToString(), out int result) ? result : defaultValue;

        /// <summary>
        /// 将object转换为int，若转换失败，则返回0。不抛出异常。  
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int ParseToInt(this object str)
            => ParseToInt(str, 0);
        #endregion

        #region 转换为short
        /// <summary>
        /// 将object转换为short，若转换失败，则返回指定值。不抛出异常。  
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static short ParseToShort(this object str, short defaultValue)
            => short.TryParse(str?.ToString(), out short result) ? result : defaultValue;

        /// <summary>
        /// 将object转换为short，若转换失败，则返回0。不抛出异常。  
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static short ParseToShort(this object str)
            => ParseToShort(str, 0);
        #endregion

        #region 转换为demical
        /// <summary>
        /// 将object转换为demical，若转换失败，则返回指定值。不抛出异常。  
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static decimal ParseToDecimal(this object str, decimal defaultValue)
            => decimal.TryParse(str?.ToString(), out decimal result) ? result : defaultValue;

        /// <summary>
        /// 将object转换为demical，若转换失败，则返回0。不抛出异常。  
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static decimal ParseToDecimal(this object str)
            => ParseToDecimal(str, 0.0m);
        #endregion

        #region 转化为bool
        /// <summary>
        /// 将object转换为bool，若转换失败，则返回false。不抛出异常。  
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool ParseToBool(this object str)
            => ParseToBool(str, false);

        /// <summary>
        /// 将object转换为bool，若转换失败，则返回指定值。不抛出异常。  
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool ParseToBool(this object str, bool defaultValue)
            => bool.TryParse(str?.ToString(), out bool result) ? result : defaultValue;
        #endregion

        #region 转换为float
        /// <summary>
        /// 将object转换为float，若转换失败，则返回0。不抛出异常。  
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static float ParseToFloat(this object str)
            => ParseToFloat(str, 0.0f);

        /// <summary>
        /// 将object转换为float，若转换失败，则返回指定值。不抛出异常。  
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static float ParseToFloat(this object str, float defaultValue)
            => float.TryParse(str?.ToString(), out float result) ? result : defaultValue;

        #endregion

        #region 转换为double
        /// <summary>
        /// 将object转换为double，若转换失败，则返回指定值。不抛出异常。  
        /// </summary>
        /// <param name="str"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static double ParseToDouble(this object str, double defaultValue)
            => double.TryParse(str?.ToString(), out double result) ? result : defaultValue;

        /// <summary>
        /// 将object转换为double，若转换失败，则返回0。不抛出异常。  
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static double ParseToDouble(this object obj)
            => ParseToDouble(obj, 0.0d);
        #endregion

        #region 转换为Guid
        /// <summary>
        /// 将string转换为Guid，若转换失败，则返回Guid.Empty。不抛出异常。  
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Guid ParseToGuid(this object str)
            => ParseToGuid(str, Guid.Empty);

        /// <summary>
        /// 将string转换为Guid，若转换失败，则返回Guid.Empty。不抛出异常。  
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Guid ParseToGuid(this object str, Guid defaultValue)
            => Guid.TryParse(str?.ToString(), out Guid result) ? result : defaultValue;
        #endregion

        #region 转换为DateTime
        /// <summary>
        /// 将string转换为DateTime，若转换失败，则返回日期最小值。不抛出异常。  
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DateTime ParseToDateTime(this object str)
            => ParseToDateTime(str, DateTime.MinValue);

        /// <summary>
        /// 将string转换为DateTime，若转换失败，则返回默认值。  
        /// </summary>
        /// <param name="str"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static DateTime ParseToDateTime(this object str, DateTime defaultValue)
        {
            string value = str?.ToString();
            if (string.IsNullOrEmpty(value)) return defaultValue;

            if (value.Contains("-", StringComparison.Ordinal) || value.Contains("/", StringComparison.Ordinal))
            {
                return DateTime.TryParse(value, out DateTime result) ? result : defaultValue;
            }
            else
            {
                string format = value.Length switch
                {
                    4 => "yyyy",
                    6 => "yyyyMM",
                    8 => "yyyyMMdd",
                    10 => "yyyyMMddHH",
                    12 => "yyyyMMddHHmm",
                    14 => "yyyyMMddHHmmss",
                    _ => "yyyyMMddHHmmss",
                };
                return DateTime.TryParseExact(value, format, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime result) ? result : defaultValue;
            }
        }
        #endregion

        #region 转换为string
        /// <summary>
        /// 将object转换为string，若转换失败，则返回""。不抛出异常。  
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ParseToString(this object str)
            => str?.ToString();

        public static string ParseToStrings<T>(this object str)
            => str is IEnumerable<T> list ? string.Join(",", list) : str?.ToString();
        #endregion

        #region 强制转换类型
        /// <summary>
        /// 强制转换类型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IEnumerable<T> CastSuper<T>(this IEnumerable<object> source)
        {
            if (source == null) yield break;

            foreach (object item in source)
            {
                yield return (T)Convert.ChangeType(item, typeof(T), CultureInfo.CurrentCulture);
            }
        }
        #endregion
    }
}
