using Order_car_class;


string orderLists;


int customerOrder;
int customerTotal;

var ForSale = new List<OrderCar>();
var Prices = new List<OrderCar>();

ForSale.Add(new OrderCar { Brand = "1. Mercedes Benz S600", Color = "Black", Year = "2022", CarsInStock = "Ready for shipment" });
ForSale.Add(new OrderCar { Brand = "2. Ford Mustang GT", Color = "Red", Year = "1969", CarsInStock = "Ready for shipment" }) ;
ForSale.Add(new OrderCar { Brand = "3. Toyota Corolla", Color = "White", Year = "1976", CarsInStock = "Ready for shipment" });
ForSale.Add(new OrderCar { Brand = "4. Volvo v90", Color = "Metallic gray", Year = "2023", CarsInStock = "Ready for shipment" });
ForSale.Add(new OrderCar { Brand = "5. Bugatti", Color = "Puppet orange", Year = "2023", CarsInStock = "Ready for shipment" });
ForSale.Add(new OrderCar { Brand = "5. Ferarri", Color = "Bloody red", Year = "2011", CarsInStock = "Ready for shipment" });

Prices.Add(new OrderCar { Price = "Mercedes Benz s600 - 105.995$" });
Prices.Add(new OrderCar { Price = "Ford Mustang GT - 135.600$" });
Prices.Add(new OrderCar { Price = "Toyota Corolla - 29.895$" });
Prices.Add(new OrderCar { Price = "Bugatti - 305.995$" });
Prices.Add(new OrderCar { Price = "Ferarri - 105.995$" });


Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Hi and welcome to Farid's Car!\n\nPlease press enter to proceed to our available cars ");
Console.ReadKey();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("-------------------------------------------------------------------------------------------");
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("Below is a complete list of our available cars");

for (int i = 0; i < ForSale.Count; i++) {

        ForSale[i].PresentCar();
        
}
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n\n Which car do you want more information about?\n");
switch (int.Parse(Console.ReadLine())) {

    case 1:
        Console.WriteLine($"\n\nOur mercedes is a superb car! the pricing starts at {OrderCar.Prices[0]}

        break;
        

}





for (int j = 0; j < Prices.Count; j++) {

    Prices[j].PresentPrice();

}
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\n\nDoes any of the cars seems interesting?");
string interestedInCar = Console.ReadLine().ToLower();
if (interestedInCar == "yes") {

    switch (ForSale) {

        



    }

} 
else if (interestedInCar == "no") {




}




Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n\n\nWould you like to place an order on any other vehicle besides the the oones in our list?");
string customerPick1 = Console.ReadLine().ToLower();

if (customerPick1 == "yes") {

    Console.WriteLine("Great!");

} else if (customerPick1 == "no") {
    Console.WriteLine("Great! Thanks for your time, if you have any consideration do not hessitate to ask.");
}

else {
    Console.WriteLine("test");
}


