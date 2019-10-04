/* TyrannoteaTest
 * Author: Jack Johnson
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    /// <summary>
    /// Class to test all of the functionality of the Tyrannotea class.
    /// </summary>
    public class TyrannoteaTest
    {   
        /// <summary>
        /// Tests to see if the default price is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(0.99, tea.Price);
        }

        /// <summary>
        /// Tests to see if the default calories are correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }

        /// <summary>
        /// Tests to see if the default size is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, tea.Size);
        }

        /// <summary>
        /// Tests to see if the price is correct after setting the size to small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            Assert.Equal<double>(0.99, tea.Price);
        }

        /// <summary>
        /// Tests to see if the price is correct after setting the size to medium.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
        }

        /// <summary>
        /// Tests to see if the price is correct after setting the size to large.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
        }

        /// <summary>
        /// Tests to see if the calories are correct after setting the size to small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }

        /// <summary>
        /// Tests to see if the calories are correct after setting the size to medium.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }

        /// <summary>
        /// Tests to see if the calories are correct after setting the size to large.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }

        /// <summary>
        /// Tests to see if the drink contains ice by default.
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }

        /// <summary>
        /// Tests to see if you are able to remove ice.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToRemoveIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.DoesNotContain("Ice", tea.Ingredients);
            Assert.False(tea.Ice);
        }

        /// <summary>
        /// Tests to see if you are able to add sugar, and that the calories are correct after doing so.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToAddSugar()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSugar();
            Assert.Contains("Cane Sugar", tea.Ingredients);
            Assert.Equal<uint>(16, tea.Calories);
        }

        /// <summary>
        /// Tests to see if the sugar is set to false by default.
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultSugar()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Sugar);
        }

        /// <summary>
        /// Tests to see if you are able to remove sugar, and that the calories are correct after doing so.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToRemoveSugar()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSugar();
            Assert.True(tea.Sugar);
            Assert.Equal<uint>(16, tea.Calories);
            tea.RemoveSugar();
            Assert.False(tea.Sugar);
            Assert.Equal<uint>(8, tea.Calories);
        }

        /// <summary>
        /// Tests to see if the default ingredients are correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Contains("Water", tea.Ingredients);
            Assert.Contains("Ice", tea.Ingredients);
            Assert.Contains("Tea", tea.Ingredients);
        }
    }

}