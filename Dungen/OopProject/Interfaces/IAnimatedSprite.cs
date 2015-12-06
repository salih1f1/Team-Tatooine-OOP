using System.Security.Cryptography.X509Certificates;
using Microsoft.Xna.Framework.Graphics;

namespace OopProject.Interfaces
{
    // Interface for all animated sprites like worrior, vallian, tank, etc.
    public interface IAnimatedSprite 
    {
        Texture2D Texture { get; set; } // for texture
        int Row { get; set; } // start row for each move in the Atlas 
        int EndColumn { get; set; } // end column for movie in the Atlas 
    }
}