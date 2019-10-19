/* JurassicJavaTest
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
    /// Class to test all of the functionality of the JurassicJava class.
    /// </summary>
    public class JurassicJavaTest
    {
        /// <summary>
        /// Tests to see if the default price is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<double>(0.99, java.Price);
        }

        /// <summary>
        /// Tests to see if the default calories are correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<uint>(2, java.Calories);
        }

        /// <summary>
        /// Tests to see if the default size is correct.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }

        /// <summary>
        /// Tests to see if the price is correct after setting the size to small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Small;
            Assert.Equal<double>(0.99, java.Price);
        }

        /// <summary>
        /// Tests to see if the price is correct after setting the size to medium.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(1.49, java.Price);
        }

        /// <summary>
        /// Tests to see if the price is correct after setting the size to large.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(1.99, java.Price);
        }

        /// <summary>
        /// Tests to see if the calories are correct after setting the size to small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Small;
            Assert.Equal<uint>(2, java.Calories);
        }

        /// <summary>
        /// Tests to see if the calories are correct after setting the size to medium.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<uint>(4, java.Calories);
        }

        /// <summary>
        /// Tests to see if the calories are correct after setting the size to large.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<uint>(8, java.Calories);
        }

        /// <summary>
        /// Tests to see if the drink contains ice by default.
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.Ice);
        }

        /// <summary>
        /// Tests to see if you are able to remove ice.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToAddIce()
        {
            JurassicJava java = new JurassicJava();
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
            JurassicJava java = new JurassicJava();
            Assert.Contains("Water", java.Ingredients);
            Assert.Contains("Coffee", java.Ingredients);
        }

        /// <summary>
        /// Checks to see if the default value of cream room is false.
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.RoomForCream);
        }

        /// <summary>
        /// Checks to see if you can add room for cream correctly.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToAddRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }

        /// <summary>
        /// Checks to see if the default value for decaf is false.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultValueForCaffeine()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.Decaf);
        }

        /// <summary>
        /// Checks to see if the default value for decaf is false.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetDecafToTrue()
        {
            JurassicJava java = new JurassicJava();
            java.MakeDecaf();
            Assert.True(java.Decaf);
        }


    }
}