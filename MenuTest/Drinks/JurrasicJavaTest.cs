/* JurrasicJavaTest
 * Author: Jack Johnson
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Sides;
using DinoDiner.Menu.Drinks;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    /// <summary>
    /// Class to test all of the functionality of the JurrasicJava class.
    /// </summary>
    public class JurrasicJavaTest
    {
        /// <summary>
        /// Tests to see if the default price is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<double>(0.99, java.Price);
        }

        /// <summary>
        /// Tests to see if the default calories are correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<uint>(2, java.Calories);
        }

        /// <summary>
        /// Tests to see if the default size is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }

        /// <summary>
        /// Tests to see if the price is correct after setting the size to small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Small;
            Assert.Equal<double>(0.99, java.Price);
        }

        /// <summary>
        /// Tests to see if the price is correct after setting the size to medium.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(1.49, java.Price);
        }

        /// <summary>
        /// Tests to see if the price is correct after setting the size to large.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(1.99, java.Price);
        }

        /// <summary>
        /// Tests to see if the calories are correct after setting the size to small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Small;
            Assert.Equal<uint>(2, java.Calories);
        }

        /// <summary>
        /// Tests to see if the calories are correct after setting the size to medium.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            Assert.Equal<uint>(4, java.Calories);
        }

        /// <summary>
        /// Tests to see if the calories are correct after setting the size to large.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            Assert.Equal<uint>(8, java.Calories);
        }

        /// <summary>
        /// Tests to see if the drink contains ice by default.
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.Ice);
        }

        /// <summary>
        /// Tests to see if you are able to remove ice.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToAddIce()
        {
            JurrasicJava java = new JurrasicJava();
            java.AddIce();
            Assert.Contains("Ice", java.Ingredients);
            Assert.True(java.Ice);
        }

        /// <summary>
        /// Tests to see if the default ingredients are correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultIngredients()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Contains("Water", java.Ingredients);
            Assert.Contains("Coffee", java.Ingredients);
        }

        /// <summary>
        /// Checks to see if the default value of cream room is false.
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultRoomForCream()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.RoomForCream);
        }

        /// <summary>
        /// Checks to see if you can add room for cream correctly.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToAddRoomForCream()
        {
            JurrasicJava java = new JurrasicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }

        /// <summary>
        /// Checks to see if the default value for decaf is false.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultValueForCaffeine()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.Decaf);
        }

        /// <summary>
        /// Checks to see if the default value for decaf is false.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetDecafToTrue()
        {
            JurrasicJava java = new JurrasicJava();
            java.MakeDecaf();
            Assert.True(java.Decaf);
        }
    }
}