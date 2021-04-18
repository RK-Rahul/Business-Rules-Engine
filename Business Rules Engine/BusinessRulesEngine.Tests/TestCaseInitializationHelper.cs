namespace BusinessRulesEngine
{
    /// <summary>
    /// This class represent test case initializer use to prepare seed data.
    /// </summary>
    public static class TestCaseInitializationHelper
    {
        public static Order GetMemberShipOrder()
        {
            return new Order() { OrderType = OrderType.MemberShip, customerEmail = "rahul.esf@gmail.com" };
        }
    }
}
