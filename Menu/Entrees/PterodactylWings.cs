using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    class PterodactylWings
    {
        private bool sauce = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken" };
                if (sauce) ingredients.Add("Wing Sauce");
                return ingredients;
            }
        }

        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        public void HoldSauce()
        {
            this.sauce = false;
        }
    }
}
