namespace Patterns.Facade
{
    public class Facade
    {
        public static void Run()
        {
            Adoption adoption = new Adoption();

            Person person = new Person("Amalia Capatina");
            bool eligible = adoption.IsEligible(person, "Aron");

            Console.WriteLine("\n" + person.Name + " has been " + (eligible ? "Approved" : "Rejected"));

            Console.ReadKey();
        }
    }
}
