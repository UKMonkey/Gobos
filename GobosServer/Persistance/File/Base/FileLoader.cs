﻿using System;
using Vortex.Interface;

namespace Outbreak.Server.Persistance.File.Base
{
    public abstract class FileLoader : IDisposable
    {
        public IGame Game { get; set; }
        public abstract void Dispose();
    }
}
