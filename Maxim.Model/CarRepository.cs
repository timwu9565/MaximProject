using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxim.Model
{
    public class CarRepository: IRepository
    {
        public IEnumerable<Car> GetAll()
        {
            return new List<Car>
            {
                new Car(){ Make="Honda", Model="CRV", Color="Green", Year=2016, Price=23845, TCC_Rating=8, Hwy_MPG=33},
                new Car(){ Make="Ford", Model="Escape", Color="Red", Year=2017, Price=23590, TCC_Rating=7.8, Hwy_MPG=32},
                new Car(){ Make="Hyundai", Model="SanteFe", Color="Grey", Year=2016, Price=24950, TCC_Rating=8, Hwy_MPG=27},
                new Car(){ Make="Mazda", Model="CX-5", Color="Red", Year=2017, Price=21795, TCC_Rating=8, Hwy_MPG=35},
                new Car(){ Make="Subaru", Model="Forester", Color="Blue", Year=2016, Price=22395, TCC_Rating=8.4, Hwy_MPG=32}
            };
        }
    }
}
