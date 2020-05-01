
## General info
OpenGE is an open-source game engine built on C#. 

## Dependencies
OpenGE is built on the following libraries:
* SFML.net
* OpenAL

There is no need to build any libraries because the packages are managed with the Nuget Package Manager.

## Setup
First, right click on the "Sandbox" project and click "Set as Startup Project".
Then, Debug the project. You should get a black window.
Now, click on GameManager.cs. It should look like this.

```c#

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
```

The gamemanager is the game core it controls everything in the game.

## Assets
Assets are important in any game in order for your asssets to work you have to save them in your output directory.
For example, an output directory could be this:
```C:\OpenGE-master\Sandbox\bin\ ```

## Examples

The is an example for a gift catching game if you save the correct assets this code will work.

```c#

using System.Collections.Generic;
using OpenGE;
using OpenGE.Math;
using OpenGE.Utilities;
using OpenGE.Renderer;
using OpenGE.Collision;
using OpenGE.Physics;
using OpenGE.Audio;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Sandbox
{
    public class GameManager : Manager
    {
        //CONSTANTS
        public static string game = "OpenGE Demo";
        public static uint width = 800;
        public static uint height = 800;
        public static ShowState state = ShowState.Debug;

        //OBJECTS
        private static Font _font = Graphics.LoadFont("default.ttf");
        private static Text title = Graphics.DrawText(_font, "An OpenGE Demo");
        private static Button start = Graphics.DrawButton(_font,"Start",Graphics.DrawRect(new Vector2f(100,50),Color.Black,5,Color.Black,new Vector2f(300,250)));
        private static Vector2f mousePos;
        private static Animation main = new Animation(new Texture("sheet.png"), 16, 16, 0.05f, 8);
        private static Sprite ground = Graphics.Draw("ground.png", new Vector2f(0,700));
        private static Sprite gift = Graphics.Draw("gift.png", new Vector2f(Random.Next(0,735), 0));
        private static double score;
        private static bool canCollilde = true;

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
            Physics.ImplementPhysicsSprite(main.sprite);
            Physics.ImplementPhysicsSprite(gift);

            Collision.AddCollisionTriggerSprite(main.sprite, ground);

            if (Collision.CollisionTriggerSprite(gift, ground))
            {
                gift.Position = new Vector2f(Random.Next(0, 735), 0);
            }
            if (Collision.CollisionTriggerSprite(gift, main.sprite) && canCollilde)
            {
                canCollilde = false;
                score += 1;
                title.DisplayedString = score.ToString();
            }
            else
            {
                canCollilde = true;
            }


            Renderer.Render(window,objects);
            UIRenderer.RenderButtons(window,buttons);
			AnimationRenderer.Render(animations,window);
			TextRenderer.Render(text,window);
        }

        public void Start()
        {
            //PLAY AUDIO

            //OBJECTS
            objects.Add(ground);
            objects.Add(gift);
            //BUTTONS
            start.text.Position = new Vector2f(305, 255);
            buttons.Add(start);
            //FRAMES

            //ANIMATION
            main.sprite.Position = new Vector2f(0, 600);
            main.sprite.Scale = new Vector2f(4, 4);
            animations.Add(main);

            //TEXT
            title.Position = new Vector2f(200,0);
            title.Scale = new Vector2f(1.5f,1.5f);
            text.Add(title);
            //Run all the GEObject "Start" Methods
        }

        public void Update()
        {
            main.Update();
            
            //Run all the GEObject "Update" Methods
        }
        void HandleInput(object sender, KeyEventArgs e)
        {
            Vector2f pos = main.sprite.Position;

            if (e.Code == Keyboard.Key.A || e.Code == Keyboard.Key.Left)
            { 
                pos.X -= 0.0009f;

            }
            if (e.Code == Keyboard.Key.D || e.Code == Keyboard.Key.Right)
            {
                pos.X += 0.0009f;

            }
            main.sprite.Position = pos;
        }

        void HandleMouseButtonInput(object sender, MouseButtonEventArgs e)
        {
            if (Button.GetClick(e, mousePos, start))
            {
                title.DisplayedString = "0";
                buttons.Remove(start);
            }
        }

        void HandleMouseInput(object sender,MouseMoveEventArgs e)
        {
            mousePos = new Vector2f(e.X, e.Y);
        }
    }
}
```
