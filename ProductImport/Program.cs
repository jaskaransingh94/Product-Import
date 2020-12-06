using Microsoft.Extensions.DependencyInjection;
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
                .BuildServiceProvider();

            if (args.Length < 3)
            {
                Console.WriteLine("Please specify all the arguments");
                return;
            }

            var source = args[1];
            var path = args[2];

            if (source.ToLower().Equals("capterra"))
            {
                var serviceType = serviceProvider.GetService<Capterra>();
                //serviceType.ReadFile(path);
            }
            else if (source.ToLower().Equals("softwareadvice"))
            {
                var serviceType = serviceProvider.GetService<SoftwareAdvice>();
                serviceType.ReadFile(path);
            }
            else
            {
                Console.WriteLine("Not a valid source");
                return;
            }

            //import softwareadvice feed-products/softwareadvice.json
        }
    }
}
