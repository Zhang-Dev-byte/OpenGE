using SFML.Window;

namespace OpenGE
{
    namespace Utilities
    {
        public class Input
        {
            public static float GetAxisX(KeyEventArgs e)
            {
                if (e.Code == Keyboard.Key.A || e.Code == Keyboard.Key.Left)
                {
                    return -1;
                }
                else if (e.Code == Keyboard.Key.D || e.Code == Keyboard.Key.Right)
                {
                    return 1;
                }
                else
                {

                    return 0;
                }
            }
            public static float GetAxisY(KeyEventArgs e)
            {
                if (e.Code == Keyboard.Key.S || e.Code == Keyboard.Key.Down)
                {
                    return 1;
                }
                else if (e.Code == Keyboard.Key.W || e.Code == Keyboard.Key.Up)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}