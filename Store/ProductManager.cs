using System;
using System.Collections.Generic;
using SharedNamespace;
using Shared;

namespace Store
{
    public class ProductManager
    {
        private List<Product> products = new List<Product>();
        private List<ICustomer> customers = new List<ICustomer>();
        //private List<Customer> cus = new List<Customer>();

        public void AddProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine("Product added Successfully ");
        }
        /* AddProduct(name, price, leveno, 2023){
                            
                              }
        */
        public void RemoveProduct(string productName){
             var product = products.FirstOrDefault(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));
             if(product != null){
                products.Remove(product);
                Console.WriteLine("Succuessfully Removed");
             }else {
                Console.WriteLine("product not found");
             }
        }
        public void UpdateProduct(string productName){
            var product = products.FirstOrDefault(p => p.Name.Equals(productName,StringComparison.OrdinalIgnoreCase));
        }

        public void RegisterCustomer(ICustomer customer)
        {
            customers.Add(customer);
            Console.WriteLine("Successfully Registered Customer");
        }

        public void InviteSale()
        {
            foreach (var customer in customers)
            {
                if (customer.IsPremiumCustomer())
                {
                    Console.WriteLine($"Inviting premium customers, Here's Premium Customers details:  {customer.CustomerInfo()}");
                }
            }
        }

        public void DisplayProductsInfo()
        {
            foreach (var product in products)
            {
                product.DisplayProductsInfo();
            }
        }

        public void DisplayCustomers()
        {
            foreach (var customer in customers)
            {
               // customer.CustomerInfo();
                Console.WriteLine($"Customer details : {customer.CustomerInfo()}");
            }
        }
    }
}
