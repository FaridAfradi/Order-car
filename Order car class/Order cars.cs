using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_car_class {
    public class OrderCar {

    
        private string _orderList, _brand, _date, _paymentMethod, _year, _carsInstock, _color, _price;
        

        public string Brand {
            get { return _brand; }
            set { _brand = value; } }

        public string Date { 
            get { return _date; } 
            set { _date = value; } }

        public string OrderList {
            get { return _orderList; } 
            set { _orderList = value; } }

        public string Paymentmethod { 
            get { return _paymentMethod; } 
            set { _paymentMethod = value; } }

        public string Year {
            get { return _year; }
            set { _year = value; } }

        public string CarsInStock {
            get { return _carsInstock; }
            set { _carsInstock = value; } }

        public string Color {
            get { return _color; }
            set { _color = value; }
        }

        public string Price {
            get { return _price; }
            set { _price = value; }
        }
 
        public void PresentPrice() {

            Console.WriteLine($"{Price}");
        }

        public void PresentCar() {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"\n{Brand}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n{Color}\nmanifacturing year: {Year}\n{CarsInStock}");
            Console.ForegroundColor = ConsoleColor.White;

        }


    }




}

