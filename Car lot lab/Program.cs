namespace Car_lot_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carsList = new List<Car>();


            carsList.Add(new Car("Ford","Fusion",2010,30_000));
            carsList.Add(new Car("Ford", "Escape", 2020, 26_000));
            carsList.Add(new Car("Honda", "Civic", 2018, 27_000));
            carsList.Add(new UsedCar("Mazda", "3", 2016, 20_000,10_000));
            carsList.Add(new UsedCar("Ford", "Mustang", 2018, 33_000, 20_000));
            carsList.Add(new UsedCar("Honda", "Accord", 2022, 27_000, 18_000));

            
            Car.ListCars(carsList);
            int index = GetUserIndex();
            Console.WriteLine(carsList[index]);
            Car.Remove(index, carsList);
            Car.ListCars(carsList);
        }

        static int GetUserIndex()
        {
            while (true)
            {
                Console.WriteLine("Enter the index of the car you would like to buy ");
                string userIndex = Console.ReadLine();
                if (int.TryParse(userIndex, out int index) && index <= 5 && index >= 0)
                {
                    return index;
                }

                Console.WriteLine("Invalid input, press and key to try again");
                Console.ReadKey();
            }
        }
    }
}