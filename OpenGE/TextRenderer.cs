using System;
using System.Collections.Generic;
using SFML.Graphics;

namespace OpenGE
{
    public class TextRenderer
    {
        public static void Render(List<Text> text,RenderWindow window)
        {
            foreach (Text t in text)
            {
                window.Draw(t);
            }
        }
    }
}