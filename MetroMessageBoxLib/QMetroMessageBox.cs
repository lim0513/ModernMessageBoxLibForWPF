﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MetroMessageBoxLib
{
    /// <summary>
    /// 对MetroMessageBox的常用实现,
    /// 使用方法类似于WPF的MessageBox.
    /// Common usage of MetroMessageBox,
    /// Just like using <see cref="System.Windows.MessageBox"/> in WPF.
    /// </summary>
    public static class QMetroMessageBox
    {
        static QMetroMessageBox()
        {
            ChDefaultBtnTxt(CultureInfo.CurrentCulture);
        }


        public static void ChDefaultBtnTxt(CultureInfo region)
        {
            ChDefaultBtnTxt(region.Name);
        }

        public static void ChDefaultBtnTxt(string region)
        {

        }
        
        /// <summary>
        /// 创建并显示一个信息框
        /// Create and show a Metro Messagebox
        /// </summary>
        /// <param name="msg">Message</param>
        /// <param name="title">Title</param>
        /// <param name="btns">
        /// The bottons to show
        /// 要显示的按钮
        /// </param>
        /// <param name="icon">
        /// The icon to show
        /// 要显示的图标
        /// </param>
        /// <param name="defaultResult">
        /// the default focus button
        /// 默认聚焦的按钮
        /// </param>
        public static MetroMessageboxResult Show(string msg, string title, QMetroMessageBoxButtons btns,
                                                  MetroMessageboxIcons icon = MetroMessageboxIcons.None,
                                                  MetroMessageboxResult defaultResult = MetroMessageboxResult.Button1)
        {
            if (defaultResult == MetroMessageboxResult.CloseCaptionButton ||
                defaultResult == MetroMessageboxResult.Unknown) {
                throw new ArgumentException(nameof(defaultResult));
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// Create and show a metro messagebox with a warning sign and a "OK" button
        /// 创建并显示一个带有警告标识和"确定"按钮的消息框
        /// </summary>
        /// <param name="msg">Message</param>
        /// <param name="title">Title</param>
        public static void Warning(string msg, string title) =>
            Show(msg, title, QMetroMessageBoxButtons.Ok, MetroMessageboxIcons.Warning);

        /// <summary>
        /// Create and show a metro messagebox with a infomation sign and a "OK" button
        /// 创建并显示一个带有信息标识和"确定"按钮的消息框
        /// </summary>
        /// <param name="msg">Message</param>
        /// <param name="title">Title</param>
        public static void Info(string msg, string title) =>
            Show(msg, title, QMetroMessageBoxButtons.Ok, MetroMessageboxIcons.Info);

        /// <summary>
        /// Create and show a metro messagebox with a error sign and a "OK" button
        /// 创建并显示一个带有错误标识和"确定"按钮的消息框
        /// </summary>
        /// <param name="msg">Message</param>
        /// <param name="title">Title</param>
        public static void Error(string msg, string title) =>
            Show(msg, title, QMetroMessageBoxButtons.Ok, MetroMessageboxIcons.Error);

        /// <summary>
        /// Create and show a metro messagebox with a question sign and a "OK" button
        /// 创建并显示一个带有问号标识和"确定"按钮的消息框
        /// </summary>
        /// <param name="msg">Message</param>
        /// <param name="title">Title</param>
        public static void Question(string msg, string title) =>
            Show(msg, title, QMetroMessageBoxButtons.Ok, MetroMessageboxIcons.Question);

        /// <summary>
        /// Create and show a metro messagebox with a "OK" button
        /// 创建并显示一个带有"确定"按钮的消息框
        /// </summary>
        /// <param name="msg">Message</param>
        /// <param name="title">Title</param>
        public static void None(string msg, string title) => Show(msg, title,QMetroMessageBoxButtons.Ok);

        /// <summary>
        /// Create and show a metro messagebox with a done sign and a "OK" button
        /// 创建并显示一个带有对勾标识和"确定"按钮的消息框
        /// </summary>
        /// <param name="msg">Message</param>
        /// <param name="title">Title</param>
        public static void Done(string msg, string title) =>
            Show(msg, title, QMetroMessageBoxButtons.Ok, MetroMessageboxIcons.Done);

        /// <summary>
        /// QMetroMessagebox的按扭组合
        /// </summary>
        public enum QMetroMessageBoxButtons
        {
            /// <summary>
            /// 按钮1:确定
            /// Button1:OK
            /// </summary>
            Ok,
            /// <summary>
            /// 按钮1:确定
            /// 按钮2:取消
            /// Button1:OK
            /// Button2:Cancel
            /// </summary>
            OkCancel,
            /// <summary>
            /// 按钮1:是
            /// 按钮2:否
            /// Button1:Yes
            /// Button2:No
            /// </summary>
            YesNo,
            /// <summary>
            /// 按钮1:是
            /// 按钮2:否
            /// 按钮3:取消
            /// Button1:Yes
            /// Button2:No
            /// Button3:Cancel
            /// </summary>
            YesNoCance,
            /// <summary>
            /// 按钮1:中止
            /// 按钮2:重试
            /// 按钮3:忽略
            /// Button1:Abort
            /// Button2:Retry
            /// Button3:Ignore
            /// </summary>
            AbortRetryIgnore,
        }
    }
}
