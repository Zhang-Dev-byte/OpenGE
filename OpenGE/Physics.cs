using SFML.Graphics;
using SFML.System;

namespace OpenGE
{
    namespace Physics
    {
        public class Physics
        {
            /// <summary>
            /// Implements physics to a sprite.
            /// </summary>
            public static void ImplementPhysicsSprite(Sprite rect)
            {
                Vector2f position = rect.Position;
                position.Y += 0.5f;
                rect.Position = position;
            }
            /// <summary>
            /// Implements physics to a rectangle.
            /// </summary>
            public static void ImplementPhysicsRect(RectangleShape rect)
            {
                Vector2f position = rect.Position;
                position.Y += 0.1f;
                rect.Position = position;
            }
            /// <summary>
            /// Implements physics to a circle.
            /// </summary>
            public static void ImplementPhysicsCircle(CircleShape rect)
            {
                Vector2f position = rect.Position;
                position.Y += 0.1f;
                rect.Position = position;
            }
        }
    }
}