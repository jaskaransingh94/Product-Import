using ProductImport.Database.IRepository;
using ProductImport.Model;
using ProductImport.Source.ISourceProvider;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ProductImport.Source.SourceProvider
{
    class SoftwareAdvice : IProduct
    {
        private readonly ISoftwareAdviceRepository _iSoftwareAdviceRepository;

        public SoftwareAdvice(ISoftwareAdviceRepository iSoftwareAdviceRepository)
        {
            _iSoftwareAdviceRepository = iSoftwareAdviceRepository;
        }

        public List<SoftwareAdviceModel> ReadFile()
        {
            string fileName = "../feed-products/softwareadvice.json";
            string jsonString = File.ReadAllText(fileName);
            var productData = JsonSerializer.Deserialize<SoftwareAdviceModelList>(jsonString);
            var result = _iSoftwareAdviceRepository.AddProduct(null);

            throw new NotImplementedException();
        }
    }
}
