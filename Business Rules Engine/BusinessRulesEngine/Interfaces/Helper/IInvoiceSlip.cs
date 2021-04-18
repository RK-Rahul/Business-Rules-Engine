namespace BusinessRulesEngine
{
    /// <summary>
    /// Represent the interface for invoice handler.
    /// </summary>
    public interface IInvoiceSlip
    {
        /// <summary>
        /// This method is responsible for generating the invoice slip.
        /// </summary>
        /// <param name="order"></param>
        Invoice GenerateSlip(Order order);

        /// <summary>
        /// This method is responsible for generating the duplicate invoice slip.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        Invoice GenerateDuplicateSlip(Order order);

        Invoice GenerateAIDSlip(Order order);
    }
}
