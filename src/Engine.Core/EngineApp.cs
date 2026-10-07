using Engine.Graphics;

namespace Engine.Core;

public class EngineApp
{
    private readonly OpenTkWindow _window;

    public EngineApp(int width, int height, string title)
    {
        _window = new OpenTkWindow(width, height, title);

        _window.OnWindowLoad = () =>
        {
            Console.WriteLine("Loading now");
        };
    }

    public void Run()
    {
        _window.Run();
    }
}