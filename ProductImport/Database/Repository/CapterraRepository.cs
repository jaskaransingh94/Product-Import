using ProductImport.Database.Context;
using ProductImport.Database.IRepository;
using ProductImport.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductImport.Database.Repository
{
    public class CapterraRepository : ICapterraRepository
    {
        //private readonly MySqlContext _mySqlContext;

        //public CapterraRepository(MySqlContext mySqlContext)
        //{
        //    _mySqlContext = mySqlContext;
        //}

        public void AddProduct(CapterraModel product)
        {
            Console.WriteLine("Importing:");
            Console.WriteLine($"Name: {product.Name}");
            Console.WriteLine($"Tags: {product.Tags}");
            Console.WriteLine($"Twitter: {product.Twitter}");
        }
    }
}
