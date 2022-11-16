using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Interfaces;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars { 
            get {
                return new List<Car>
                {
                    new Car 
                    { name = "Tesla",
                      shortDesc = "Быстрый автомобиль",
                      longDesc = "Быстрый и комфортный автомобиль от компании Тесла",
                      img = "/img/tesla.jpg",
                      available = true, 
                      isFavorite = true, 
                      price = 45000, 
                      Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/fordfiesta.jpg",
                        available = true,
                        isFavorite = false,
                        price = 11000,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "BMV E60",
                        shortDesc = "Мощный и тихий",
                        longDesc = "Быстрый, удобный автомобиль для гонок",
                        img = "/img/bmwe60.jpg",
                        available = true,
                        isFavorite = false,
                        price = 60000,
                        Category = _categoryCars.AllCategories.Last()
                    },

                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
