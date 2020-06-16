using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineSystem.Model
{
    public class Promotion
    {
        public string PromotionText { get; set; }
        public int PromotionId { get; set; }
        public int PromotionPrice { get; set; }
        public bool IsActive { get; set; }
        public List<PromotionCondition> Conditions { get; set; }
    }
}
