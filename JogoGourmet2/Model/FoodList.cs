using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFood.Model
{
    public class FoodList
    {
        public List<Food> PlateFood { get; set; }

        public FoodList()
        {
            SetItem();
        }

        private void SetItem()
        {
            PlateFood = new List<Food>();
            PlateFood.Add(new Food()
            {
                Name = "Feijoada",
                Type = "comida brasileira",
            });
            PlateFood.Add(new Food()
            {
                Name = "Lasanha",
                Type = "massa",
            });
            PlateFood.Add(new Food()
            {
                Name = "Churrasco",
                Type = "",
            });
            PlateFood.Add(new Food()
            {
                Name = "Bolo de Chocolate",
                Type = "sobremesa"
            });
        }
    }
}

