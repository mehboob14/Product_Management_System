using System;
namespace Store
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        protected Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public abstract void DisplayProductsInfo();
    }

    public class ElectronicProduct : Product
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public ElectronicProduct(int id, string name, decimal price, string brand, string model) 
            : base(id, name, price)
        {
            Brand = brand;
            Model = model;
        }

        public override void DisplayProductsInfo()
        {
            Console.WriteLine($" ProductId: {Id}, ProductName: {Name}, Price: {Price}, Brand: {Brand}, Model: {Model}");
        }
    }

    public class GroceryProduct : Product
    {
        public string Measurement { get; set; }

        public GroceryProduct(int id, string name, decimal price, string measurement) 
            : base(id, name, price)
        {
            Measurement = measurement;
        }

        public override void DisplayProductsInfo()
        {
            Console.WriteLine($" ProductId: { Id},Product: {Name}, Price: {Price}, Measurement: {Measurement}");
        }
    }

    public class ClothingProduct : Product
    {
        public string Size { get; set; }
        public string Color { get; set; }

        public ClothingProduct(int id,string name, decimal price, string size, string color) 
            : base(id, name, price)
        {
            Size = size;
            Color = color;
        }

        public override void DisplayProductsInfo()
        {
            Console.WriteLine($" ProductId: {Id},Product: {Name}, Price: {Price}, Size: {Size}, Color: {Color}");
        }
    }

    public class FurnitureProduct : Product
    {
        public string Material { get; set; }
        public string Dimensions { get; set; }

        public FurnitureProduct(int id, string name, decimal price, string material, string dimensions) 
            : base(id, name, price)
        {
            Material = material;
            Dimensions = dimensions;
        }

        public override void DisplayProductsInfo()
        {
            Console.WriteLine($" ProductId: {Id},Product: {Name}, Price: {Price}, Material: {Material}, Dimensions: {Dimensions}");
        }
    }
}
