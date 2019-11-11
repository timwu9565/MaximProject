using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maxim.Model;

namespace Maxim.Service
{
    public class CarService : IService
    {
        private readonly IRepository _carRepository;

        public CarService(IRepository carRepository)
        {
            _carRepository = carRepository;

        }
        

        public Car GetNewestCar()
        {
            var newestyear = _carRepository.GetAll().Max(c => c.Year);
            var result = _carRepository.GetAll().Where(c => c.Year == newestyear).FirstOrDefault();
            return result;
        }

        public IEnumerable<Car> GetCarByAlphabet()
        {
            var result = _carRepository.GetAll().ToList().OrderByDescending(c => c.Make);
            return result;

        }

        public IEnumerable<Car> GetCarByPrice()
        {
            var result = _carRepository.GetAll().ToList().OrderByDescending(c => c.Price);
            return result;

        }

        public Car GetBestValueCar()
        {
            var result = _carRepository.GetAll().ToList().OrderByDescending(c => c.TCC_Rating).ThenBy(c => c.Price).ThenByDescending(c => c.Hwy_MPG).FirstOrDefault();
            return result;

        }

        public double FuelConsum(double distance, string make)
        {
            
            var car = _carRepository.GetAll().Where(c => c.Make == make).FirstOrDefault();
            var fuel = distance / Convert.ToDouble(car.Hwy_MPG);
            return fuel;
        }

        public Car GetRandomCar()
        {
            var result = _carRepository.GetAll().OrderBy(c => Guid.NewGuid()).FirstOrDefault();
            return result;
        }

        public List<AveByYear> AveMPGByYear()
        {
            var result = from car in _carRepository.GetAll()
                         group car by car.Year into carByYear
                         select new AveByYear()
                         {
                             Year = carByYear.Key,
                             MPG = carByYear.Average(c => c.Hwy_MPG)
                         };
            return result.ToList();
        }
    }
}
