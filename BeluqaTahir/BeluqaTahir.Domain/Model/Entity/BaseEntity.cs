﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeluqaTahir.Domain.Model.Entity
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public int? CreateByUserId { get; set; }
        public DateTime CreateData { get; set; } = DateTime.Now;
        public int? DeleteByUserId { get; set; }
        public DateTime? DeleteData { get; set; }
    }
}
