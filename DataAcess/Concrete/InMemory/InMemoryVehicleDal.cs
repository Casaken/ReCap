//using DataAccess.Abstract;
//using Entities.Concrete;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataAccess.Concrete.InMemory
//{

//    public class InMemoryVehicleDal : IEntityRepository<Car>
//    {
//        List<Car> _cars;
//        public InMemoryVehicleDal()
//        {
//            _cars = new List<Car>
//            {
//                new Car{BrandId = 1, ColorId = 2, DailyPrice = 3, Description = "Porsche", CarId = 4, ModelYear = 1998},
//                new Car{BrandId = 5, ColorId = 4, DailyPrice = 2000, Description= "Volkswagen", CarId = 2, ModelYear = 1900},
//                new Car{BrandId = 6, ColorId = 7, DailyPrice = 3000, Description= "Kartal", CarId = 3, ModelYear = 1980},
//                new Car{BrandId = 8, ColorId = 10, DailyPrice = 5000, Description= "Renault", CarId = 5, ModelYear = 1500}
//            };

//        }

//        public void Add(Car car)
//        {
//            _cars.Add(car);
//        }

//        public void Delete(Car car)
//        {
//            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
//            _cars.Remove(carToDelete);
//        }

//        public Car Get(Expression<Func<Car, bool>> filter)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Car> GetAll()
//        {
//            return _cars;
//        }

//        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Car> GetById(int carId)
//        {
//            return _cars.Where(c => c.CarId == carId).ToList();
//        }

//        public void Update(Car car)
//        {
//            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
//            carToUpdate.DailyPrice = car.DailyPrice;
//            carToUpdate.Description = car.Description;
//            carToUpdate.CarId = car.CarId;

//        }

//    }
//}
