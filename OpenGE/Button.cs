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
            Vector2f textPos = text.Position;
            Vector2f textSize = new Vector2f(text.GetGlobalBounds().Width,text.GetGlobalBounds().Height);
            Vector2f backSize = background.Size;
            text.Position = background.Position;
            textPos.X += (backSize.X / 2) - ((textSize.X/2) - (textSize.X/4));
            textPos.Y += (backSize.Y / 2)-(textSize.Y);
            text.Position = textPos;
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