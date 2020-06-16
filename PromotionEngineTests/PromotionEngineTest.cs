using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngineSystem;
using PromotionEngineSystem.Model;

namespace PromotionEngineTests
{

    [TestClass]
    public class PromotionEngineTest
    {
        [TestMethod]
        public void GetActivePromotions()
        {

        }

        [TestMethod]
        public void ApplyPromotion()
        {
            //arrange
            IPromotionEngine promotionEngine = new PromotionEngine();
            var cartItems = new List<CartItem> { 
                new CartItem(){UnitId="A",UnitCount=1,UnitPrice=50 },
                new CartItem(){UnitId="B",UnitCount=1,UnitPrice=30 },
                new CartItem(){UnitId="C",UnitCount=1,UnitPrice=20 },
            };
            decimal expectedResult = 100;

            //act
            var result=promotionEngine.ApplyPromotion(cartItems);

            //assert
            Assert.AreEqual(expectedResult,result);

        }


    }
}
