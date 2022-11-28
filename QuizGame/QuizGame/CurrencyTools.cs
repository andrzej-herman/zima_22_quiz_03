using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame
{
    public static class CurrencyTools
    {
        public static string ConvertToCurrency(decimal p)
        {
            return $"{p} zł";
        }
    }
}
