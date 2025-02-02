using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class Bee(string job)
    {
        public virtual float CostPerShift { get; }
        public string Job { get; private set; } = job;

        public void WorkTheNextShift()
        {
            if (HoneyVault.ConsumeHoney(CostPerShift))
                DoJob();
        }

        protected virtual void DoJob()
        {
            //하위 클래스에서 재정의
        }
    }
}
