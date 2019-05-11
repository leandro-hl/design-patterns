using System;

namespace DesignPatternsApp.QueryObjectPatternModule
{
    public interface IDateExchangeQueryObjectFilter<T>
    {
        T ForExchangesDoneAfter(DateTime dateAfter);

        T ForExchangesDoneBefore(DateTime dateBefore);

        T ForExchangesDoneEqual(DateTime dateEqual);
    }
}