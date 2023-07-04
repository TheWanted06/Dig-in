using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dig_in
{
    public class Recipe
    {
        public string? Name { get; set; }
        public List<Ingredient>? ingediants { get; set; }
        public List<Step>? steps { get; set; }

        public int TotalCalories(List<Ingredient> ingredient)
        {
            int count = ingredient.Count();

            int TotalCalories =0;
            foreach (var ingre in ingediants)
            {
                TotalCalories = TotalCalories + ingre.Calories;
            }
            return TotalCalories;
        }
    }
}
