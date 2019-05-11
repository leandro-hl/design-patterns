using System;

namespace DesignPatternsApp.QueryObjectPatternModule.Bitcoin
{
    public class Exchange
    {
        public int Id { get; set; }
        public double BtcPrice { get; set; }
        public double BtcAmount { get; set; }
        public DateTime DoneOn { get; set; }

        public override string ToString()
        {
            return $"" +
                $"Id: { this.Id } - " +
                $"Price: { this.BtcPrice } - " +
                $"Amount: { this.BtcAmount } - " +
                $"Date: { this.DoneOn.ToShortDateString() }";
        }
    }
}