using System.Drawing;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

namespace Engine.Graphics;

public class OpenTkWindow : GameWindow
{
    public Action? OnWindowLoad;
    public Action? OnWindowUpdate;
    public Action? OnWindowRender;
    

    public OpenTkWindow(int width, int height, string title) 
        : base(GameWindowSettings.Default, new NativeWindowSettings 
          { 
              ClientSize = new Vector2i(width, height), 
              Title = title
          })
    {
        
    }

    protected override void OnLoad()
    {
        base.OnLoad();

        GL.ClearColor(0.5f, 0.5f, 0.0f, 1.0f);
        GL.Enable(EnableCap.DepthTest);

        OnWindowLoad?.Invoke();
    }

    protected override void OnRenderFrame(FrameEventArgs args)
    {
        base.OnRenderFrame(args);

        GL.Clear(ClearBufferMask.ColorBufferBit);

        OnWindowUpdate?.Invoke();

        SwapBuffers();
    }
}