using SFML.Audio;

namespace OpenGE
{
    public class Audio
    {
        /// <summary>
        /// Makes A Sound Object
        /// </summary>
        public static Sound LoadSound(string path)
        {
            try
            {
                SoundBuffer buffer = new SoundBuffer(path);
                Sound sound = new Sound(buffer);

                return sound;
            }
            catch
            {
                return null;
            }
        }
    }
}