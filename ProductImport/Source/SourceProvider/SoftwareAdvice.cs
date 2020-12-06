﻿using ProductImport.Database.IRepository;
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

        public void ReadFile(string path)
        {
            string jsonString = File.ReadAllText(path);
            var productData = JsonSerializer.Deserialize<SoftwareAdviceModelList>(jsonString);

            foreach (var item in productData.Products)
            {
                _iSoftwareAdviceRepository.AddProduct(item);
                Console.WriteLine();
            }
        }
    }
}
