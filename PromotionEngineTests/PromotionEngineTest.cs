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
        public void ProcessPromotion()
        {
            //arrange
            IPromotionEngine promotionEngine = new PromotionEngine();
            var cartItems = new List<CartItem> {
                new CartItem(){UnitId="A",UnitCount=5,UnitPrice=50 },
                new CartItem(){UnitId="B",UnitCount=5,UnitPrice=30 },
                new CartItem(){UnitId="C",UnitCount=1,UnitPrice=20 },
            };
            var promotions = new List<Promotion> {
                new Promotion(){ PromotionId=1,PromotionText="3 of A's for 130",PromotionPrice=130,IsActive=true,
                    Conditions=new List<PromotionCondition>{
                    new PromotionCondition(){Item="A",CountRequired=3}
                    }
                },
                new Promotion(){ PromotionId=2,PromotionText="2 of B's for 45",PromotionPrice=45,IsActive=true,
                    Conditions=new List<PromotionCondition>{
                    new PromotionCondition(){Item="B",CountRequired=2}
                    }
                },
                new Promotion(){ PromotionId=3,PromotionText="C & D for 30",PromotionPrice=30,IsActive=true,
                    Conditions=new List<PromotionCondition>{
                    new PromotionCondition(){Item="C",CountRequired=1},
                    new PromotionCondition(){Item="D",CountRequired=1}
                    }
                }
            };
            decimal expectedResult = 370;

            //act
            var result = promotionEngine.ProcessPromotion(cartItems, promotions);

            //assert
            Assert.AreEqual(expectedResult, result);
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
