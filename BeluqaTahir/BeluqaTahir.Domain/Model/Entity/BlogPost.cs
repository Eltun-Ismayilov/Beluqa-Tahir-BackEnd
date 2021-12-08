﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeluqaTahir.Domain.Model.Entity
{
   public class BlogPost:BaseEntity
    {
        public string ImagePati { get; set; }

        public DateTime? PublishedDate { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ShopDescription { get; set; }

        public string Body { get; set; }


    }
}