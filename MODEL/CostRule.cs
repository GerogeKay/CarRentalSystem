using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class CostRule
    {
        int id;
        int userLevel;
        decimal hourCost;
        decimal dayCost;
        decimal weekCost;
        decimal monthCost;
        decimal seasonCost;
        decimal yearCost;

        public decimal YearCost { get => yearCost; set => yearCost = value; }
        public decimal SeasonCost { get => seasonCost; set => seasonCost = value; }
        public decimal MonthCost { get => monthCost; set => monthCost = value; }
        public decimal WeekCost { get => weekCost; set => weekCost = value; }
        public decimal DayCost { get => dayCost; set => dayCost = value; }
        public decimal HourCost { get => hourCost; set => hourCost = value; }
        public int UserLevel { get => userLevel; set => userLevel = value; }
        public int Id { get => id; set => id = value; }
    }
}
