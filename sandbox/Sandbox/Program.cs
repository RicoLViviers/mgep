using Engine.Core;

namespace Sandbox;

class Program
{
    static void Main(string[] args)
    {
        EngineApp app = new EngineApp(700, 500, "Sandbox");

        app.Run();
    }     
}