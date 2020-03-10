using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{
    public interface IMeasurable
    {
        
    }

    public interface IMeasurable1D : IMeasurable
    {
        double Lenght { get; }
    }

    public interface IMeasurable2D : IMeasurable
    {
        double Surfice { get; }
        double Perimeter { get; }
    }

    public interface IMeasurable3D : IMeasurable
    {
        double Surfice { get; }
        double Volume { get; }
    }
}
