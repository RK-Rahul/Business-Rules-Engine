namespace BusinessRulesEngine
{
    /// <summary>
    /// Represent the interface for agent commission.
    /// </summary>
    public interface IAgentCommission
    {
        bool GenerateCommision(Order order);
    }
}
