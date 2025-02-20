﻿using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class VelociWrapUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal(6.86, vw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal<uint>(356, vw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            VelociWrap vw = new VelociWrap();
            List<string> ingredients = vw.Ingredients;
            Assert.Contains<string>("Flour Tortilla", ingredients);
            Assert.Contains<string>("Chicken Breast", ingredients);
            Assert.Contains<string>("Romaine Lettuce", ingredients);
            Assert.Contains<string>("Caesar Dressing", ingredients);
            Assert.Contains<string>("Parmesan Cheese", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldDressingShouldRemoveDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.DoesNotContain<string>("Dressing", vw.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", vw.Ingredients);
        }

        [Fact]
        public void HoldCheeseShouldRemoveCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.DoesNotContain<string>("Parmesan Cheese", vw.Ingredients);
        }

        [Fact]
        public void HoldingCheeseShouldNotifySpecialChange()
        {
            VelociWrap vw = new VelociWrap();
            Assert.PropertyChanged(vw, "Special", () =>
            {
                vw.HoldCheese();
            });
        }

        [Fact]
        public void HoldingTortillaShouldNotifySpecialChange()
        {
            VelociWrap vw = new VelociWrap();
            Assert.PropertyChanged(vw, "Special", () =>
            {
                vw.HoldTortilla();
            });
        }

        [Fact]
        public void HoldingDressingShouldNotifySpecialChange()
        {
            VelociWrap vw = new VelociWrap();
            Assert.PropertyChanged(vw, "Special", () =>
            {
                vw.HoldDressing();
            });
        }

        [Fact]
        public void HoldingLettuceShouldNotifySpecialChange()
        {
            VelociWrap vw = new VelociWrap();
            Assert.PropertyChanged(vw, "Special", () =>
            {
                vw.HoldLettuce();
            });
        }

        [Fact]
        public void SpecialShouldBeCorrectAfterHoldingManyThings()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            vw.HoldDressing();
            vw.HoldTortilla();
            vw.HoldCheese();
            Assert.Collection<string>(vw.Special, item =>
            {
                Assert.Equal("Hold Caesar Dressing", item);
            },
            item =>
            {
                Assert.Equal("Hold Romaine Lettuce", item);
            },
            item =>
            {
                Assert.Equal("Hold Parmesan Cheese", item);
            },
            item =>
            {
                Assert.Equal("Hold Flour Tortilla", item);
            });
        }
    }
}
