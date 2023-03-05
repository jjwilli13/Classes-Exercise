namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Make = "Toyota";
            myCar.Model = "Sequoia";
            myCar.Year = 2012;

            Car secondCar = new Car();

            secondCar.Make = "Chevy";
            secondCar.Model = "Cavalier";
            secondCar.Year = 2005;

            Console.WriteLine($"{myCar.Make} {myCar.Model} {myCar.Year}");
            Console.WriteLine($"{secondCar.Make} {secondCar.Model} {secondCar.Year}");

            var carList = new List<Car>() { myCar, secondCar };

            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }
        }
    }
}
