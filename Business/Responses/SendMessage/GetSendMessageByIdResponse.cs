﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.SendMessage
{
    public class GetSendMessageByIdResponse
    {
        public int Id { get; set; }
        public string? ReceiverName { get; set; }
        public string? ReceiverMail { get; set; }
        public string? SenderName { get; set; }
        public string? SenderMail { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
    }
}
