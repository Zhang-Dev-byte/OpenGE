using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Microsoft.Win32.SafeHandles;
using SFML.Graphics;
using SFML.System;

namespace OpenGE
{
    namespace Renderer
    {
        public class Graphics
        {
            /// <summary>
            /// Fill a rectangle shape
            /// </summary>
            public static RectangleShape DrawRect(Vector2f size, Color outlineColor, int outlineThickness, Color color, Vector2f position)
            {
                RectangleShape rectangle = new RectangleShape();

                rectangle.Size = size;
                rectangle.OutlineColor = outlineColor;
                rectangle.FillColor = color;
                rectangle.OutlineThickness = outlineThickness;
                rectangle.Position = position;

                return rectangle;
            }
            /// <summary>
            /// Fill a circle shape
            /// </summary>
            public static CircleShape DrawCircle(int radius, Color outlineColor, Color color, int outlineThickness, Vector2f pos)
            {
                CircleShape circle = new CircleShape();
                circle.Radius = radius;
                circle.OutlineColor = outlineColor;
                circle.OutlineThickness = outlineThickness;
                circle.Position = pos;
                circle.FillColor = color;
                return circle;
            }
            /// <summary>
            /// Draw an image sprite
            /// </summary>
            public static Sprite Draw(string path, Vector2f pos)
            {
                try
                {
                    Texture texture = new Texture(path);
                    Sprite sprite = new Sprite(texture);
                    sprite.Texture = texture;
                    sprite.Position = pos;

                    return sprite;
                }
                catch
                {
                    throw new ImageLoadException("Failed to load Image");
                }
            }
            /// <summary>
            /// Draw an image sprite
            /// </summary>
            public static Sprite Draw(Texture texture, Vector2f pos)
            {
                try
                {
                    Sprite sprite = new Sprite(texture);
                    sprite.Texture = texture;
                    sprite.Position = pos;

                    return sprite;
                }
                catch
                {
                    throw new ImageLoadException("Failed to load Image");
                }
            }

            /// <summary>
            /// Loads a font
            /// </summary>
            public static Font LoadFont(string filename)
            {
                try
                {
                    Font font = new Font(filename);
                    return font;
                }
                catch
                {
                    return null;
                }
            }

            /// <summary>
            /// Makes A Button
            /// </summary>
            public static Button DrawButton(Font font, string str, RectangleShape background)
            {
                Text text = new Text(str, font);
                Button button = new Button(background, text);

                return button;
            }

            /// <summary>
            /// Makes Text Object
            /// </summary>
            public static Text DrawText(Font font, string str)
            {
                Text text = new Text(str, font);
                return text;
            }
        }
    }
}