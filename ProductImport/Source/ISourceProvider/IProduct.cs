using ProductImport.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductImport.Source.ISourceProvider
{
    public interface IProduct
    {
        public void ReadAndImport(string path);
    }
}
