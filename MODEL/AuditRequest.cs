﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class AuditRequest
    {
        long id;
        string auditType;
        string content;
        int auditorId;
        bool isPass;
        bool check;

        public AuditRequest()
        {

        }

        public AuditRequest(AdminInfo adminInfo)
        {
            id = -1;
            auditType = "管理员注册";
            content = JsonConvert.SerializeObject(adminInfo);
            auditorId = -1;
            isPass = false;
            check = false;
        }
        public AuditRequest(UserInfo userInfo)
        {
            id = -1;
            auditType = "用户注册";
            content = JsonConvert.SerializeObject(userInfo);
            auditorId = -1;
            isPass = false;
            check = false;
        }

        public long Id { get => id; set => id = value; }
        public string AuditType { get => auditType; set => auditType = value; }
        public string Content { get => content; set => content = value; }
        public bool IsPass { get => isPass; set => isPass = value; }
        public bool Check { get => check; set => check = value; }
        public int AuditorId { get => auditorId; set => auditorId = value; }
    }
}
