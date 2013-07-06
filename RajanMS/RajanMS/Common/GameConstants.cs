using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajanMS.Common
{
    class GameConstants
    {
        public static bool isEvan(short job)
        {
            return job == 2001 || (job / 100 == 22);
        }

        public static bool isMercedes(short job)
        {
            return job == 2002 || (job / 100 == 23);
        }

        public static bool isDemon(short job)
        {
            return job == 3001 || (job >= 3100 && job <= 3112);
        }

        public static bool isAran(short job)
        {
            return job >= 2000 && job <= 2112 && job != 2001 && job != 2002 && job != 2003;
        }

        public static bool isResist(short job)
        {
            return job / 1000 == 3;
        }

        public static bool isWildHunter(short job)
        {
            return job == 3300 || (job >= 3310 && job <= 3312);
        }

        public static bool isDualBlade(short job)
        {
            return job >= 430 && job <= 434;
        }

        public static bool isCannon(short job)
        {
            return job >= 530 && job <= 532;
        }

        public static bool isSeparatedSp(short job)
        {
            return isEvan(job) || isResist(job) || isMercedes(job);
        }

        public static bool isExtendSpJob(int jobId)
        {
            return jobId / 1000 == 3 || jobId / 100 == 22 || jobId == 2001 || jobId / 100 == 23 || jobId == 2002;
        }
    }
}
