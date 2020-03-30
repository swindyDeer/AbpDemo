﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace System.Collections.Generic
{
    /// <summary>
    /// Collections 扩展方法
    /// </summary>
    public static class AbpCollectionExtensions
    {
        /// <summary>
        /// 检查给定的集合对象是否为null或没有元素。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty<T>(this ICollection<T> source)
        {
            return source == null || source.Count == 0;
        }

        /// <summary>
        /// 如果元素不在集合中，则将其添加到集合中。
        /// </summary>
        /// <typeparam name="T">集合中元素的类型</typeparam>
        /// <param name="source">集合</param>
        /// <param name="item">要检查并添加的元素</param>
        /// <returns></returns>
        public static bool AddIfNotContains<T>(this ICollection<T> source,T item)
        {
            //check null
            if(source.Contains(item))
            {
                return false;
            }
            else
            {
                source.Add(item);
                return true;
            }
        }

        /// <summary>
        /// 如果元素不在集合中，则将其添加到集合中,并返回添加的子集合
        /// </summary>
        /// <typeparam name="T">集合中元素的类型</typeparam>
        /// <param name="source">集合</param>
        /// <param name="items">要检查并添加的元素</param>
        /// <returns></returns>
        public static IEnumerable<T> AddIfNotContains<T>(this ICollection<T> source,IEnumerable<T> items)
        {
            //check null
            var addedItems = new List<T>();
            foreach(var item in items)
            {
                if(source.Contains(item))
                {
                    continue;
                }
                source.Add(item);
                addedItems.Add(item);
            }
            return addedItems;
        }

        /// <summary>
        /// 根据给定的条件将一个元素添加到集合中（如果尚不在集合中）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">集合</param>
        /// <param name="predicate">确定元素是否已在集合中的条件</param>
        /// <param name="itemFactory">返回元素的工厂</param>
        /// <returns></returns>
        public static bool AddIfNotContains<T> (this ICollection<T> source,Func<T,bool> predicate,Func<T> itemFactory)
        {
            //check null
            //如果满足元素已在集合中
            if (source.Any(predicate))
            {
                return false;
            }
            source.Add(itemFactory());
            return true;
        }
    }
}
