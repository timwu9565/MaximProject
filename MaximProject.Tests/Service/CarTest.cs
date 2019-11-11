using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;
using System.Threading.Tasks;
using Maxim.Service;
using Moq;
using Maxim.Model;
using System.Linq;

namespace MaximProject
{
    [TestClass]
    public class Cartest
    {
        private IRepository _carRepository;
        private IService _service;


        [TestInitialize]
        public void Initialize()
        {
            _carRepository = new CarRepository();
           _service = new CarService(_carRepository);
    }

        [TestMethod]
        public void checkNewestCar()
        {
            int result = _service.GetNewestCar().Year;
            int real = 2017;
            Assert.AreEqual(real, result);
        }

        [TestMethod]
        public void checkCarByAlphabet()
        {
            var result = _service.GetCarByAlphabet().FirstOrDefault().Color;
            var real= "Blue";
            Assert.AreSame(real, result);
        }

        [TestMethod]
        public void checkFuelConsumption()
        {
            double result = _service.FuelConsum(100, "Ford");
            double real = 100.00/32.00;
            Assert.AreEqual(real, result);
        }

    }
}