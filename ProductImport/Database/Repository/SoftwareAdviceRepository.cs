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

        public bool AddProduct(SoftwareAdviceModel product)
        {
            return true;
        }
    }
}
