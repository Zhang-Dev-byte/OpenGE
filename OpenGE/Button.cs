using System;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace OpenGE
{
    public class Button : UIRenderable
    {
        public RectangleShape background;
        public Text text;

        public Button(RectangleShape _background,Text _text)
        {
            background = _background;
            text = _text;
            text.Position = background.Position;
        }

        public static bool GetClick(MouseButtonEventArgs e,Vector2f mousePos,Button button)
        {
            Vector2f scale = button.background.Size;
            Vector2f pos = button.background.Position;
            /*Console.WriteLine("Scale: "+scale.X+", "+scale.Y);
            Console.WriteLine("Position: "+pos.X+", "+pos.Y);
            Console.WriteLine("mousePos: "+mousePos.X+", "+mousePos.Y);*/
            if (e.Button == Mouse.Button.Left && mousePos.X <= scale.X + pos.X && mousePos.X >= pos.X && mousePos.Y <= scale.Y + pos.Y && mousePos.Y >= pos.Y)
            {
                
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}