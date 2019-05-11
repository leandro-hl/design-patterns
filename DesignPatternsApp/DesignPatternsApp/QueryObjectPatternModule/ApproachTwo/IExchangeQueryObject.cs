using DesignPatternsApp.QueryObjectPatternModule.Bitcoin;
using System.Collections.Generic;

namespace DesignPatternsApp.QueryObjectPatternModule.ApproachTwo
{
    public interface IExchangeQueryObject
    {
        List<Exchange> ApplyFilters();
    }
}