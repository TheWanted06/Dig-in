﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dig_in
{
    public class Ingredient
    {
        public string name { get; set; }
        public string UOM { get; set; }
        public int Quantity { get; set; }
        public int Calories { get; set; }
        public FoodType Food_Group { get; set; }
        public enum FoodType 
        {
            Starches,
            Fruits,
            Vegetables,
            Grains,
            Dairy,
            Protein,
            FatsAndOils
        }
    }
}
