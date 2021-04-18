namespace BusinessRulesEngine
{
    /// <summary>
    /// This represents invalid order extension
    /// </summary>
    public class InvalidOrderException : System.Exception
    {
        public override string Message
        {
            get
            {
                return "Order is invalid.";
            }
        }
    }
}
