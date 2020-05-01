using System;
using System.Runtime.InteropServices;
using OpenGE.Utilities;
namespace Sandbox
{
    class GameCore
    {
        [DllImport("user32.dll")]
        private static extern int ShowWindow(int Handle, int showState);

        [DllImport("kernel32.dll")]
        public static extern int GetConsoleWindow();

        /// <summary>
        /// The main entry point of the application
        /// </summary>
        static void Main(string[] args)
        {
            int window = GetConsoleWindow();
            ShowWindow(window, (int)GameManager.state);

            OpenGE.Renderer.Window.Create(GameManager.width,GameManager.height,GameManager.game,new GameManager());
        }
    }
}