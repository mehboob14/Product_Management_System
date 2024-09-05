using System;
using System.Collections.Generic;
using Store;
using SharedNamespace;

namespace CustomersNamespace
{
    public class Customer : ICustomer
    {
        private int Id;
        private string Name;
        private bool isPremium;
        private string Location;
        private string CustomerID;
        private double MonthlyE;

        private List<Product> purchasedProducts;

     
        public Customer(int id, string name, string location, string custID, bool isPremium = false)
        {
            this.Id = id;
            this.Name = name;
            this.Location = location;
            this.CustomerID = custID;
            this.purchasedProducts = new List<Product>(); 
            this.isPremium = isPremium;
        }
        public (int id, string Name, string Location, string CustomerID) CustomerInfo(){
            return (Id,Name, Location,CustomerID);
        }
        public bool IsPremiumCustomer()
        {
            return isPremium;
        }

        public void BuyProduct(Product product, double price)
        {
            MonthlyE += price;
            purchasedProducts.Add(product);
            Console.WriteLine($"{Name} purchased {product.Name}");
        }

        public void DisplayPurchasedProducts()
        {
            foreach (var product in purchasedProducts)
            {
                product.DisplayProductsInfo();
            }
        }
    }
}
