using Patterns.Proxy.BarClasses;
namespace Patterns.Proxy.Test{
public class Proxy
{
        public static void Run() {
            BarInterface proxyBar = new BarProxy();
            Console.WriteLine("\n ----------------Proxy-----------------"); 
            Console.WriteLine(proxyBar.askForMenu());
            proxyBar.createOrder("Bere",2);
            proxyBar.payUp();
        }
}
}