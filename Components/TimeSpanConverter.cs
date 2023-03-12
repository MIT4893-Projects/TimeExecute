using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeExecute.Components
{
    static class TimeSpanConverter
    {
        public static string ToMinuteSecond(TimeSpan time)
        {
            return time.ToString(@"m\:ss\.fff");
        }

        public static string ToSecond(TimeSpan time)
        {
            return time.ToString(@"s\.fff");
        }
    }
}
