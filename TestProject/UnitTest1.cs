using System.Runtime.CompilerServices;
using Assignment1;
using NUnit.Framework;
namespace TestProject
{
    public class Tests
    {
        
        //Product ID
        [Test]
        public void ProdIdIntializationTest()
        {
            var product = new Product(100, "Test Product", 100, 50);
            Assert.That(product.ProdId, Is.EqualTo(100));
            
        }
        [Test]
        public void ProdIdMinimumTest()
        {
            var product = new Product(5, "Test Product", 100, 50);
            Assert.That(product.ProdId, Is.EqualTo(5));

        }
        [Test]
        public void ProdIdMaximumTest()
        {
            var product = new Product(50000, "Test Product", 100, 50);
            Assert.That(product.ProdId, Is.EqualTo(50000));

        }

        //Item Price
        [Test]
        public void PriceIntialization()
        {
            var product = new Product(100, "Test Product", 100, 50);
            Assert.That(product.ItemPrice, Is.EqualTo(100));
        }
        [Test]
        public void PriceMinimum()
        {
            var product = new Product(100, "Test Product", 5, 50);
            Assert.That(product.ItemPrice, Is.EqualTo(5));
        }
        [Test]
        public void PriceMaximum()
        {
            var product = new Product(100, "Test Product", 5000, 50);
            Assert.That(product.ItemPrice, Is.EqualTo(5000));
        }
        //Stock Amount
        [Test]
        public void StockIntialization()
        {
            var product = new Product(100, "Test Product", 50, 150);
            Assert.That(product.StockAmount, Is.EqualTo(150));
        }
        [Test]
        public void StockMinimum()
        {
            var product = new Product(100, "Test Product", 50, 5);
            Assert.That(product.StockAmount, Is.EqualTo(5));
        }
        [Test]
        public void Constructor_MaximumStockAmount_ShouldInitializeCorrectly()
        {
            var product = new Product(100, "Test Product", 100, 500000);
            Assert.That(product.StockAmount, Is.EqualTo(500000));
        }
        [Test]
        public void IncreaseStock_ValidAmount_ShouldIncreaseStock()
        {
            var product = new Product(100, "Test Product", 100, 50);
            product.IncreaseStock(10);
            Assert.That(product.StockAmount, Is.EqualTo(60));
        }

        [Test]
        public void IncreaseStock_ZeroAmount_ShouldNotChangeStock()
        {
            var product = new Product(100, "Test Product", 100, 50);
            product.IncreaseStock(0);
            Assert.That(product.StockAmount, Is.EqualTo(50));
        }

        [Test]
        public void IncreaseStock_NegativeAmount_ShouldThrowException()
        {
            var product = new Product(100, "Test Product", 100, 50);
            Assert.Throws<ArgumentException>(() => product.IncreaseStock(-10));
        }
        [Test]
        public void DecreaseStock_ValidAmount_ShouldDecreaseStock()
        {
            var product = new Product(100, "Test Product", 100, 50);
            product.DecreaseStock(10);
            Assert.That(product.StockAmount, Is.EqualTo(40));
        }

    }
}