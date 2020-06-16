using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineSystem.Model
{
    public class PromotionCondition
    {
        public int PromotionId { get; set; }
        public string Item { get; set; }
        public int CountRequired { get; set; }

    }
}
