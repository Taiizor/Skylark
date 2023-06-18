using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using HF = Skylark.Helper.Format;

namespace Skylark.Struct.Rectangles
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="Left"></param>
    /// <param name="Top"></param>
    /// <param name="Right"></param>
    /// <param name="Bottom"></param>
    [StructLayout(LayoutKind.Sequential)]
    public struct RectanglesStruct(int Left, int Top, int Right, int Bottom)
    {
        /// <summary>
        /// 
        /// </summary>
        public int Left = Left, Top = Top, Right = Right, Bottom = Bottom;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Rectangle"></param>
        public RectanglesStruct(Rectangle Rectangle) : this(Rectangle.Left, Rectangle.Top, Rectangle.Right, Rectangle.Bottom)
        {
            //
        }

        /// <summary>
        /// 
        /// </summary>
        public int X
        {
            get => Left;
            set
            {
                Right -= Left - value;
                Left = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Y
        {
            get => Top;
            set
            {
                Bottom -= Top - value;
                Top = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Height
        {
            get => Bottom - Top;
            set => Bottom = value + Top;
        }

        /// <summary>
        /// 
        /// </summary>
        public int Width
        {
            get => Right - Left;
            set => Right = value + Left;
        }

        /// <summary>
        /// 
        /// </summary>
        public Point Location
        {
            get => new(Left, Top);
            set
            {
                X = value.X;
                Y = value.Y;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Size Size
        {
            get => new(Width, Height);
            set
            {
                Width = value.Width;
                Height = value.Height;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Rectangle"></param>
        public static implicit operator Rectangle(RectanglesStruct Rectangle)
        {
            return new Rectangle(Rectangle.Left, Rectangle.Top, Rectangle.Width, Rectangle.Height);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Rectangle"></param>
        public static implicit operator RectanglesStruct(Rectangle Rectangle)
        {
            return new RectanglesStruct(Rectangle);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Rectangle1"></param>
        /// <param name="Rectangle2"></param>
        /// <returns></returns>
        public static bool operator ==(RectanglesStruct Rectangle1, RectanglesStruct Rectangle2)
        {
            return Rectangle1.Equals(Rectangle2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Rectangle1"></param>
        /// <param name="Rectangle2"></param>
        /// <returns></returns>
        public static bool operator !=(RectanglesStruct Rectangle1, RectanglesStruct Rectangle2)
        {
            return !Rectangle1.Equals(Rectangle2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Rectangle"></param>
        /// <returns></returns>
        public readonly bool Equals(RectanglesStruct Rectangle)
        {
            return Rectangle.Left == Left && Rectangle.Top == Top && Rectangle.Right == Right && Rectangle.Bottom == Bottom;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Object"></param>
        /// <returns></returns>
        public override readonly bool Equals(object Object)
        {
            if (Object is RectanglesStruct)
            {
                return Equals((RectanglesStruct)Object);
            }
            else if (Object is Rectangle)
            {
                return Equals(new RectanglesStruct((Rectangle)Object));
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override readonly int GetHashCode()
        {
            return ((Rectangle)this).GetHashCode();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override readonly string ToString()
        {
            return HF.Formatter(CultureInfo.CurrentCulture, "{{Left={0},Top={1},Right={2},Bottom={3}}}", Left, Top, Right, Bottom);
        }
    }
}