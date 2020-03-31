using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace System.Collections.Generic
{
    public static class AbpDictionaryExtensions
    {
        //public static TValue GetOrDefauelt<TKey,TValue>(this Dictionary<TKey,TValue> dictionary,TKey key)
        //{
        //    TValue obj;
        //    return dictionary.TryGetValue(key, out obj)?obj:default;
        //}

        /// <summary>
        /// 如果字典存在，则使用此方法尝试获取字典中的值。
        /// </summary>
        /// <typeparam name="T">value 的类型</typeparam>
        /// <param name="dictionary">key为string类型的字典</param>
        /// <param name="key">key</param>
        /// <param name="value">如果字典中确实存在key，返回true</param>
        /// <returns></returns>
        internal static bool TryGetValue<T>(this IDictionary<string,object> dictionary,string key,out T value)
        {
            if (dictionary.TryGetValue(key, out object obj) && obj is T)
            {
                value = (T)obj;
                return true;
            }
            value = default;
            return false;
        }

        /// <summary>
        /// 使用给定的键从字典中获取一个值。 如果找不到，则返回默认值。
        /// </summary>
        /// <typeparam name="TKey">key 类型</typeparam>
        /// <typeparam name="TValue">value 类型</typeparam>
        /// <param name="dictionary">字典</param>
        /// <param name="key"></param>
        /// <returns>返回查找到的指定值，如果不存在则返回默认值</returns>
        public static TValue GetOrDefault<TKey,TValue>(this IDictionary<TKey,TValue> dictionary,TKey key)
        {
            TValue value;
            return dictionary.TryGetValue(key,out value)? value: default;
        }

        /// <summary>
        /// 使用给定的键从字典中获取一个值。 如果找不到，则返回默认值。
        /// </summary>
        /// <typeparam name="TKey">key 类型</typeparam>
        /// <typeparam name="TValue">value 类型</typeparam>
        /// <param name="dictionary">字典 注意Dictionary比IDictionary 多了序列化与反序列化实现</param>
        /// <param name="key">返回查找到的指定值，如果不存在则返回默认值</param>
        /// <returns></returns>
        public static TValue GetOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key)
        {
            TValue value;
            return dictionary.TryGetValue(key, out value) ? value : default;
        }

        /// <summary>
        /// 使用给定的键从字典中获取一个值。 如果找不到，则返回默认值。
        /// </summary>
        /// <typeparam name="TKey">key 类型</typeparam>
        /// <typeparam name="TValue">value 类型</typeparam>
        /// <param name="dictionary">字典</param>
        /// <param name="key">返回查找到的指定值，如果不存在则返回默认值</param>
        /// <returns></returns>
        public static TValue GetOrDefault<TKey,TValue>(this IReadOnlyDictionary<TKey,TValue> dictionary,TKey key)
        {
            TValue value;
            return dictionary.TryGetValue(key, out value) ? value : default;
        }

        /// <summary>
        /// 使用给定的键从字典中获取一个值。 如果找不到，则返回默认值。
        /// </summary>
        /// <typeparam name="TKey">key 类型</typeparam>
        /// <typeparam name="TValue">value 类型</typeparam>
        /// <param name="dictionary">字典</param>
        /// <param name="key">返回查找到的指定值，如果不存在则返回默认值</param>
        /// <returns></returns>
        public static TValue GetOrDefault<TKey, TValue>(this ConcurrentDictionary<TKey, TValue> dictionary, TKey key)
        {
            TValue value;
            return dictionary.TryGetValue(key, out value) ? value : default;
        }
    }
}
