using Maxim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxim.Service
{
    public interface IService
    {
        Car GetNewestCar();
        IEnumerable<Car> GetCarByAlphabet();
        IEnumerable<Car> GetCarByPrice();
        Car GetBestValueCar();
        Car GetRandomCar();
        double FuelConsum(double distance, string model);
        List<AveByYear> AveMPGByYear();
    }

}
