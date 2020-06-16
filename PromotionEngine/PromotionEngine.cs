using PromotionEngineSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineSystem
{
    public class PromotionEngine : IPromotionEngine
    {
        public decimal ApplyPromotion(List<CartItem> cartItems)
        {
            throw new NotImplementedException();
        }

        public void GetPriceList()
        {
            throw new NotImplementedException();
        }

        public decimal ProcessPromotion(List<CartItem> cartItems, List<Promotion> promotions)
        {
            ProcessModel model = new ProcessModel();
            foreach (var promotion in promotions)
            {
                var promotionItems=promotion.Conditions.Select(a => a.Item).ToList();
                var itemsPresent = cartItems.Where(a => promotionItems.Contains(a.UnitId)).ToList();
                if (itemsPresent.Count == promotionItems.Count)
                {
                    
                    foreach (var condition in promotion.Conditions)
                    {
                        var minCount = condition.CountRequired;
                        int itemsCount=itemsPresent.Where(a => a.UnitId == condition.Item).FirstOrDefault().UnitCount;
                        if (itemsCount % minCount == 0)
                        {
                            var newPrice=(itemsCount / minCount) * promotion.PromotionPrice;
                            cartItems.Where(a => a.UnitId == condition.Item).FirstOrDefault().UnitPrice = newPrice;
                        }
                        else
                        {
                            var difference = itemsCount % minCount;
                            var newPrice = (difference) * itemsPresent.FirstOrDefault().UnitPrice;
                            newPrice += ((itemsCount - difference)/minCount) * promotion.PromotionPrice;
                            cartItems.Where(a => a.UnitId == condition.Item).FirstOrDefault().UnitPrice = newPrice;
                        }


                    }
                  //  model.FinalizedItems.Add(new CartItem {UnitId=itemsPresent. })
                }
            }
            return cartItems.Sum(a=>a.UnitPrice);
        }

        List<Promotion> IPromotionEngine.GetActivePromotions()
        {
            throw new NotImplementedException();
        }
    }
}
