using System;
using SFML.Graphics;
using SFML.Window;

namespace OpenGE
{
    namespace Renderer
    {
        public class Window
        {
            /// <summary>
            /// Creates A Window
            /// </summary>
            public static void Create(uint width = 800, uint height = 800, string title = "OpenGE", Manager manager = null)
            {
                RenderWindow window = new RenderWindow(new VideoMode(width, height), title);
                manager.Start();
                while (window.IsOpen)
                {
                    manager.Update();
                    window.Closed += new EventHandler(OnClose);
                    window.DispatchEvents();

                    window.Clear(new Color(0, 200, 200));
                    manager.Render(window);
                    window.Display();
                }
            }
            private static void OnClose(object sender, EventArgs e)
            {
                // Close the window when OnClose event is received
                RenderWindow window = (RenderWindow)sender;
                window.Close();
            }
        }
    }
}