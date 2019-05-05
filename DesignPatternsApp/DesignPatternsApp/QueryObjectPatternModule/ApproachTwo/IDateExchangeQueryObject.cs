namespace DesignPatternsApp.QueryObjectPatternModule.ApproachTwo
{
    public interface IDateExchangeQueryObject : 
        IDateExchangeQueryObjectFilter<IDateExchangeQueryObject>, 
        IExchangeQueryObject, 
        IQueryObjectReset
    {
    }
}