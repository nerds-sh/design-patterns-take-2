using ChainResp;
namespace Patterns;

public class ChainResp
{
<<<<<<< HEAD
<<<<<<< HEAD
    public static void Run()
=======
    static void Run()
>>>>>>> 691202e (first commit for Chain Responsibility)
=======
    public static void Run()
>>>>>>> 556b3fd (add Run function)
    {
        Approver Amalia = new HeadChef();
        Approver Andrei = new PurchasingManager();
        Approver Ioana = new GeneralManager();

        Amalia.SetSupervisor(Andrei);
        Andrei.SetSupervisor(Ioana);

        PurchaseOrder p = new PurchaseOrder(1, 20, 69, "Spices");
        Amalia.ProcessRequest(p);

        p = new PurchaseOrder(2, 300, 1389, "Milk");
        Amalia.ProcessRequest(p);

        p = new PurchaseOrder(3, 500, 4823.99, "Eggs");
        Amalia.ProcessRequest(p);

        p = new PurchaseOrder(4, 4, 12099, "Ovens");
        Amalia.ProcessRequest(p);

        Console.ReadKey();
    }

}