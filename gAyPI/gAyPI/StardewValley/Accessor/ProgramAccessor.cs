﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gAyPI.StardewValley.Accessor
{
    public interface ProgramAccessor
    {
        StaticContextAccessor _GetGame();
    }
}