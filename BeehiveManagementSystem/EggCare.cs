using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class EggCare(Queen queen) : Bee("Egg Care")
    {
        public const float CARE_PROGRESS_PER_SHIFT = 0.25f;
        public override float CostPerShift => 1.35f;
        private Queen queen = queen;

        protected override void DoJob()
        {
                queen.CareForEggs(CARE_PROGRESS_PER_SHIFT);
        }
    }
}
