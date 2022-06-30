using Patterns.Proxy.Order;
namespace Patterns.Proxy.BarClasses{
    public interface BarInterface{
    public string askForMenu();
    public Order.Order createOrder(string name,int amount);
    public void payUp(){}
}
}
