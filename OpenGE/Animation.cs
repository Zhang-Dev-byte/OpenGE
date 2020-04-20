using SFML.Graphics;
using SFML.System;

namespace OpenGE
{
    public class Animation
    {
        public int frameWidth;
        public int frameHeight;
        public float Delay;
        public int frames;
        private static Texture sheet;
        private static IntRect rectSource = new IntRect(0, 0, 16, 16);
        public Sprite sprite;
        private Clock clock;
        public Animation(Texture _sheet,int _frameWidth,int _frameHeight,float _Delay,int _frames)
        {
            frameWidth = _frameWidth;
            frameHeight = _frameHeight;
            sheet = _sheet;
            Delay = _Delay;
            frames = _frames;
            sprite = new Sprite(sheet, rectSource);
            clock = new Clock();
            rectSource = new IntRect(0, 0, frameWidth, frameHeight);
            
        }

        public void Update()
        {
            if (clock.ElapsedTime.AsSeconds() > Delay)
            {
                if (rectSource.Left == frameWidth * frames)
                {
                    rectSource.Left = 0;
                    clock.Restart();
                }
                else
                {
                    rectSource.Left += frameWidth;
                    clock.Restart();
                }

                sprite.TextureRect = rectSource;
            }
        }
    }
}