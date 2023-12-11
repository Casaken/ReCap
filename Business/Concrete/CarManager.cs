using Business.Abstract;
using DataAccess.Abstract;
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
    }

}
