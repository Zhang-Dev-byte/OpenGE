
using OpenGE;
using System.Collections.Generic;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Sandbox
{
    public class GameManager : Manager
    {
        //CONSTANTS
        public static string game = "OpenGE";
        public static uint width = 800;
        public static uint height = 800;
        public static ShowState state = ShowState.Debug;

        //OBJECTS
        private static Font _font = Graphics.LoadFont("default.ttf");
        
        //LISTS
        private List<Button> buttons = new List<Button>();
        private List<Drawable> objects = new List<Drawable>();
        private List<Frame> frames = new List<Frame>();
        private List<Animation> animations = new List<Animation>();
		private List<Text> text= new List<Text>();
		
		//AUDIO
        public void Render(RenderWindow window)
        {
            //HANDLE EVENTS
            window.KeyPressed += HandleInput;
            window.MouseButtonPressed += HandleMouseButtonInput;
            window.MouseMoved += HandleMouseInput;
            
            Renderer.Render(window,objects);
            UIRenderer.RenderButtons(window,buttons);
			AnimationRenderer.Render(animations,window);
			TextRenderer.Render(text,window);
        }

        public void Start()
        {
			//PLAY AUDIO
			
            //OBJECTS
            
            //BUTTONS
            
            //FRAMES
			
			//ANIMATIONS
			
			//TEXT
            
            //Run all the GEObject "Start" Methods
        }

        public void Update()
        {
            //Run all the GEObject "Update" Methods
        }
        void HandleInput(object sender, KeyEventArgs e)
        {
            
        }

        void HandleMouseButtonInput(object sender, MouseButtonEventArgs e)
        {
            
        }

        void HandleMouseInput(object sender,MouseMoveEventArgs e)
        {
			
        }
    }
}
