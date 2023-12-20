using Business.Concrete;
//using DataAccess.Concrete.InMemory;
using DataAcess.Concrete.EntityFramework;
using Entities.Concrete;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfVehicleDal());
           
            foreach (var car in carManager.GetCarsByColorId(1))
            {
                
                Console.WriteLine(car.Description);
            }

            foreach (var car  in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.Description);
            }
        }


    }
}
