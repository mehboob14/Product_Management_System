using System;
using System.Collections.Generic;
using Store;
using Shared;
using Customers;
using SharedNamespace;
using CustomersNamespace;
using DataAccess;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {

            //database stuf
         
          //  da.FetchProducts();
            var productManager = new ProductManager();
            //var CustomersList = new Customer("");
            List<ICustomer> customerslist = new List<ICustomer>();
            var electronicProduct = new ElectronicProduct(1,"Laptop", 10000, "Lenovo", "-2021");
            var electronicProduct1 = new ElectronicProduct(2,"Apple watch", 500, "Apple","-2024");
        
            var furnitureProduct = new  FurnitureProduct(3,"Table",5000,"wood","50*48");
            var clothingproduct = new ClothingProduct(4,"T-shirt",1500,"Red","Medium");

            var customer1 = new Customer(2,"Fahad", "Khudian Street", "C1", isPremium: true);
            var customer2 = new Customer(1, "Huraira", "456 Kacha paka", "C2", true);
            {

            };
            productManager.AddProduct(electronicProduct); //productManager.Addproduct(name,price,lenevo, 2020);
            productManager.AddProduct(electronicProduct1);
            productManager.AddProduct(furnitureProduct);
            productManager.AddProduct(clothingproduct);

            productManager.RegisterCustomer(customer1);
            productManager.RegisterCustomer(customer2);
        
           bool inp = true;
            while(inp)
            {
                lineBreak();
                showMenu();
                lineBreak();
                 string input = Console.ReadLine();
                switch (input)
            {
                case "1":
                   Console.Write("Enter Customer ID to Login: ");
                   string loginCus = Console.ReadLine();
                 //  if(isValidCustomer(string loginCus,ICustomer customerlist)){
                    Console.WriteLine("Successfully login");
                 //  }else{
                   // Console.WriteLine("Customer not eits");
                 //  }
                    break;
                case "2":
                    StoreManager(productManager);
                    break;
                case "3":
                     Console.Write("Enter Your Name: ");
          string cusname =   Console.ReadLine();
          Console.Write("Enter Your Location: ");
          string cusloc = Console.ReadLine();
          Console.Write("Enter Customer ID: ");
         string cusid = Console.ReadLine();
         var cus1 = new Customer(3,cusname,cusloc,cusid);
         productManager.RegisterCustomer(cus1);
                    break;
                 case "4":
                 inp = false;
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            }
        }
        static void showMenu(){
            Console.WriteLine("Are you Customer or Product Manager?");
            Console.WriteLine("1. Customer");
            Console.WriteLine("2. Store Manager");
            Console.WriteLine("3. Login as New Customer");
            Console.WriteLine("4. Exit");
        }    

        static void StoreManager(ProductManager productManager)
        { 
            bool maninp = true;
            while(maninp){
                  lineBreak();
                ManagerMenu();
                  lineBreak();
                string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                        // productManager.DisplayProductsInfo();
                        var da = new DataAcces();
                        da.FetchProducts();
                    break;
                case "2":
                productManager.DisplayCustomers();
                break;
                case "3":
                        Console.Write("Enter product Id: ");
                
                        int proId =Int32.Parse(Console.ReadLine());
             Console.Write("Enter product name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter product price: ");
                    decimal price = decimal.Parse(Console.ReadLine());
                    Console.Write("Enter product type (electronic/grocery): ");
                    string type = Console.ReadLine().ToLower();

                    Product product;
                    if (type == "electronic")
                    {
                        Console.Write("Enter brand: ");
                        string brand = Console.ReadLine();
                        Console.Write("Enter model: ");
                        string model = Console.ReadLine();
                        product = new ElectronicProduct(proId, name, price, brand, model);
                    }
                    else
                    {
                        Console.Write("Enter weight: ");
                        string weight = Console.ReadLine();
                        product = new GroceryProduct(proId,name, price, weight);
                    }

                    productManager.AddProduct(product);

                    break;
                case "4":
                    Console.Write("Enter product name to remove: ");
                    string productName = Console.ReadLine();
                    productManager.RemoveProduct(productName);
                    break;
                case "5":
               Console.Write("Enter Customer Name: ");
                string nam = Console.ReadLine();
                 Console.Write("Enter Customer Location: ");
                string loc = Console.ReadLine();
                 Console.Write("Enter Customer ID: ");
                string id = Console.ReadLine();
                var customer = new Customer(2,nam,loc,id);
                productManager.RegisterCustomer(customer); 
                break;
                case "6":
                productManager.InviteSale();
                break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            }
        }
        static void ManagerMenu(){
             Console.WriteLine("Store Manager Operations:");
            Console.WriteLine("1. Display Products");
            Console.WriteLine("2. Display Customers");
            Console.WriteLine("3. Add Product");
            Console.WriteLine("4. Delete Product");
            Console.WriteLine("5. Add New Customer");
            Console.WriteLine("6. Invite Sale to Premium Customers");
        }
     
      static void isValidCustome(){
        //
      }
        static void lineBreak(){
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
        }
    }
}
