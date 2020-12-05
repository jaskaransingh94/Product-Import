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

            var sa = serviceProvider.GetService<SoftwareAdvice>();
            sa.ReadFile();
        }
    }
}
