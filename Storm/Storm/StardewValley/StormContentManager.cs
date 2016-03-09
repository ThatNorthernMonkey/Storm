﻿using Microsoft.Xna.Framework.Content;
using Storm.Manipulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storm.StardewValley
{
    public static class StormContentManager
    {
        public static T Load<T>(ContentManager manager, string assetName)
        {
            DetourEvent @event = StaticGameContext.ContentLoadCallback(manager,typeof(T), assetName);
            if(@event.ReturnValue != null)
            {
                return (T) @event.ReturnValue;
            }
            return manager.Load<T>(assetName);
        }

        public static void Unload(ContentManager manager)
        {
            StaticGameContext.ManagerUnloadCallback(manager);
            manager.Unload();
        }
    }
}
