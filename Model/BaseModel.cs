﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DataCreated { get; set; } = DateTime.Now;
        public DateTime DataModified { get; set; }
        public DateTime DataDeleted { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
    }
}
