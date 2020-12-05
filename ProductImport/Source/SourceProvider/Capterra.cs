using ProductImport.Model;
using ProductImport.Source.ISourceProvider;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductImport.Source.SourceProvider
{
    class Capterra : IProduct
    {
        public List<Model.SoftwareAdviceModel> ReadFile()
        {
            throw new NotImplementedException();
        }
    }
}
