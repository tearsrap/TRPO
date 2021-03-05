using System;
using System.Collections.Generic;
using System.Text;

namespace TRPO_Lab4.WPF
{
    public static class Formula
    {
        public static double Radius { get; set; }
        public static double radius { get; set; }
        public static double height { get; set; }
        //Переменные для записи результата рассчетов
        public static double Result { get; set; }

        public static double Decision(double Radius, double radius, double height)
        {
            return Math.PI * Radius * (2 * height + radius);
        }
        public static void Solve()
        {
           Result  = Math.Round(Decision(Radius, radius, height),2);
        }
    }
}
