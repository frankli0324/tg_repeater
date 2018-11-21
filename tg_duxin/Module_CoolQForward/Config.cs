﻿using System;
using System.Collections.Generic;
using System.Text;
using Sisters.WudiLib;
using Sisters.WudiLib.Posts;
using Telegram.Bot.Types;

namespace tg_duxin.Module_CoolQForward {
    class Config {
        public static string module_name = "酷Q转发(send)";
        public static int    module_ID;

        public static int listenPort = 234;

        public static bool isStarted = false;
        public static HttpApiClient CoolQClient;
        public static ApiPostListener CoolQListener;
        public static string apiAddr = "http://localhost:233";
        public static string listenAddr = "http://+:234";

        /// <summary>
        /// 列表内的QQ成员/群组能够向TG发出消息
        /// </summary>
        /// <typeparam name="Endpoint"></typeparam>
        /// <returns></returns>
        public static List<Endpoint> CQsend = new List<Endpoint>();
        /// <summary>
        /// 列表内的QQ成员/群组能够收到来自TG的消息
        /// </summary>
        /// <typeparam name="Endpoint"></typeparam>
        /// <returns></returns>
        public static List<Endpoint> CQrecv = new List<Endpoint>();
        

        /// <summary>
        /// 列表内的TG成员/群组能够向QQ发送消息
        /// </summary>
        /// <typeparam name="Chat"></typeparam>
        /// <returns></returns>
        public static List<Chat> TGsend = new List<Chat>();
        /// <summary>
        /// 列表内的TG成员/群组能够收到来自QQ的消息
        /// </summary>
        /// <typeparam name="Chat"></typeparam>
        /// <returns></returns>
        public static List<Chat> TGrecv = new List<Chat>();


        public static string forceForwardFaliure = "要我转发什么？";
        public static string forceForwardSuccess = "强制转发成功";
        public static string setNickFormatError = "设置昵称格式错误";
        public static string setNickSuccess = "昵称设置成功";
        public static string alreadySendingMessage = "本来就在向{0}转发消息";
        public static string alreadyRecvingMessage = "本来就在接收{0}的消息";
        public static string notSendingMessage = "本来就没有在向{0}转发消息";
        public static string notRecvingMessage = "本来就没有接收来自{0}的消息";
        public static string startSendMessage = "开始向{0}转发消息";
        public static string stopSendMessage = "停止向{0}转发消息";
        public static string startRecvMessage = "开始接收{0}的消息";
        public static string stopRecvMessage = "停止接收{0}的消息";
    }
}