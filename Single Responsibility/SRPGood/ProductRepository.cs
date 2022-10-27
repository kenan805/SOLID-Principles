using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility.SRPGood
{
    public class ProductRepository
    {
        private static List<Product> productList = new List<Product>();
        public ProductRepository()
        {
            productList = new()
            {
                new(){ Id=1, Name= "Book" },
                new(){ Id=2, Name= "Pen" },
                new(){ Id=3, Name= "Phone" },
                new(){ Id=4, Name= "Computer" },
                new(){ Id=5, Name= "Bag" },
            };
        }

        public List<Product> GetProducts() => productList;

        public void SaveOrUpdate(Product product)
        {
            var hasProduct = productList.Any(p => p.Id == product.Id);
            if (!hasProduct)
            {
                productList.Add(product);
            }
            else
            {
                var index = productList.FindIndex(p => p.Id == product.Id);
                productList[index] = product;
            }
        }

        public void Delete(int id)
        {
            var hasProduct = productList.Find(p => p.Id == id);

            if (hasProduct == null)
            {
                throw new Exception("Product is null");
            }

            productList.Remove(hasProduct);
        }
    }
}
