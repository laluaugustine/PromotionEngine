using PromotionEngineSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineSystem
{
    public interface IPromotionEngine
    {
        decimal ApplyPromotion(List<CartItem> cartItems);
        List<Promotion> GetActivePromotions();
        void GetPriceList();
        decimal ProcessPromotion(List<CartItem> cartItems,List<Promotion> promotions);

    }
}
