using System;
using System.Collections.Generic;
using System.Text;

namespace XamContacts.Abstractions
{
    public class TableData
    {
        public string Id { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public byte[] Version { get; set; }
    }
}
