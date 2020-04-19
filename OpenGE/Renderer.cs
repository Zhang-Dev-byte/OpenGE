using System.Collections.Generic;
using SFML.Graphics;

namespace OpenGE
{
    public class Renderer
    {
        public static void Render(RenderWindow window, List<Drawable> objects)
        {
            foreach (Drawable obj in objects)
            {
                window.Draw(obj);
            }
        }
    }
}