using NUnit.Framework;
using ProductImport.Source.SourceProvider;

namespace ProductImportTest
{
    public class Tests
    {
        private SoftwareAdvice _softwareAdvice;

        [SetUp]
        public void Setup()
        {
            _softwareAdvice = new SoftwareAdvice(null);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}