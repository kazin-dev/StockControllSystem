using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace StockManagement.DbData
{
    public class StockManagementService
    {
        public void AddProduct(Product p)
        {
            using var db = new AppDbContext();
            db.products.Add(p);
            db.SaveChanges();
            
        }
        
        public List<Product> getAllProducts()
        {
            using var db = new AppDbContext();
            return db.products.ToList();
        }

        public void UptadeProducts(int id, decimal newPrice)
        {
           using var db = new AppDbContext();
           var p = db.products.Find(id);

           if(p != null)
            {
                p.Price = newPrice;
                db.SaveChanges();
            }

        }

        public void DeleteProduct(int id)
        {
          using var db = new AppDbContext();
          var p = db.products.Find(id);

            if ( p != null)
            {
                db.products.Remove(p);
                db.SaveChanges();
            }
            
        }
    }
}