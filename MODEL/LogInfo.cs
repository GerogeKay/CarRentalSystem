﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class LogInfo
    {
        //编号
        private int logId;
        public int LogId
        {
            get { return logId; }
            set { logId = value; }
        }
        //管理员Id
        private int adminId;
        public int AdminId
        {
            get { return adminId; }
            set { adminId = value; }
        }
        //用户Id
        private int userId;
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        //操作者内容
        private string content;
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        //操作时间
        private DateTime logTime;
        public DateTime LogTime
        {
            get { return logTime; }
            set { logTime = value; }
        }
        //是否删除
        private bool isDelete;
        public bool IsDelete
        {
            get { return isDelete; }
            set { isDelete = value; }
        }
    }
}
