﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Caching.Memory;
using YiSha.Cache.Interface;
using YiSha.Util;

namespace YiSha.MemoryCache
{
    /// <summary>
    /// 内存缓存
    /// </summary>
    public class MemoryCacheImp : ICache
    {
        /// <summary>
        /// 获取IMemoryCache实例
        /// </summary>
        private IMemoryCache cache = GlobalContext.ServiceProvider.GetService<IMemoryCache>();

        /// <summary>
        /// 设置缓存
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="expireTime">到期时间</param>
        /// <returns></returns>
        public bool SetCache<T>(string key, T value, DateTime? expireTime = null)
            => ExceptionHelper.Log(
                () => ((expireTime == null ? cache.Set(key, value) : cache.Set(key, value, (expireTime.Value - DateTime.Now))) != null),
                false
            );

        /// <summary>
        /// 删除缓存
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool RemoveCache(string key)
        {
            // ??
            cache.Remove(key);
            return true;
        }

        /// <summary>
        /// 获取缓存
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public T GetCache<T>(string key)
            => cache.Get<T>(key);

        #region Hash
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="fieldKey"></param>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public int SetHashFieldCache<T>(string key, string fieldKey, T fieldValue)
            => SetHashFieldCache<T>(key, new Dictionary<string, T> { { fieldKey, fieldValue } });

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="dict"></param>
        /// <returns></returns>
        public int SetHashFieldCache<T>(string key, Dictionary<string, T> dict)
        {
            int count = 0;
            foreach (string fieldKey in dict.Keys)
            {
                count += cache.Set(key, dict) != null ? 1 : 0;
            }
            return count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="fieldKey"></param>
        /// <returns></returns>
        public T GetHashFieldCache<T>(string key, string fieldKey)
        {
            var dict = GetHashFieldCache<T>(key, new Dictionary<string, T> { { fieldKey, default(T) } });
            return dict[fieldKey];
        }

        public Dictionary<string, T> GetHashFieldCache<T>(string key, Dictionary<string, T> dict)
        {
            var hashFields = cache.Get<Dictionary<string, T>>(key);
            foreach (KeyValuePair<string, T> keyValuePair in hashFields.Where(p => dict.Keys.Contains(p.Key)))
            {
                dict[keyValuePair.Key] = keyValuePair.Value;
            }
            return dict;
        }

        public Dictionary<string, T> GetHashCache<T>(string key)
        {
            Dictionary<string, T> dict = new Dictionary<string, T>();
            var hashFields = cache.Get<Dictionary<string, T>>(key);
            foreach (string field in hashFields.Keys)
            {
                dict[field] = hashFields[field];
            }
            return dict;
        }

        public List<T> GetHashToListCache<T>(string key)
        {
            List<T> list = new List<T>();
            var hashFields = cache.Get<Dictionary<string, T>>(key);
            foreach (string field in hashFields.Keys)
            {
                list.Add(hashFields[field]);
            }
            return list;
        }

        public bool RemoveHashFieldCache(string key, string fieldKey)
        {
            Dictionary<string, bool> dict = new Dictionary<string, bool> { { fieldKey, false } };
            dict = RemoveHashFieldCache(key, dict);
            return dict[fieldKey];
        }

        public Dictionary<string, bool> RemoveHashFieldCache(string key, Dictionary<string, bool> dict)
        {
            var hashFields = cache.Get<Dictionary<string, object>>(key);
            foreach (string fieldKey in dict.Keys)
            {
                dict[fieldKey] = hashFields.Remove(fieldKey);
            }
            return dict;
        }
        #endregion
    }
}
