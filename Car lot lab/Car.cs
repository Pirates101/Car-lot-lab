using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_lot_lab
{
    public class Car
    {
        public string Make {  get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }


        public Car()
        {
            Make = string.Empty;
            Model = string.Empty;
            Year = 0;
            Price = 0;
        }

        public Car(string make, string model, int year, decimal price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        public override string ToString()
        {
            return $"Make: {Make} Model: {Model} Year :{Year} Price: ${Price}";
        }

        public static List<Car> GetCarsList(List<Car> carsList)
        {

            var cars = new List<Car>();
            return cars;
        }

        public static void ListCars(List<Car> carsList)
        {
            for (int i = 0; i < carsList.Count; i++)
            {
                Car car = carsList[i];
                Console.Write($" Index:{i} ");
                Console.WriteLine(car.ToString());
                
            }
            
        }

        public static List<Car> Remove(int x, List<Car> carList)
        {

            carList.RemoveAt(x);
            return carList;
        }
    }

    public class UsedCar : Car
    {
        public double Mileage { get; set; }

        public UsedCar(string make, string model, int year, decimal price, double mileage)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
            Mileage = mileage;
        }

        public override string ToString()
        {
            return $"Make: {Make} Model: {Model} Year :{Year} Price: {Price} Mileage: {Mileage}";
        }
    }
}
