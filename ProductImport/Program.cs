using Microsoft.Extensions.DependencyInjection;
using ProductImport.Source.ISourceProvider;
using ProductImport.Source.SourceProvider;
using System;

namespace ProductImport
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IProduct, Capterra>()
                .AddSingleton<IProduct, SoftwareAdvice>()
                .BuildServiceProvider();
        }
    }
}
