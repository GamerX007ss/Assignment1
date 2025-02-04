using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Product
    {
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public int ItemPrice {  get; set; }
        public int StockAmount {  get; set; }

        public Product(int ProductId,string ProducName,int ItemTotal,int StockTotal) 
        {
            if (ProductId < 5 || ProductId > 50000)
                throw new ArgumentOutOfRangeException(nameof(ProductId), "Product ID must be between 5 and 50000.");

            if (ItemTotal < 5 || ItemTotal > 5000)
                throw new ArgumentOutOfRangeException(nameof(ItemTotal), "Price must be between $5 and $5000.");

            if (StockTotal < 5 || StockTotal > 500000)
                throw new ArgumentOutOfRangeException(nameof(StockTotal), "Stock must be between 5 and 500000.");

            ProdId = ProductId;
            ProdName = ProducName;
            ItemPrice = ItemTotal;
            StockAmount = StockTotal;
        }
        public void IncreaseStock(int amount)
        {
            if(amount<0)
            {
                throw new ArgumentOutOfRangeException("Amount Must Be Positive");
            }
            StockAmount += amount;
        }
        public void DecreaseStock(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Amount Must Be Positive");
            }
            if (amount > StockAmount)
            {
                throw new InvalidOperationException("Insufficent Task");
            }
            StockAmount -= amount;
        }
    }
}
