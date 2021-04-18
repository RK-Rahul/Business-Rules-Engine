namespace BusinessRulesEngine
{
    /// <summary>
    /// Represent the class for membership order.
    /// </summary>
    public class MemberShipOrder : IOrder
    {
        private readonly INotificationHandler notificationHandler;
        public MemberShipOrder(INotificationHandler notificationHandler)
        {
            this.notificationHandler = notificationHandler;
        }
        public bool ExecuteOrder(Order order)
        {
            return true;
        }

        private bool ActivateMember(Order order)
        {
            //activate member
            return true;
        }

        private bool UpgradeMember(Order order)
        {
            //upgrade member
            return true;
        }
    }
}

