using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using SkiaSharp;

namespace wfaDice
{
    internal class ClsDiceSkia
    {
        //TODO Separar no Skiasharp a modura dos valores, mas é preciso "juntar" os dois depois.

        ///// <summary>
        ///// Desenha a moldura do dado na tela com os valores passados
        ///// </summary>
        ///// <param name="c">O Controle que receberá o desenho da moldura do Dado</param>
        ///// <param name="CorMoldura">Cor da moldura do Dado</param>
        ///// <param name="PosX">Posição X da moldura do Dado</param>
        ///// <param name="PosY">Posição Y da moldura do Dado</param>
        //public static void DesenhaMolduraDado(ref PictureBox c, string CorMoldura, int PosX, int PosY)
        //{
        //    SKColor SKMoldura = new SKColor();
        //    SKColor.TryParse(CorMoldura, out SKMoldura);
        //    SKImageInfo imageInfo = new SKImageInfo(c.Size.Width, c.Size.Height);

        //    using (SKSurface surface = SKSurface.Create(imageInfo))
        //    {
        //        SKCanvas canvas = surface.Canvas;
        //        canvas.Clear(SKColors.Transparent);

        //        SKPaint paintMoldura = new SKPaint
        //        {
        //            Style = SKPaintStyle.Stroke,
        //            Color = SKMoldura,
        //            IsAntialias = true,
        //            StrokeWidth = 8
        //        };

        //        canvas.DrawRoundRect(5, 5, imageInfo.Width - 10, imageInfo.Height - 10, 20, 20, paintMoldura);

        //        using (SKImage image = surface.Snapshot())
        //        using (SKData data = image.Encode(SKEncodedImageFormat.Png, 100))
        //        using (MemoryStream mStream = new MemoryStream(data.ToArray()))
        //        {
        //            Bitmap bm = new Bitmap(mStream, false);
        //            c.Image = bm;
        //        }
        //    }
        //}

        ///// <summary>
        ///// Desenha o número do dado na tela com os valores passados
        ///// </summary>
        ///// <param name="c">O Controle que receberá o desenho do número do Dado</param>
        ///// <param name="Num">Número do Dado</param>
        ///// <param name="CorNumero">Cor do número do Dado</param>
        ///// <param name="PosX">Posição X da moldura do Dado</param>
        ///// <param name="PosY">Posição Y da moldura do Dado</param>
        ///// <param name="Tam">Tamanho do circulo dos números do Dado</param>
        //public static void DesenhaValorDado(ref PictureBox c, byte Num, string CorNumero, int PosX, int PosY, int Tam)
        //{
        //    SKColor SKNumero = new SKColor();
        //    SKColor SKBackColor = new SKColor();

        //    SKColor.TryParse(CorNumero, out SKNumero);
        //    SKColor.TryParse(ColorToHex(c.BackColor), out SKBackColor);

        //    SKImageInfo imageInfo = new SKImageInfo(c.Size.Width, c.Size.Height);

        //    using (SKSurface surface = SKSurface.Create(imageInfo))
        //    {
        //        SKCanvas canvas = surface.Canvas;
        //        //canvas.Clear(SKColors.Transparent);

        //        SKPaint paintNumero = new SKPaint
        //        {
        //            Color = SKNumero,
        //            IsAntialias = true,
        //            Style = SKPaintStyle.Fill
        //        };

        //        SKPaint paintBackColor = new SKPaint
        //        {
        //            Color = SKBackColor,
        //            IsAntialias = true,
        //            Style = SKPaintStyle.Fill
        //        };

        //        switch (Num)
        //        {
        //            case 0:
        //                canvas.DrawCircle(35, 35, Tam, paintBackColor);
        //                canvas.DrawCircle(35, 75, Tam, paintBackColor);
        //                canvas.DrawCircle(35, 115, Tam, paintBackColor);
        //                canvas.DrawCircle(75, 75, Tam, paintBackColor);
        //                canvas.DrawCircle(115, 35, Tam, paintBackColor);
        //                canvas.DrawCircle(115, 75, Tam, paintBackColor);
        //                canvas.DrawCircle(115, 115, Tam, paintBackColor);
        //                break;

        //            case 1:
        //                canvas.DrawCircle(35, 35, Tam, paintBackColor);
        //                canvas.DrawCircle(35, 75, Tam, paintBackColor);
        //                canvas.DrawCircle(35, 115, Tam, paintBackColor);
        //                canvas.DrawCircle(75, 75, Tam, paintNumero);
        //                canvas.DrawCircle(115, 35, Tam, paintBackColor);
        //                canvas.DrawCircle(115, 75, Tam, paintBackColor);
        //                canvas.DrawCircle(115, 115, Tam, paintBackColor);
        //                break;

