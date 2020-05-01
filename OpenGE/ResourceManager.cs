using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenGE
{
    namespace Utilities { 
        public class ResourceManager
        {
            public static List<Texture> textures = new List<Texture>();
            public static List<string> keys = new List<string>();

            public static void Save(Texture data,string key)
            {
                try
                {
                    textures.Add(data);
                    keys.Add(key);
                }
                catch
                {
                    throw new ResourceManagerException("Could not save data.");
                }
            }
            public static Texture Load(string key)
            {
                try
                {
                    int index = 0;
                    foreach(string k in keys)
                    {
                        index++;
                        if(key == k)
                        {
                            break;
                        }
                    }
                    return textures[0];
                }
                catch
                {
                    throw new ResourceManagerException("Could not load data.");
                }
            }
        }
    }
}
