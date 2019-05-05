using DesignPatternsApp.QueryObjectPatternModule.ApproachOne;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatternsApp.QueryObjectPatternModule.Bitcoin
{
    public class ExchangeRepository
    {
        private readonly ICollection<Exchange> exchangesHistory;

        public ExchangeRepository()
        {
            this.exchangesHistory = new List<Exchange>() {
                new Exchange
                {
                    Id = 1,
                    BtcAmount = 0.002,
                    BtcPrice = 3175.00,
                    DoneOn = new DateTime(2018,11,25)
                },
                new Exchange
                {
                    Id = 2,
                    BtcAmount = 0.250,
                    BtcPrice = 2500.00,
                    DoneOn = new DateTime(2018,12,23)
                },
                new Exchange
                {
                    Id = 3,
                    BtcAmount = 1.000,
                    BtcPrice = 1520.00,
                    DoneOn = new DateTime(2017,08,01)
                },
                new Exchange
                {
                    Id = 4,
                    BtcAmount = 0.502,
                    BtcPrice = 2324.08,
                    DoneOn = new DateTime(2018,02,10)
                }
            };
        }

        public IEnumerable<Exchange> Get()
        {
            return this.exchangesHistory;
        }

        public List<Exchange> Get(IExchangeCriteria exchangeCriteria)
        {
            return this.exchangesHistory.Where(exchangeCriteria.Criteria()).ToList();
        }
    }
}