        //            case 2:
        //                canvas.DrawCircle(35, 35, Tam, paintNumero);
        //                canvas.DrawCircle(35, 75, Tam, paintBackColor);
        //                canvas.DrawCircle(35, 115, Tam, paintBackColor);
        //                canvas.DrawCircle(75, 75, Tam, paintBackColor);
        //                canvas.DrawCircle(115, 35, Tam, paintBackColor);
        //                canvas.DrawCircle(115, 75, Tam, paintBackColor);
        //                canvas.DrawCircle(115, 115, Tam, paintNumero);
        //                break;

        //            case 3:
        //                canvas.DrawCircle(35, 35, Tam, paintNumero);
        //                canvas.DrawCircle(35, 75, Tam, paintBackColor);
        //                canvas.DrawCircle(35, 115, Tam, paintBackColor);
        //                canvas.DrawCircle(75, 75, Tam, paintNumero);
        //                canvas.DrawCircle(115, 35, Tam, paintBackColor);
        //                canvas.DrawCircle(115, 75, Tam, paintBackColor);
        //                canvas.DrawCircle(115, 115, Tam, paintNumero);
        //                break;

        //            case 4:
        //                canvas.DrawCircle(35, 35, Tam, paintNumero);
        //                canvas.DrawCircle(35, 75, Tam, paintBackColor);
        //                canvas.DrawCircle(35, 115, Tam, paintNumero);
        //                canvas.DrawCircle(75, 75, Tam, paintBackColor);
        //                canvas.DrawCircle(115, 35, Tam, paintNumero);
        //                canvas.DrawCircle(115, 75, Tam, paintBackColor);
        //                canvas.DrawCircle(115, 115, Tam, paintNumero);
        //                break;

        //            case 5:
        //                canvas.DrawCircle(35, 35, Tam, paintNumero);
        //                canvas.DrawCircle(35, 75, Tam, paintBackColor);
        //                canvas.DrawCircle(35, 115, Tam, paintNumero);
        //                canvas.DrawCircle(75, 75, Tam, paintNumero);
        //                canvas.DrawCircle(115, 35, Tam, paintNumero);
        //                canvas.DrawCircle(115, 75, Tam, paintBackColor);
        //                canvas.DrawCircle(115, 115, Tam, paintNumero);
        //                break;

        //            case 6:
        //                canvas.DrawCircle(35, 35, Tam, paintNumero);
        //                canvas.DrawCircle(35, 75, Tam, paintNumero);
        //                canvas.DrawCircle(35, 115, Tam, paintNumero);
        //                canvas.DrawCircle(75, 75, Tam, paintBackColor);
        //                canvas.DrawCircle(115, 35, Tam, paintNumero);
        //                canvas.DrawCircle(115, 75, Tam, paintNumero);
        //                canvas.DrawCircle(115, 115, Tam, paintNumero);
        //                break;

        //            case 7:
        //                canvas.DrawCircle(35, 35, Tam, paintNumero);
        //                canvas.DrawCircle(35, 75, Tam, paintNumero);
        //                canvas.DrawCircle(35, 115, Tam, paintNumero);
        //                canvas.DrawCircle(75, 75, Tam, paintNumero);
        //                canvas.DrawCircle(115, 35, Tam, paintNumero);
        //                canvas.DrawCircle(115, 75, Tam, paintNumero);
        //                canvas.DrawCircle(115, 115, Tam, paintNumero);
        //                break;

        //            default:
        //                canvas.DrawCircle(35, 35, Tam, paintBackColor);
        //                canvas.DrawCircle(35, 75, Tam, paintBackColor);
        //                canvas.DrawCircle(35, 115, Tam, paintBackColor);
        //                canvas.DrawCircle(75, 75, Tam, paintBackColor);
        //                canvas.DrawCircle(115, 35, Tam, paintBackColor);
        //                canvas.DrawCircle(115, 75, Tam, paintBackColor);
        //                canvas.DrawCircle(115, 115, Tam, paintBackColor);
        //                break;
        //        }

        //        using (SKImage image = surface.Snapshot())
        //        using (SKData data = image.Encode(SKEncodedImageFormat.Png, 100))
        //        using (MemoryStream mStream = new MemoryStream(data.ToArray()))
        //        {
        //            Bitmap bm = new Bitmap(mStream, false);
        //            c.Image = bm;
        //        }
        //    }
        //}

