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
            throw new NotImplementedException();
        }

        List<Promotion> IPromotionEngine.GetActivePromotions()
        {
            throw new NotImplementedException();
        }
    }
}
