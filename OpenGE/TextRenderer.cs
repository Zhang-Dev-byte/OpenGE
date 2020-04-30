using System;
using System.Collections.Generic;
using SFML.Graphics;

namespace OpenGE
{
    namespace Renderer
    {
        public class TextRenderer
        {
            public static void Render(List<Text> text, RenderWindow window)
            {
                foreach (Text t in text)
                {
                    window.Draw(t);
                }
            }
        }
    }
}