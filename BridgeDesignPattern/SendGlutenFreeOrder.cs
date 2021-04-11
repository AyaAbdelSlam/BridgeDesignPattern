namespace BridgeDesignPattern
{
    internal class SendGlutenFreeOrder : SendOrder
    {
        public override void Send()
        {
            _restaurant.Place("Gluten-Free Order");
        }
    }
}