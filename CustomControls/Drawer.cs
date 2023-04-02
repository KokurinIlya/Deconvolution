using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customDesignForWForms
{
    class Drawer
    {
        public static GraphicsPath RoundedRectangle(Rectangle rectangle, float RoundSize)
        {
            GraphicsPath graphicsPath = new GraphicsPath();

            graphicsPath.AddArc(rectangle.X, rectangle.Y, RoundSize, RoundSize, 180, 90);
            graphicsPath.AddArc(rectangle.X + rectangle.Width - RoundSize, rectangle.Y, RoundSize, RoundSize, 270, 90);
            graphicsPath.AddArc(rectangle.X + rectangle.Width - RoundSize, rectangle.Y + rectangle.Height - RoundSize, RoundSize, RoundSize, 0, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Y + rectangle.Height - RoundSize, RoundSize, RoundSize, 90, 90);

            graphicsPath.CloseFigure();

            return graphicsPath;
        }
    }
}
