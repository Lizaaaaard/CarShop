using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Models;

namespace WebApplication1.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content) {
                   
            
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                        new Car
                        {
                            name = "Tesla",
                            shortDesc = "Быстрый автомобиль",
                            longDesc = "Быстрый и комфортный автомобиль от компании Тесла",
                            img = "/img/tesla.jpg",
                            available = true,
                            isFavorite = true,
                            price = 45000,
                            Category = Categories["Электромобили"]
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
                        Category = Categories["Классические автомобили"]
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
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Mercedes e class",
                        shortDesc = "Удобный",
                        longDesc = "Быстрый, удобный автомобиль",
                        img = "/img/merc.jpg",
                        available = true,
                        isFavorite = true,
                        price = 55000,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Kia sportage",
                        shortDesc = "Тихий",
                        longDesc = "Комфортный авто для городской жизни",
                        img = "/img/kia.jpg",
                        available = true,
                        isFavorite = false,
                        price = 29000,
                        Category = Categories["Классические автомобили"]
                    }
                    );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories { 
            get { 
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Электромобили", desc = "Современный вид транспорта"},
                        new Category { categoryName = "Классические автомобили", desc = "Машины с ДВС"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }
                return category;
            }
        }
    }
}
