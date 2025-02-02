using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class HoneyManufacturer() : Bee("Honey Manufacturer")
    {
        public const float NECTAR_PROCESSED_PER_SHIFT = 33.15F;
        public override float CostPerShift => 1.7f;
        protected override void DoJob()
        {
            HoneyVault.ConverNecctarToHoney(NECTAR_PROCESSED_PER_SHIFT);
        }
    }
}
