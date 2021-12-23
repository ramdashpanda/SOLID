using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> Soaps = new List<Product>()
            {
                new Soap {Name="Liril", Description = "A Liril Product."},
                new Soap {Name="Lux", Description = "A Hindustan uniliver product."},
                new Soap {Name="Park avanu", Description = "A Luxury Product."},
                new Soap {Name="Midimix", Description = "An Auruvadic Product."},
                new Soap {Name="Margo", Description = "A neem soap."},
            };

            List<Product> ToothPastes = new List<Product>()
            {
                new ToothPaste {Name="Colgate", Description = "A Calcium Product."},
                new ToothPaste {Name="Red toothpaste", Description = "An Auruvadic product."},
                new ToothPaste {Name="Closeup", Description = " Product for white tooth."},
                new ToothPaste {Name="Pepsident", Description = "A Product for long day fresh."},
               
            };

            InventoryManagement productLogic = new InventoryManagement(new ProductData(Soaps));

            while (true)
            {
                Console.WriteLine("What do you want to do ?");
                Console.WriteLine("   1:- Press 1 to see the list of all Products.");
                Console.WriteLine("   2:- Press 2 {Product name} to see description of the product.");
                Console.WriteLine("   3:- Press 3 to exist.");

                string command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                        var products = productLogic.GetProducts();
                        Console.WriteLine();
                        Console.WriteLine("All Products:-");
                        foreach (var product in products)
                        {
                            Console.WriteLine($"-{product.Name}");
                        }
                        break;

                    case string _ when command.StartsWith("2"):
                        var parts = command.Split(':');
                        try
                        {
                            var item = productLogic.GetProductByName(parts[1]);
                            Console.WriteLine();
                            Console.WriteLine("****************************************************************************");
                            Console.WriteLine($"Name: {item.Name}");
                            Console.WriteLine($"Description: {item.Description}");
                            Console.WriteLine("****************************************************************************");
                            Console.WriteLine();
                        }
                        catch
                        {
                            Console.WriteLine("Please provide the command in correct format: 2:{product name}");
                        }

                        break;
                    case "3":
                        return;
                    defult:
                        break;
                }
            }

        }
    }
}
