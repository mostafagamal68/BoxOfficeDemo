using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfficeDemo.Shared.Extensions
{
    public static class StringHelpers
    {
        public static decimal ToIdDecimal(this string Id) => Convert.ToDecimal(Id.Replace('O', '.'));
    }
}
