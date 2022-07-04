using ConcreteObservers;
using Subjects;
<<<<<<< HEAD
namespace Patterns.TestObserver
{
    public class ObserverTest
    {
        public static void Run()
        {

=======
namespace Test
{
    public class ObserverTest
    {
        public void Run()
        {
>>>>>>> ea67ec5 (Added the observer design pattern)
            Subject Fridge = new Subject("SamsungFridge", 10000, "Out Of Stock");
            Observer user1 = new Observer("Mircea", Fridge);
            Observer user2 = new Observer("Mirela", Fridge);
            Observer user3 = new Observer("Montague", Fridge);
            
            Console.WriteLine("Red MI Mobile current state : " + Fridge.getAvailability());
            Console.WriteLine();

            Fridge.setAvailability("Available");
        }
    }
}