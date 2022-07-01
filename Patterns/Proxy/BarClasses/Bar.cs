using Patterns.Proxy.Order;

namespace Patterns.Proxy.BarClasses{
public class Bar : BarInterface
{
    string menu = "Beer";
    int price;

    Order.Order currentOrder;
    public void restockDrinks(){}
    public Order.Order bringOrder(){return currentOrder;}
    public string getMenu(){return menu;}

    public string askForMenu(){ return menu;}
    public void payUp(){Console.WriteLine("Woosh, all money gone");}
    public Order.Order createOrder(string name, int amount)
    {
        currentOrder.drinkName = name;
        currentOrder.numberOfDrinks = amount;
        currentOrder.createPrice();
        return currentOrder;
    }
}
}