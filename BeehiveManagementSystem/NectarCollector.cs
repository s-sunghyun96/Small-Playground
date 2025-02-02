using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class NectarCollector() : Bee("Nectar Collector")
    {
        public const float NECTAR_COLLECTED_PER_SHIFT = 33.25F;
        public override float CostPerShift => 1.95f;

        protected override void DoJob()
        {
            HoneyVault.CollectNectar(NECTAR_COLLECTED_PER_SHIFT);
        }
    }
}
