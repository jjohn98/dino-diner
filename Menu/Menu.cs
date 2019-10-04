/// Menu.cs
/// Author: Jack Johnson
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class which contains lists for all of the available menu items in DinoDiner.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Lists all available menu items at DinoDiner.
        /// </summary>
        public List<IMenuItem> AvailableMenuItems { get; } = new List<IMenuItem>()
        {
            new Brontowurst(),
            new PrehistoricPBJ(),
            new DinoNuggets(),
            new PterodactylWings(),
            new SteakosaurusBurger(),
            new TRexKingBurger(),
            new VelociWrap(),
            new Fryceritops(),
            new MeteorMacAndCheese(),
            new MezzorellaSticks(),
            new Triceritots(),
            new JurassicJava(),
            new Sodasaurus(),
            new Tyrannotea(),
            new Water(),
            new CretaceousCombo(new Brontowurst()),
            new CretaceousCombo(new PrehistoricPBJ()),
            new CretaceousCombo(new DinoNuggets()),
            new CretaceousCombo(new PterodactylWings()),
            new CretaceousCombo(new SteakosaurusBurger()),
            new CretaceousCombo(new TRexKingBurger()),
            new CretaceousCombo(new VelociWrap())
        };

        /// <summary>
        /// Lists all available entrees at DinoDiner.
        /// </summary>
        public List<IMenuItem> AvailableEntrees { get; } = new List<IMenuItem>()
        {
            new Brontowurst(),
            new PrehistoricPBJ(),
            new DinoNuggets(),
            new PterodactylWings(),
            new SteakosaurusBurger(),
            new TRexKingBurger(),
            new VelociWrap()
        };

        /// <summary>
        /// Lists all available sides at DinoDiner.
        /// </summary>
        public List<IMenuItem> AvailableSides { get; } = new List<IMenuItem>()
        {
            new Fryceritops(),
            new MeteorMacAndCheese(),
            new MezzorellaSticks(),
            new Triceritots()
        };

        /// <summary>
        /// Lists all available drinks at DinoDiner.
        /// </summary>
        public List<IMenuItem> AvailableDrinks { get; } = new List<IMenuItem>()
        {
            new JurassicJava(),
            new Sodasaurus(),
            new Tyrannotea(),
            new Water()
        };

        /// <summary>
        /// Lists all available entree combos at DinoDiner.
        /// </summary>
        public List<IMenuItem> AvailableCombos { get; } = new List<IMenuItem>()
        {
            new CretaceousCombo(new Brontowurst()),
            new CretaceousCombo(new PrehistoricPBJ()),
            new CretaceousCombo(new DinoNuggets()),
            new CretaceousCombo(new PterodactylWings()),
            new CretaceousCombo(new SteakosaurusBurger()),
            new CretaceousCombo(new TRexKingBurger()),
            new CretaceousCombo(new VelociWrap())
        };

        /// <summary>
        /// Adds every available menu item to a string separated by new lines.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string output = "";

            foreach (IMenuItem item in AvailableMenuItems)
            {
                output += item.ToString();
                output += "\n";
            }

            return output;
        }
    }
}
