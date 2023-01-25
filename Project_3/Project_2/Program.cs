using System;

namespace Project_3
{
    // Interfejs, który definiuje wymagane metody dla wszystkich klas, które go implementują
    public interface IMovable
    {
        void Move();
    }

    // Klasa bazowa Vehicle
    public abstract class Vehicle
    {
        public string VehicleType { get; set; }
    }

    // Klasa Car dziedzicząca po Vehicle i implementująca IMovable
    public class Car : Vehicle, IMovable
    {
        public void Move()
        {
            Console.WriteLine("Samochód się porusza!");
        }
    }

    // Klasa Bike dziedzicząca po Vehicle i implementująca IMovable
    public class Bike : Vehicle, IMovable
    {
        public void Move()
        {
            Console.WriteLine("Rower się porusza!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Tworzymy instancję samochodu
            Car car = new Car();
            car.VehicleType = "Samochód";
            car.Move();

            // Tworzymy instancję roweru
            Bike bike = new Bike();
            bike.VehicleType = "Rower";
            bike.Move();

            Console.ReadKey();
        }
    }
}