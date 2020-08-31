using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoostDateExt
{
   public class BilgeDate
    {
        public static DateTime GetYesterday()
        {
            return DateTime.Now.AddDays(-1);
        }
    }
}
