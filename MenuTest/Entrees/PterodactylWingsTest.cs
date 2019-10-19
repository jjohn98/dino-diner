using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class PterodactylWingsUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Equal(7.21, pw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Equal<uint>(318, pw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            PterodactylWings pw = new PterodactylWings();
            List<string> ingredients = pw.Ingredients;
            Assert.Contains<string>("Chicken", ingredients);
            Assert.Contains<string>("Wing Sauce", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }

        [Fact]
        public void HoldingSauceShouldNotifyIngredientsChange()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.PropertyChanged(pw, "Ingredients", () =>
            {
                pw.HoldSauce();
            });
        }

        [Fact]
        public void HoldingSauceShouldNotifySpecialChange()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.PropertyChanged(pw, "Special", () =>
            {
                pw.HoldSauce();
            });
        }

        [Fact]
        public void SpecialShouldBeCorrectAfterHoldingPeppers()
        {
            PterodactylWings pw = new PterodactylWings();
            pw.HoldSauce();
            Assert.Collection<string>(pw.Special, item =>
            {
                Assert.Equal("Hold Wing Sauce", item);
            });
        }

    }
}
