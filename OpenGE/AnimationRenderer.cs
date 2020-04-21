using System.Collections.Generic;
using SFML.Graphics;

namespace OpenGE
{
    public class AnimationRenderer
    {
        public static void Render(List<Animation> animations, RenderWindow window)
        {
            foreach (Animation anim in animations)
            {
                window.Draw(anim.sprite);
            }
        }
    }
}