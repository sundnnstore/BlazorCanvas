using System.Drawing;
using Microsoft.AspNetCore.Components;

namespace BlazorCanvas.Example7.Core
{
    public class Sprite
    {
        public Size Size { get; set; }
        public Point Origin { get; set; }
        public ElementReference SpriteSheet { get; set; }
    }
}