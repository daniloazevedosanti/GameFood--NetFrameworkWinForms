using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFood.Model
{
    public class Food
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Food> NewFood { get; set; }

        public Food()
        {
            NewFood = new List<Food>();
        }
    }



}
