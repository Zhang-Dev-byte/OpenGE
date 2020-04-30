using SFML.Graphics;

namespace OpenGE
{
    namespace Renderer
    {
        public interface Manager
        {
            /// <summary>
            /// Renders the scene
            /// </summary>
            void Render(RenderWindow window);
            /// <summary>
            /// The Entry point of the GameManager
            /// </summary>
            void Start();
            /// <summary>
            /// Updates the GameManager
            /// </summary>
            void Update();
        }
    }
}