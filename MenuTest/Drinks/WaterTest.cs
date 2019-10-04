/* WaterTest
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
    /// Class to test all of the functionality of the Water class.
    /// </summary>
    public class WaterTest
    {
        /// <summary>
        /// Tests to see if the default price is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water w = new Water();
            Assert.Equal<double>(0.10, w.Price);
        }

        /// <summary>
        /// Tests to see if the default calories are correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water w = new Water();
            Assert.Equal<uint>(0, w.Calories);
        }

        /// <summary>
        /// Tests to see if the default size is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water w = new Water();
            Assert.Equal<Size>(Size.Small, w.Size);
        }

        /// <summary>
        /// Tests to see if the price is correct after setting the size to small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Water w = new Water();
            w.Size = Size.Small;
            Assert.Equal<double>(0.10, w.Price);
        }

        /// <summary>
        /// Tests to see if the price is correct after setting the size to medium.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<double>(0.10, w.Price);
        }

        /// <summary>
        /// Tests to see if the price is correct after setting the size to large.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<double>(0.10, w.Price);
        }

        /// <summary>
        /// Tests to see if the calories are correct after setting the size to small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Water w = new Water();
            w.Size = Size.Small;
            Assert.Equal<uint>(0, w.Calories);
        }

        /// <summary>
        /// Tests to see if the calories are correct after setting the size to medium.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<uint>(0, w.Calories);
        }

        /// <summary>
        /// Tests to see if the calories are correct after setting the size to large.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<uint>(0, w.Calories);
        }

        /// <summary>
        /// Tests to see if the drink contains ice by default.
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Water w = new Water();
            Assert.True(w.Ice);
        }

        /// <summary>
        /// Tests to see if you are able to remove ice.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToRemoveIce()
        {
            Water w = new Water();
            w.HoldIce();
            Assert.DoesNotContain("Ice", w.Ingredients);
            Assert.False(w.Ice);
        }

        /// <summary>
        /// Tests to see if lemon is false by default.
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Water w = new Water();
            Assert.False(w.Lemon);
        }

        /// <summary>
        /// Tests to see if you can add lemon to your water.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToAddLemon()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.Contains("Ice", w.Ingredients);
            Assert.True(w.Lemon);
        }

        /// <summary>
        /// Tests to see if the default ingredients are correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultIngredients()
        {
            Water w = new Water();
            Assert.Contains("Water", w.Ingredients);
            Assert.Contains("Ice", w.Ingredients);
        }
    }
}