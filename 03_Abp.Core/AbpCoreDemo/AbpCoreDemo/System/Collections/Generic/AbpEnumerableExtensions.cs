using System;
using System.Collections.Generic;
using System.Text;

namespace System.Collections.Generic
{
    public static class AbpEnumerableExtensions
    {
        /// <summary>
        /// 使用每个成员之间的指定分隔符来连接构造<see cref =“ IEnumerable {T}” />类型为System.String。这是string.Join（...）的快捷方式
        /// </summary>
        /// <param name="source">包含要连接的字符串的集合</param>
        /// <param name="separator">分隔符字符串</param>
        /// <returns>返回一个字符串，包含由分隔符字符串分隔的值的成员。 如果source没有成员，则该方法返回System.String.Empty。</returns>
        public static string JoinAsString(this IEnumerable<string> source,string separator)
        {
            return string.Join(separator,source);
        }

        public static string JoinAsString<T>(this IEnumerable<T> source,string separator)
        {
            return string.Join<T>(separator,source);
        }
    }
}
