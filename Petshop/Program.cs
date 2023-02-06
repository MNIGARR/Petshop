using System;
using System.Threading;
using Petshop;
using System.ComponentModel.DataAnnotations;

Petshopclass shop = new();
Cats cat = new Cats();
shop.CatHouses.Add(new CatHouse { Name = "Eganis Zoo" });
shop.CatHouses.Add(new CatHouse { Name = "The Nixa Cats" });
shop.CatHouses[0].AddCat(new Cats { Nickname = "Rex", Age = 1, Gender = true, Energy = 100, Price = 9990, MealQuantity = 100 });
shop.CatHouses[0].AddCat(new Cats { Nickname = "Simba", Age = 0.3, Gender = true, Energy = 100, Price = 10000, MealQuantity = 100 });


void MainMenu()
{
    Console.Clear();
    Console.WriteLine("1. Petshop;");
    Console.WriteLine("2. Cathouse elave et;");
    Console.WriteLine("0. Geri don.");
    var key = Console.ReadKey();
    switch(key.Key)
    {
        case ConsoleKey.D1:
        case ConsoleKey.NumPad1:
            ShowCatHouses();
            break;
        case ConsoleKey.D2:
        case ConsoleKey.NumPad2:
            AddCatHouse();
            break;
        default:
            break;
    }
}

void AddCatHouse()
{
    Thread.Sleep(4000);
    Console.Clear();
    Console.WriteLine("Evin adi: ");
    var chname = Console.ReadLine();
    CatHouse house = new() { Name = chname };
    shop.CatHouses.Add(house);
}

void AddCat()
{
    Thread.Sleep(3000);
    Console.Clear();
    Console.WriteLine("Pisiyin adi: ");
    string? catname = Console.ReadLine();
    Console.WriteLine("Pisiyin yasi: ");
    int catage = Convert.ToInt32(Console.ReadLine());
    shop.CatHouses[0].AddCat(new Cats { Nickname = catname, Age = catage, Gender = true, Energy = 100, Price = 9990, MealQuantity = 100 });
}
void ShowCatHouse(CatHouse house) {
    Console.Clear();
    Console.WriteLine(house.Name);
    Console.WriteLine("1. Pisikler;");
    Console.WriteLine("2. Pisik elave et");
    Console.WriteLine("3. Geri don.");
    var key = Console.ReadKey();
    switch (key.Key)
    {
        case ConsoleKey.D1:
        case ConsoleKey.NumPad1:
            Thread.Sleep(5000);
            Console.Clear();
            int i = 1;
            foreach(var cat in house.Catsl)
            {
                Console.WriteLine($"{i++}: {cat.Nickname}");
            }
            
            break;
        case ConsoleKey.D2:
        case ConsoleKey.NumPad2:
            AddCat();
            break;
        default: break;
    }
}


void ShowCatHouses()
{
    Console.Clear();
    if (shop.CatHouseCount > 0)
    {
        int index = 0;
        foreach(var house in shop.CatHouses)
        {
            index++;
            Console.WriteLine($"\n{index} : {house.Name}");
        }
        var key = Console.ReadLine();
        if (int.TryParse(key, out int result) && 0 <= result && result <= shop.CatHouseCount)
        {
            ShowCatHouse(shop.CatHouses[result - 1]);
        }
    }
    else
    {
        Console.WriteLine("Cathouse movcud deyil.");
    }
}
while(true)
{
    MainMenu();
}