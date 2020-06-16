using PromotionEngineSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineSystem.Model
{
    public class ProcessModel
    {
        public List<CartItem> FinalizedItems { get; set; }
        public List<CartItem> PendingItems { get; set; }
    }
}
