﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gAyPI.StardewValley.Accessor
{
    public interface GameLocationAccessor
    {
        IDictionary _GetObjects();

        bool _IsOutdoors();
    }
}
