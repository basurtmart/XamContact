﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

//using SQLite;

namespace XamContacts.Model
{
    public class Contact
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("notes")]
        public string Notes { get; set; }
    }
}
