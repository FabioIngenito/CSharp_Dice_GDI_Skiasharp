using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace clsDiceGDI
{
    internal static class ClsDrawGDI
    {
        /// <summary>
        /// How to draw a rounded rectangle in c#
        /// https://stackoverflow.com/questions/33853434/how-to-draw-a-rounded-rectangle-in-c-sharp
        /// </summary>
        /// <param name="bounds">Objeto Rectangle</param>
        /// <param name="radius">Valor inteiro para o canto aredondado</param>
        /// <returns></returns>
        public static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // top left arc  
            path.AddArc(arc, 180, 90);

            // top right arc  
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc  
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc 
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        /// <summary>
        /// Desenha um retângulo NÃO preenchido com bordas arredondadas.
        /// How to draw a rounded rectangle in c#
        /// https://stackoverflow.com/questions/33853434/how-to-draw-a-rounded-rectangle-in-c-sharp
        /// </summary>
        /// <param name="graphics">Objeto Graphic</param>
        /// <param name="pen">Objeto Pen</param>
        /// <param name="bounds">Objeto Rectangle</param>
        /// <param name="cornerRadius">Valor inteiro para o canto aredondado</param>
        public static void DrawRoundedRectangle(this Graphics graphics, Pen pen, Rectangle bounds, int cornerRadius)
        {
            if (graphics == null)
                throw new ArgumentNullException("graphics");
            if (pen == null)
                throw new ArgumentNullException("pen");

            using (GraphicsPath path = RoundedRect(bounds, cornerRadius))
            {
                graphics.DrawPath(pen, path);
            }
        }

        /// <summary>
        /// Desenha um retângulo preenchido com bordas arredondadas.
        /// How to draw a rounded rectangle in c#
        /// https://stackoverflow.com/questions/33853434/how-to-draw-a-rounded-rectangle-in-c-sharp
        /// </summary>
        /// <param name="graphics">Objeto Graphic</param>
        /// <param name="pen">Objeto Pen</param>
        /// <param name="bounds">Objeto Rectangle</param>
        /// <param name="cornerRadius">Valor inteiro para o canto aredondado</param>
        public static void FillRoundedRectangle(this Graphics graphics, Brush brush, Rectangle bounds, int cornerRadius)
        {
            if (graphics == null)
                throw new ArgumentNullException("graphics");
            if (brush == null)
                throw new ArgumentNullException("brush");

            using (GraphicsPath path = RoundedRect(bounds, cornerRadius))
            {
                graphics.FillPath(brush, path);
            }
        }

        /// <summary>
        /// Desenha um círculo NÃO preenchido
        /// Drawing circles with System.Drawing
        /// https://stackoverflow.com/questions/1835062/drawing-circles-with-system-drawing
        /// </summary>
        /// <param name="g">Objeto Graphic</param>
        /// <param name="pen">>Objeto Pen</param>
        /// <param name="centerX">Float de X</param>
        /// <param name="centerY">Float de Y</param>
        /// <param name="radius">Valor inteiro para o canto aredondado</param>
        public static void DrawCircle(this Graphics g, Pen pen,
                              float centerX, float centerY, float radius)
        {
            g.DrawEllipse(pen, centerX - radius, centerY - radius,
                          radius + radius, radius + radius);
        }

        /// <summary>
        /// Desenha um círculo preenchido
        /// Drawing circles with System.Drawing
        /// https://stackoverflow.com/questions/1835062/drawing-circles-with-system-drawing
        /// </summary>
        /// <param name="g">Objeto Graphic</param>
        /// <param name="pen">>Objeto Pen</param>
        /// <param name="centerX">Float de X</param>
        /// <param name="centerY">Float de Y</param>
        /// <param name="radius">Valor inteiro para o canto aredondado</param>
        public static void FillCircle(this Graphics g, Brush brush,
                                      float centerX, float centerY, float radius)
        {
            g.FillEllipse(brush, centerX - radius, centerY - radius,
                          radius + radius, radius + radius);
        }
    }
}
