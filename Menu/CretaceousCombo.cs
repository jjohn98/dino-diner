using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;
using DinoDiner.Menu.Drinks;


namespace DinoDiner.Menu
{
    class CretaceousCombo
    {
        public Entree Entree { get; set; }

        private Side side;

        public Side Side { get { return Side; } set { side = value; side.Size = size; } }

        private Drink drink;

        public Drink Drink { get { return Drink; } set { drink = value; drink.Size = size; } }

        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        private Size size;

        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
            }
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        public CretaceousCombo(Entree e)
        {
            Entree = e;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }
    }
}
