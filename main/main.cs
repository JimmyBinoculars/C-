using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL4;

class Program
{
    static void Main(string[] args)
    {
        using (var window = new GameWindow())
        {
            window.Load += (sender, e) =>
            {
                // Initialize OpenGL settings
                GL.ClearColor(Color4.Black);
            };

            window.RenderFrame += (sender, e) =>
            {
                // Clear the screen
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

                // Add rendering code here

                // Swap the front and back buffers
                window.SwapBuffers();
            };

            window.Run();
        }
    }
}
