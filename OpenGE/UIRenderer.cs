using System.Collections.Generic;
using SFML.Graphics;

namespace OpenGE
{
    public class UIRenderer
    {
        public static void RenderButtons(RenderWindow window, List<Button> buttons)
        {
            foreach (Button button in buttons)
            {
                window.Draw(button.background);
                window.Draw(button.text);
            }
        }

        public static void RenderFrames(RenderWindow window, List<Frame> frames)
        {
            foreach (Frame frame in frames)
            {
                window.Draw(frame.background);
            }
        }
    }
}