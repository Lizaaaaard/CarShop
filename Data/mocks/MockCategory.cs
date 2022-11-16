using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Interfaces;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get {
                return new List<Category> {
                    new Category { categoryName = "Электромобили", desc = "Современный вид транспорта"},
                    new Category { categoryName = "Классические автомобили", desc = "Машины с ДВС"}
                };
            }
        }
    }
}
