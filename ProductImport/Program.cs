﻿using Microsoft.Extensions.DependencyInjection;
using ProductImport.Database.IRepository;
using ProductImport.Database.Repository;
using ProductImport.Source.ISourceProvider;
using ProductImport.Source.SourceProvider;
using System;
using System.Linq;

namespace ProductImport
{
    class Program
    {
        public static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddTransient<Capterra>()
                .AddTransient<SoftwareAdvice>()
                .AddTransient<ISoftwareAdviceRepository, SoftwareAdviceRepository>()
                .AddTransient<ICapterraRepository, CapterraRepository>()
                .BuildServiceProvider();

            //if (args.Length < 3)
            //{
            //    Console.WriteLine("Please specify all the arguments");
            //    return;
            //}

            //var source = args[1];
            //var path = args[2];

            //var source = "capterra";
            //var path = "feed-products/capterra.yaml";

            var source = "softwareadvice";
            var path = "feed-products/softwareadvice.json";

            if (source.ToLower().Equals("capterra"))
            {
                var serviceType = serviceProvider.GetService<Capterra>();
                serviceType.ReadAndImport(path);
            }
            else if (source.ToLower().Equals("softwareadvice"))
            {
                var serviceType = serviceProvider.GetService<SoftwareAdvice>();
                serviceType.ReadAndImport(path);
            }
            else
            {
                Console.WriteLine("Not a valid source");
                return;
            }

            //ProductImport.exe import softwareadvice feed-products/softwareadvice.json
        }
    }
}
