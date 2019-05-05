namespace DesignPatternsApp.QueryObjectPatternModule.ApproachOne
{
    public interface IDateExchangeCriteriaQueryObject : 
        IDateExchangeQueryObjectFilter<IDateExchangeCriteriaQueryObject>, 
        IExchangeCriteria, 
        IQueryObjectReset
    {
    }
}