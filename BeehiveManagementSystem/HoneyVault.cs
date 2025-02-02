using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    static class HoneyVault
    {
        public const float NECTAR_CONVERSION_RATIO = .19f;
        public const float LOW_LEVEL_WARNING = 10f;

        private static float honey = 25f;
        private static float nectar = 100f;
        public static string StatusReport
        {
            get
            {
                string status = $"{nectar:0.0} units of nectar\n{honey:0.0} units of honey";
                string warnings = "";
                if (honey < LOW_LEVEL_WARNING) warnings += "\n LOW HONEY - ADD A HONEY MANUFACTURER";
                if (nectar < LOW_LEVEL_WARNING) warnings += "\n LOW NECTAR - ADD A NECTAR COLLECTOR";
                return status + warnings;
            }
        }
        public static void ConverNecctarToHoney(float amount)
        {
            float nectartToConvert = amount;
            if (nectartToConvert > nectar) nectartToConvert = nectar;
            nectar -= nectartToConvert;
            honey += nectartToConvert * NECTAR_CONVERSION_RATIO;
        }

        public static bool ConsumeHoney(float amount)
        {
            if (amount <= honey)
            {
                honey -= amount;
                return true;
            }
            return false;
        }

        public static void CollectNectar(float amount)
        {
            if (amount > 0f) nectar += amount;
        }
    }
}
