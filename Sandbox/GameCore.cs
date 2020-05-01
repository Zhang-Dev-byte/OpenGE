using System;

namespace Sandbox
{
    class GameCore
    {
        /// <summary>
        /// The main entry point of the application
        /// </summary>
        static void Main(string[] args)
        {
            OpenGE.Renderer.Window.Create(GameManager.width,GameManager.height,GameManager.game,new GameManager());
        }
    }
}
