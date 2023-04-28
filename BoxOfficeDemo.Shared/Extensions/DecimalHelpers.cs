using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfficeDemo.Shared.Extensions
{
    public static class DecimalHelpers
    {
        public static string ToIdString(this decimal? Id) => Id?.ToString().Replace('.', 'O') ?? "";
        public static string ToHtmlId(this decimal? Id) => Id?.ToString().Replace('.', '_') ?? "";
    }
}