        ///// <summary>
        ///// Desenha um Dado na tela com os valores passados
        ///// </summary>
        ///// <param name="c">O Controle que receberá o desenho do Dado</param>
        ///// <param name="Num">Número do Dado</param>
        ///// <param name="CorMoldura">Cor da moldura do Dado</param>
        ///// <param name="CorNumero">Cor do número do Dado</param>
        ///// <param name="PosX">Posição X do Dado</param>
        ///// <param name="PosY">Posição Y do Dado</param>
        ///// <param name="Tam">Tamanho do circulo dos números do Dado</param>
        //public static void DesenhaDadoCompleto(ref PictureBox c, byte Num, string CorMoldura, string CorNumero, int PosX, int PosY, int Tam)
        //{
        //    DesenhaMolduraDado(ref c, CorMoldura, PosX, PosY);
        //    DesenhaValorDado(ref c, Num, CorNumero, PosX, PosY, Tam);
        //}

        /// <summary>
        /// Desenha um Dado na tela com os valores passados.
        /// </summary>
        /// <param name="c">O Controle que receberá o desenho do Dado.</param>
        /// <param name="Num">Número do Dado</param>
        /// <param name="CorMoldura">Cor da moldura do Dado</param>
        /// <param name="CorNumero">Cor do número do Dado</param>
        /// <param name="PosX">Posição X do Dado</param>
        /// <param name="PosY">Posição Y do Dado</param>
        /// <param name="Tam">Tamanho do circulo dos números do Dado</param>
        public static void DesenhaDadoCompleto(ref PictureBox c, byte Num, string CorMoldura, string CorNumero, int PosX, int PosY, int Tam)
        {
            SKColor SKMoldura = new SKColor();
            SKColor SKNumero = new SKColor();
            SKColor SKBackColor = new SKColor();

            SKColor.TryParse(CorMoldura, out SKMoldura);
            SKColor.TryParse(CorNumero, out SKNumero);
            SKColor.TryParse(ColorToHex(c.BackColor), out SKBackColor);

            SKImageInfo imageInfo = new SKImageInfo(c.Size.Width, c.Size.Height);

            using (SKSurface surface = SKSurface.Create(imageInfo))
            {
                try
                {
                    SKCanvas canvas = surface.Canvas;
                    canvas.Clear(SKColors.Transparent);

                    // Quadrado ----------------------------------------------
                    SKPaint paintExter = new SKPaint
                    {
                        Style = SKPaintStyle.Stroke,
                        Color = SKMoldura,
                        IsAntialias = true,
                        StrokeWidth = 8
                    };

                    canvas.DrawRoundRect(5, 5, imageInfo.Width - 10, imageInfo.Height - 10, 20, 20, paintExter);
                    //----------------------------------------------

                    SKPaint paintNumero = new SKPaint
                    {
                        Color = SKNumero,
                        IsAntialias = true,
                        Style = SKPaintStyle.Fill
                    };

                    SKPaint paintBackColor = new SKPaint
                    {
                        Color = SKBackColor,
                        IsAntialias = true,
                        Style = SKPaintStyle.Fill
                    };

                    switch (Num)
                    {
                        case 0:
                            canvas.DrawCircle(35, 35, Tam, paintBackColor);
                            canvas.DrawCircle(35, 75, Tam, paintBackColor);
                            canvas.DrawCircle(35, 115, Tam, paintBackColor);
                            canvas.DrawCircle(75, 75, Tam, paintBackColor);
                            canvas.DrawCircle(115, 35, Tam, paintBackColor);
                            canvas.DrawCircle(115, 75, Tam, paintBackColor);
                            canvas.DrawCircle(115, 115, Tam, paintBackColor);
                            break;

                        case 1:
                            canvas.DrawCircle(35, 35, Tam, paintBackColor);
                            canvas.DrawCircle(35, 75, Tam, paintBackColor);
                            canvas.DrawCircle(35, 115, Tam, paintBackColor);
                            canvas.DrawCircle(75, 75, Tam, paintNumero);
                            canvas.DrawCircle(115, 35, Tam, paintBackColor);
                            canvas.DrawCircle(115, 75, Tam, paintBackColor);
                            canvas.DrawCircle(115, 115, Tam, paintBackColor);
                            break;

                        case 2:
                            canvas.DrawCircle(35, 35, Tam, paintNumero);
                            canvas.DrawCircle(35, 75, Tam, paintBackColor);
                            canvas.DrawCircle(35, 115, Tam, paintBackColor);
                            canvas.DrawCircle(75, 75, Tam, paintBackColor);
                            canvas.DrawCircle(115, 35, Tam, paintBackColor);
                            canvas.DrawCircle(115, 75, Tam, paintBackColor);
                            canvas.DrawCircle(115, 115, Tam, paintNumero);
                            break;

                        case 3:
                            canvas.DrawCircle(35, 35, Tam, paintNumero);
                            canvas.DrawCircle(35, 75, Tam, paintBackColor);
                            canvas.DrawCircle(35, 115, Tam, paintBackColor);
                            canvas.DrawCircle(75, 75, Tam, paintNumero);
                            canvas.DrawCircle(115, 35, Tam, paintBackColor);
                            canvas.DrawCircle(115, 75, Tam, paintBackColor);
                            canvas.DrawCircle(115, 115, Tam, paintNumero);
                            break;

                        case 4:
                            canvas.DrawCircle(35, 35, Tam, paintNumero);
                            canvas.DrawCircle(35, 75, Tam, paintBackColor);
                            canvas.DrawCircle(35, 115, Tam, paintNumero);
                            canvas.DrawCircle(75, 75, Tam, paintBackColor);
                            canvas.DrawCircle(115, 35, Tam, paintNumero);
                            canvas.DrawCircle(115, 75, Tam, paintBackColor);
                            canvas.DrawCircle(115, 115, Tam, paintNumero);
                            break;

                        case 5:
                            canvas.DrawCircle(35, 35, Tam, paintNumero);
                            canvas.DrawCircle(35, 75, Tam, paintBackColor);
                            canvas.DrawCircle(35, 115, Tam, paintNumero);
                            canvas.DrawCircle(75, 75, Tam, paintNumero);
                            canvas.DrawCircle(115, 35, Tam, paintNumero);
                            canvas.DrawCircle(115, 75, Tam, paintBackColor);
                            canvas.DrawCircle(115, 115, Tam, paintNumero);
                            break;

                        case 6:
                            canvas.DrawCircle(35, 35, Tam, paintNumero);
                            canvas.DrawCircle(35, 75, Tam, paintNumero);
                            canvas.DrawCircle(35, 115, Tam, paintNumero);
                            canvas.DrawCircle(75, 75, Tam, paintBackColor);
                            canvas.DrawCircle(115, 35, Tam, paintNumero);
                            canvas.DrawCircle(115, 75, Tam, paintNumero);
                            canvas.DrawCircle(115, 115, Tam, paintNumero);
                            break;

                        case 7:
                            canvas.DrawCircle(35, 35, Tam, paintNumero);
                            canvas.DrawCircle(35, 75, Tam, paintNumero);
                            canvas.DrawCircle(35, 115, Tam, paintNumero);
                            canvas.DrawCircle(75, 75, Tam, paintNumero);
                            canvas.DrawCircle(115, 35, Tam, paintNumero);
                            canvas.DrawCircle(115, 75, Tam, paintNumero);
                            canvas.DrawCircle(115, 115, Tam, paintNumero);
                            break;

                        default:
                            canvas.DrawCircle(35, 35, Tam, paintBackColor);
                            canvas.DrawCircle(35, 75, Tam, paintBackColor);
                            canvas.DrawCircle(35, 115, Tam, paintBackColor);
                            canvas.DrawCircle(75, 75, Tam, paintBackColor);
                            canvas.DrawCircle(115, 35, Tam, paintBackColor);
                            canvas.DrawCircle(115, 75, Tam, paintBackColor);
                            canvas.DrawCircle(115, 115, Tam, paintBackColor);
                            break;
                    }

                    using (SKImage image = surface.Snapshot())
                    using (SKData data = image.Encode(SKEncodedImageFormat.Png, 100))
                    using (MemoryStream mStream = new MemoryStream(data.ToArray()))
                    {
                        Bitmap bm = new Bitmap(mStream, false);
                        c.Image = bm;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Converting System.Drawing.Color to hex
        /// https://gunnarpeipman.com/net/color-to-hex/
        /// </summary>
        /// <param name="color">Color</param>
        /// <returns>Hexadecimal</returns>
        public static string ColorToHex(Color color)
        {
            return ColorTranslator.ToHtml(Color.FromArgb(color.ToArgb()));
        }
    }
}
