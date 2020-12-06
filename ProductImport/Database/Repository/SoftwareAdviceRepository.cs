using ProductImport.Database.Context;
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
            Console.Write("Categories: ");
            foreach (var item in product.Categories)
            {
                if (item == product.Categories[product.Categories.Count - 1])
                    Console.WriteLine(item);
                else
                    Console.Write(item + ",");
            }
            var twitter = product.Twitter == null ? "N.A." : product.Twitter;
            Console.WriteLine($"Twitter: {twitter}");
        }
    }
}
