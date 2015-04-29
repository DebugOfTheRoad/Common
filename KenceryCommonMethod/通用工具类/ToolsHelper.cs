﻿// 源文件头信息：
// <copyright file="ToolsHelper.cs">
// Copyright(c)2014-2034 Kencery.All rights reserved.
// 个人博客：http://www.cnblogs.com/hanyinglong
// 创建人：韩迎龙(kencery)
// 创建时间：2014/12/10 10:17
// </copyright>

using System;
using System.Linq;

namespace KenceryCommonMethod
{
    /// <summary>
    /// 通用工具类，封装大量方便调用的方法
    ///     1.参考博客：http://www.cnblogs.com/guomingfeng/p/extensions.html
    /// <auther>
    ///     <name>Kencery</name>
    ///     <date>2014/7/3</date>
    /// </auther>
    /// 修改记录：时间  内容  姓名
    ///     1.2015/01/14   添加正则表达式的(邮箱，IP，身份证等)验证，提供后面调用  by Kencery
    /// </summary>
    public static class ToolsHelper
    {
        /// <summary>
        /// 获取GUID随机字符串,除去“—”显示的信息
        /// </summary>
        public static string GetGuidInfo()
        {
            return Guid.NewGuid().ToString("N");
        }

        #region----------------将传递过来的字符串按照需要的分隔符转换成int[]和string[]-------------------

        /// <summary>
        /// 以指定的char类型的符号作为分隔符将指定的字符串分割成int数组
        /// </summary>
        /// <param name="stringComma">需要分割的字符串</param>
        /// <param name="strSplit">char类型的分隔符</param>
        /// <returns></returns>
        public static int[] ConvertIntArrayInfo(string stringComma, char strSplit = ',')
        {
            string[] stringArray = stringComma.Split(new[] {strSplit});
            var intPurchaseOrderIdS = new int[stringArray.Count()];
            for (int i = 0; i < stringArray.Count(); i++)
            {
                intPurchaseOrderIdS[i] = Convert.ToInt32(stringArray[i]);
            }
            return intPurchaseOrderIdS;
        }

        /// <summary>
        /// 以指定字符串作为分割符将指定字符串分割成数组
        /// </summary>
        /// <param name="value">要分割的字符串</param>
        /// <param name="strSplit">字符串类型的分隔符</param>
        /// <param name="removeEmptyEntries">是否移除数据中元素为空字符串的项，true为移除，false为不移除</param>
        /// <returns>返回分割后的字符串数组</returns>
        public static string[] ConvertStringInfo(this string value, string strSplit = ",",
            bool removeEmptyEntries = false)
        {
            return value.Split(new[] {strSplit},
                removeEmptyEntries ? StringSplitOptions.RemoveEmptyEntries : StringSplitOptions.None);
        }

        #endregion


    }
}