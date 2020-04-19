using System;
using System.Collections.Generic;
using OpenGE;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Sandbox
{
    public class GameManager : Manager
    {
        //CONSTANTS
        public const string game = "Hello";
        public const int width = 800;
        public const int height = 800;

        //OBJECTS
        private Sprite rect = Graphics.Draw("player.png", new Vector2f(0, 0));
        private Sprite rect2 = Graphics.Draw("player.png", new Vector2f(20, 300));
        private Sprite background = Graphics.Draw("background.png", new Vector2f(0, 0));
        private Vector2f pos;
        private Vector2f mousePos;
        private static Font _font = Graphics.LoadFont("default.ttf");

        private Button button = Graphics.DrawButton(_font, "Hello", Graphics.DrawRect(new Vector2f(100, 50), Color.Black, 5, Color.Black, new Vector2f(20, 0)));
        
        //LISTS
        private List<Button> buttons = new List<Button>();
        private List<Drawable> objects = new List<Drawable>();
        private List<Frame> frames = new List<Frame>();

        public void Render(RenderWindow window)
        {
            //HANDLE EVENTS
            window.KeyPressed += HandleInput;
            window.MouseButtonPressed += HandleMouseButtonInput;
            window.MouseMoved += HandleMouseInput;
            
            Collision.AddCollisionTriggerSprite(rect,rect2);
            Physics.ImplementPhysicsSprite(rect);
            
            Renderer.Render(window,objects);
            UIRenderer.RenderButtons(window,buttons);
        }

        public void Start()
        {
            //OBJECTS
            objects.Add(background);
            objects.Add(rect);
            objects.Add(rect2);
            
            //BUTTONS
            buttons.Add(button);
            
            //FRAMES
            
            //Run all the GEObject "Start" Methods
        }

        public void Update()
        {
            //Run all the GEObject "Update" Methods
        }
        void HandleInput(object sender, KeyEventArgs e)
        {
            
            pos = rect.Position;
            pos.X += Input.GetAxisX(e) * 0.0005f;
            pos.Y += Input.GetAxisY(e) * 0.0005f;
            rect.Position = pos;
        }

        void HandleMouseButtonInput(object sender, MouseButtonEventArgs e)
        {
            if (Button.GetClick(e,mousePos,button))
            {
                Console.WriteLine("Clicked");
            }
            
        }

        void HandleMouseInput(object sender,MouseMoveEventArgs e)
        {
            mousePos = new Vector2f(e.X,e.Y);
        }
    }
}