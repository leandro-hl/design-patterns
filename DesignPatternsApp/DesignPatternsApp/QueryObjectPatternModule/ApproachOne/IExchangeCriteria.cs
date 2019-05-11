using DesignPatternsApp.QueryObjectPatternModule.Bitcoin;
using System;

namespace DesignPatternsApp.QueryObjectPatternModule.ApproachOne
{
    public interface IExchangeCriteria
    {
        Func<Exchange, bool> Criteria();
    }
}