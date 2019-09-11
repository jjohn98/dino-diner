using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    class VelociWrap
    {
        private bool lettuce = true;
        private bool dressing = true;
        private bool tortilla = true;
        private bool cheese = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken Breast" };
                if (tortilla) ingredients.Add("Flour Tortilla");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (dressing) ingredients.Add("Caesar Dressing");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        public void HoldTortilla()
        {
            this.tortilla = false;
        }

        public void HoldDressing()
        {
            this.dressing = false;
        }

        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        public void HoldCheese()
        {
            this.cheese = false;
        }
    }
}
