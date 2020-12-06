﻿using ProductImport.Database.Context;
using ProductImport.Database.IRepository;
using ProductImport.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductImport.Database.Repository
{
    public class SoftwareAdviceRepository : ISoftwareAdviceRepository
    {
        //private readonly MySqlContext _mySqlContext;

        //public SoftwareAdviceRepository(MySqlContext mySqlContext)
        //{
        //    _mySqlContext = mySqlContext;
        //}

        public void AddProduct(SoftwareAdviceModel product)
        {
            Console.WriteLine("Importing:");
            Console.WriteLine($"Name: {product.Title}");
            Console.WriteLine($"Categories: {String.Join(",", product.Categories)}");
            Console.WriteLine($"Twitter: {product.Twitter}");
        }
    }
}
