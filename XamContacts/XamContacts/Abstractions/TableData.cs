using System;
using System.Collections.Generic;
using System.Text;

namespace XamContacts.Abstractions
{
    public class TableData
    {
        public string Id { get; set; }
        public DateTime? UpdateAt { get; set; }
        public DateTime? CreateAt { get; set; }
        public byte[] Version { get; set; }
    }
}
