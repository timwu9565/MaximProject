using Maxim.Model;
using Maxim.Service;
using System.Collections.Generic;
using System.Web.Http;

namespace MaximProject.Controllers
{
    [RoutePrefix("api/test")]
    public class TestController : ApiController
    {
        private readonly IService _carService;
        public TestController(IService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        [Route("newest")]
        public Car GetNewestCar()
        {
            var car = _carService.GetNewestCar();
            return car;
        }

        [HttpGet]
        [Route("alphabet")]
        public IEnumerable<Car> GetCarByAlphabet()
        {
            var cars = _carService.GetCarByAlphabet();
            return cars;
        }

        [HttpGet]
        [Route("orderbyprice")]
        public IEnumerable<Car> OrderByPrice()
        {
            var cars = _carService.GetCarByPrice();
            return cars;
        }

        [HttpGet]
        [Route("best")]
        public Car GetBestCar()
        {
            var car = _carService.GetBestValueCar();
            return car;
        }

        [HttpPost]
        [Route("fuelconsum/{distance}/{make}")]
        public double Getfuelconsum(double distance, string make)
        {
            var fuel = _carService.FuelConsum(distance, make);
            return fuel;
        }

        [HttpGet]
        [Route("random")]
        public Car GetRandomCar()
        {
            var result = _carService.GetRandomCar();
            return result;
        }

        [HttpGet]
        [Route("average")]
        public List<AveByYear> AveMPGByYear()
        {
            var result = _carService.AveMPGByYear();
            return result;
        }

    }
}
