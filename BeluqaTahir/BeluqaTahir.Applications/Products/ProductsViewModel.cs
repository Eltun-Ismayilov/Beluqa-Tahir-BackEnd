﻿using BeluqaTahir.Domain.Model.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeluqaTahir.Applications.Products
{
    public class ProductsViewModel
    {
        public int? Id { get; set; }

        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string FullName { get; set; }
        public string ShopDescription { get; set; }
        public ProductTypes ProductTypes { get; set; }
        public int ProductTypesId { get; set; }
        public string ImagePati { get; set; }
        public IFormFile file { get; set; }

    }
}