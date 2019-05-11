using DesignPatternsApp.QueryObjectPatternModule.Bitcoin;
using System;

namespace DesignPatternsApp.QueryObjectPatternModule.ApproachOne
{
    public class DateExchangeCriteriaQueryObject : IDateExchangeCriteriaQueryObject
    {
        private DateTime? dateAfter;
        private DateTime? dateBefore;
        private DateTime? dateEqual;

        public Func<Exchange, bool> Criteria()
        {
            return ex => (this.dateAfter != null && ex.DoneOn.CompareTo(this.dateAfter) > 0) ||
                         (this.dateBefore != null && ex.DoneOn.CompareTo(this.dateBefore) < 0) ||
                         (this.dateEqual != null && ex.DoneOn.CompareTo(this.dateEqual) == 0);
        }

        public IDateExchangeCriteriaQueryObject ForExchangesDoneAfter(DateTime dateAfter)
        {
            this.dateAfter = dateAfter;

            return this;
        }

        public IDateExchangeCriteriaQueryObject ForExchangesDoneBefore(DateTime dateBefore)
        {
            this.dateBefore = dateBefore;

            return this;
        }

        public IDateExchangeCriteriaQueryObject ForExchangesDoneEqual(DateTime dateEqual)
        {
            this.dateEqual = dateEqual;

            return this;
        }

        public void Reset()
        {
            this.dateAfter = null;
            this.dateBefore = null;
            this.dateEqual = null;
        }
    }
}