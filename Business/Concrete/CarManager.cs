using Business.Abstract;
using DataAccess.Abstract;
using DataAcess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : IVehicleService
    {
        IVehicleDal _vehicleDal;
        
        public CarManager(IVehicleDal vehicleDal)
        {
            _vehicleDal = vehicleDal;          
        }
        public List<Car> GetAll()
        {
            return _vehicleDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _vehicleDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _vehicleDal.GetAll(c => c.ColorId == colorId);
        }

        public void AddCar(Car car)
        {
            if(car.Description.Length < 2)
            {
                Console.WriteLine("Araba ismi 2 karakterden büyük olmalıdır");
            }
                
            if(car.DailyPrice <= 0)
            {
                Console.WriteLine("Araba gunluk fiyati 0 dan büyük olmalıdır");
            }
            _vehicleDal.Add(car);

            
        }
    }

}
