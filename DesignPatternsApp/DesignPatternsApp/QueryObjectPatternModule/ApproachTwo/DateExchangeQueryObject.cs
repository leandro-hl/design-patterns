using DesignPatternsApp.QueryObjectPatternModule.Bitcoin;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatternsApp.QueryObjectPatternModule.ApproachTwo
{
public class DateExchangeQueryObject : IDateExchangeQueryObject
{
    private readonly ExchangeRepository exchangeRepository;

    private bool compareDateAfter;
    private bool compareDateBefore;
    private bool compareDateEqual;

    private DateTime? dateAfter;
    private DateTime? dateBefore;
    private DateTime? dateEqual;
        
    public DateExchangeQueryObject(ExchangeRepository exchangeRepository)
    {
        this.exchangeRepository = exchangeRepository;
    }

    public List<Exchange> ApplyFilters()
    {
        var query = this.exchangeRepository.Get();

        if (this.compareDateAfter)
        {
            query = query.Where(exchange => exchange.DoneOn.CompareTo(this.dateAfter) > 0);
        }

        if (this.compareDateBefore)
        {
            query = query.Where(ex => ex.DoneOn.CompareTo(this.dateBefore) < 0);
        }

        if (this.compareDateEqual)
        {
            query = query.Where(ex => ex.DoneOn.CompareTo(this.dateEqual) == 0);
        }

        return query.ToList();
    }

        public IDateExchangeQueryObject ForExchangesDoneAfter(DateTime dateAfter)
        {
            this.dateAfter = dateAfter;

            this.compareDateAfter = true;

            return this;
        }

        public IDateExchangeQueryObject ForExchangesDoneBefore(DateTime dateBefore)
        {
            this.dateBefore = dateBefore;

            this.compareDateBefore = true;

            return this;
        }

        public IDateExchangeQueryObject ForExchangesDoneEqual(DateTime dateEqual)
        {
            this.dateEqual = dateEqual;

            this.compareDateEqual = true;

            return this;
        }

        public void Reset()
        {
            this.compareDateAfter = false;
            this.compareDateBefore = false;
            this.compareDateEqual = false;
        }
    }
}