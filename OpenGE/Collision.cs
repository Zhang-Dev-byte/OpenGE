using SFML.Graphics;
using SFML.System;

namespace OpenGE
{
    public class Collision
    {
        /// <summary>
        /// Adds a collision trigger to a sprite.
        /// </summary>
        public static void AddCollisionTriggerSprite(Sprite rect,Sprite rect2)
        {
            if (rect.GetGlobalBounds().Intersects(rect2.GetGlobalBounds()))
            {
                Vector2f position = rect.Position;
                Vector2f obj = rect2.Position;
                if (position.Y > obj.Y)
                {
                    position.Y += 1;
                    rect.Position = position;
                }else if (position.Y < obj.Y)
                {
                    position.Y -= 1;
                    rect.Position = position;
                }else if (position.X > obj.X)
                {
                    position.X += 1;
                    rect.Position = position;
                }else if (position.X < obj.X)
                {
                    position.X -= 1;
                    rect.Position = position;
                }
            }
        }
        /// <summary>
        /// Adds a collision trigger to a rectangle.
        /// </summary>
        public static void AddCollisionTriggerRect(RectangleShape rect,RectangleShape rect2)
        {
            if (rect.GetGlobalBounds().Intersects(rect2.GetGlobalBounds()))
            {
                Vector2f position = rect.Position;
                Vector2f obj = rect2.Position;
                if (position.Y > obj.Y)
                {
                    position.Y += 1;
                    rect.Position = position;
                }else if (position.Y < obj.Y)
                {
                    position.Y -= 1;
                    rect.Position = position;
                }else if (position.X > obj.X)
                {
                    position.X += 1;
                    rect.Position = position;
                }else if (position.X < obj.X)
                {
                    position.X -= 1;
                    rect.Position = position;
                }
            }
        }
        /// <summary>
        /// Adds a collision trigger to a circle.
        /// </summary>
        public static void AddCollisionTriggerCircle(CircleShape rect,CircleShape rect2)
        {
            if (rect.GetGlobalBounds().Intersects(rect2.GetGlobalBounds()))
            {
                Vector2f position = rect.Position;
                Vector2f obj = rect2.Position;
                if (position.Y > obj.Y)
                {
                    position.Y += 1;
                    rect.Position = position;
                }else if (position.Y < obj.Y)
                {
                    position.Y -= 1;
                    rect.Position = position;
                }else if (position.X > obj.X)
                {
                    position.X += 1;
                    rect.Position = position;
                }else if (position.X < obj.X)
                {
                    position.X -= 1;
                    rect.Position = position;
                }
            }
        }
        /// <summary>
        /// Gets a collision trigger to a sprite.
        /// </summary>
        public static bool CollisionTriggerSprite(Sprite rect,Sprite rect2)
        {
            if (rect.GetGlobalBounds().Intersects(rect2.GetGlobalBounds()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Gets a collision trigger to a rectangle.
        /// </summary>
        public static bool CollisionTriggerRect(RectangleShape rect,RectangleShape rect2)
        {
            if (rect.GetGlobalBounds().Intersects(rect2.GetGlobalBounds()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Gets a collision trigger to a circle.
        /// </summary>
        public static bool CollisionTriggerCircle(CircleShape rect,CircleShape rect2)
        {
            if (rect.GetGlobalBounds().Intersects(rect2.GetGlobalBounds()))
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