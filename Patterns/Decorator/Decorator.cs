using Decorator;

namespace Patterns;
public class Decorator
{
    public static void Run()
    {
        IChristmasTree brad = new ChristmasTree();
        IChristmasTree luminite = new LightsDecorator(brad);
        IChristmasTree steluta = new StarDecorator(luminite);
        IChristmasTree globuri = new GlobeDecorator(steluta);
        Console.WriteLine(globuri.GetChristmasTreeOrnament());
    }
}