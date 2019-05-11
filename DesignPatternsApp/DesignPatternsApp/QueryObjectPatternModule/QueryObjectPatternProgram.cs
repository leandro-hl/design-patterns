using DesignPatternsApp.QueryObjectPatternModule.ApproachOne;
using DesignPatternsApp.QueryObjectPatternModule.ApproachTwo;
using DesignPatternsApp.QueryObjectPatternModule.Bitcoin;
using System;
using System.Collections.Generic;

namespace DesignPatternsApp.QueryObjectPatternModule
{
    public static class QueryObjectPatternProgram
    {
        public static void Init()
        {
            var dateToFilterWith = new DateTime(2018, 02, 10);

            Console.WriteLine($"Filtering by: { dateToFilterWith.ToShortDateString() }");

            List<Exchange> doneAfter;
            List<Exchange> doneBefore;
            List<Exchange> doneEqual;

            var exchangeRepository = new ExchangeRepository();

            //First approach
            var dateExchangeCriteriaQO = new DateExchangeCriteriaQueryObject();

            doneAfter = exchangeRepository.Get(
                    dateExchangeCriteriaQO.ForExchangesDoneAfter(dateToFilterWith)
                );

            dateExchangeCriteriaQO.Reset();

            doneBefore = exchangeRepository.Get(
                    dateExchangeCriteriaQO.ForExchangesDoneBefore(dateToFilterWith)
                );

            dateExchangeCriteriaQO.Reset();

            doneEqual = exchangeRepository.Get(
                    dateExchangeCriteriaQO.ForExchangesDoneEqual(dateToFilterWith)
                );

            Console.WriteLine("\nDone After\n");
            doneAfter.ForEach(x => Console.WriteLine(x));            

            Console.WriteLine("\nDone Before\n");
            doneBefore.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("\nDone Equal\n");
            doneEqual.ForEach(x => Console.WriteLine(x));

            //Second Approach
            var dateExchangeQO = new DateExchangeQueryObject(exchangeRepository);

            doneAfter = dateExchangeQO
                .ForExchangesDoneAfter(dateToFilterWith)
                .ApplyFilters();

            dateExchangeQO.Reset();

            doneBefore = dateExchangeQO
                .ForExchangesDoneBefore(dateToFilterWith)
                .ApplyFilters();

            dateExchangeQO.Reset();

            doneEqual = dateExchangeQO
                .ForExchangesDoneEqual(dateToFilterWith)
                .ApplyFilters();

            Console.WriteLine("\nDone After\n");
            doneAfter.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("\nDone Before\n");
            doneBefore.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("\nDone Equal\n");
            doneEqual.ForEach(x => Console.WriteLine(x));

            Console.ReadKey();
        }
    }
}