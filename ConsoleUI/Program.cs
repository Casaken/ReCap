using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryVehicleDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }


    }
}
