using System.Drawing;
using System.Windows.Forms;

namespace wfaDice
{
    internal class ClsDiceGDI
    {
        /// <summary>
        /// Desenha a moldura do dado na tela com os valores passados.
        /// </summary>
        /// <param name="c">O Controle que receberá o desenho da moldura do Dado.</param>
        /// <param name="CorMoldura">Cor da moldura do Dado</param>
        /// <param name="PosX">Posição X da moldura do Dado</param>
        /// <param name="PosY">Posição Y da moldura do Dado</param>
        public static void DesenhaMolduraDado(Control c, Color CorMoldura, int PosX, int PosY)
        {
            Graphics g = c.CreateGraphics();
            Pen pnCorExterna = new Pen(CorMoldura, 8);
            //TODO: O valor do retângulo valor ficou chubado (hard-code) é possível melhorá-lo, mas precisa pensar no posicionamento dos círculos se for alterá-lo.
            Rectangle RecRetangulo = new Rectangle(PosX - 24, PosY - 10, 130, 130);
            ClsDrawGDI.DrawRoundedRectangle(g, pnCorExterna, RecRetangulo, 20);
        }

        /// <summary>
        /// Desenha os números do dado na tela com os valores passados.
        /// </summary>
        /// <param name="c">O Controle que receberá o desenho do número do Dado.</param>
        /// <param name="Num">Número do Dado</param>
        /// <param name="CorNumero">Cor do número do Dado</param>
        /// <param name="PosX">Posição X do número do Dado</param>
        /// <param name="PosY">Posição Y do número do Dado</param>
        /// <param name="Tam">Tamanho do circulo do número do Dado</param>
        public static void DesenhaValorDado(Control c, byte Num, Color CorNumero, int PosX, int PosY, int Tam)
        {
            Graphics g = c.CreateGraphics();
            SolidBrush sbCorNumero = new SolidBrush(CorNumero);
            SolidBrush sbCorFundo = new SolidBrush(c.BackColor);
            
            switch (Num)
            {
                case 0:
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 15, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 55, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 95, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 40, PosY + 55, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 15, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 55, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 95, Tam);
                    break;

                case 1:
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 15, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 55, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 95, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 40, PosY + 55, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 15, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 55, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 95, Tam);
                    break;

                case 2:
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX, PosY + 15, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 55, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 95, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 40, PosY + 55, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 15, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 55, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 80, PosY + 95, Tam);
                    break;

                case 3:
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX, PosY + 15, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 55, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 95, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 40, PosY + 55, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 15, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 55, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 80, PosY + 95, Tam);
                    break;

                case 4:
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX, PosY + 15, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 55, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX, PosY + 95, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 40, PosY + 55, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 80, PosY + 15, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 55, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 80, PosY + 95, Tam);
                    break;

                case 5:
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX, PosY + 15, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 55, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX, PosY + 95, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 40, PosY + 55, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 80, PosY + 15, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 55, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 80, PosY + 95, Tam);
                    break;

                case 6:
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX, PosY + 15, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX, PosY + 55, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX, PosY + 95, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 40, PosY + 55, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 80, PosY + 15, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 80, PosY + 55, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 80, PosY + 95, Tam);
                    break;

                case 7:
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX, PosY + 15, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX, PosY + 55, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX, PosY + 95, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 40, PosY + 55, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 80, PosY + 15, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 80, PosY + 55, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 80, PosY + 95, Tam);
                    break;

                default:
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 15, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 55, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 95, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 40, PosY + 55, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 15, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 55, Tam);
                    ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 95, Tam);
                    break;
            }
        }

        /// <summary>
        /// Desenha o dado completo, moldura + número.
        /// </summary>
        /// <param name="c">O Controle que receberá o desenho da moldura do Dado.</param>
        /// <param name="Num">Número do Dado</param>
        /// <param name="CorMoldura">Cor da moldura do Dado</param>
        /// <param name="CorNumero">Cor do número do Dado</param>
        /// <param name="PosX">Posição X do número do Dado</param>
        /// <param name="PosY">Posição Y do número do Dado</param>
        /// <param name="Tam">Tamanho do circulo do número do Dado</param>
        public static void DesenhaDadoCompleto(Control c, byte Num, Color CorMoldura, Color CorNumero, int PosX, int PosY, int Tam)
        {
            DesenhaMolduraDado(c, CorMoldura, PosX, PosY);
            DesenhaValorDado(c, Num, CorMoldura, PosX, PosY, Tam);
        }

        ///// <summary>
        ///// Desenha o dado completo, moldura + número.
        ///// </summary>
        ///// <param name="c">O Controle que receberá o desenho da moldura do Dado.</param>
        ///// <param name="Num">Número do Dado</param>
        ///// <param name="CorMoldura">Cor da moldura do Dado</param>
        ///// <param name="CorNumero">Cor do número do Dado</param>
        ///// <param name="PosX">Posição X do número do Dado</param>
        ///// <param name="PosY">Posição Y do número do Dado</param>
        ///// <param name="Tam">Tamanho do circulo do número do Dado</param>
        //public static void DesenhaDadoCompleto(Control c, byte Num, Color CorMoldura, Color CorNumero, int PosX, int PosY, int Tam)
        //{
        //    Graphics g = c.CreateGraphics();
        //    Pen pnCorExterna = new Pen(CorMoldura, 8);
        //    //TODO: O valor do retângulo valor ficou chubado (hard-code) é possível melhorá-lo, mas precisa pensar no posicionamento dos círculos se for alterá-lo.
        //    Rectangle RecRetangulo = new Rectangle(PosX - 24, PosY - 10, 130, 130);
        //    ClsDrawGDI.DrawRoundedRectangle(g, pnCorExterna, RecRetangulo, 20);

        //    SolidBrush sbCorNumero = new SolidBrush(CorNumero);
        //    SolidBrush sbCorFundo = new SolidBrush(c.BackColor);

        //    switch (Num)
        //    {
        //        case 0:
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 15, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 55, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 95, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 40, PosY + 55, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 15, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 55, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 95, Tam);
        //            break;

        //        case 1:
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 15, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 55, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 95, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 40, PosY + 55, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 15, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 55, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 95, Tam);
        //            break;

        //        case 2:
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX, PosY + 15, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 55, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 95, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 40, PosY + 55, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 15, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 55, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 80, PosY + 95, Tam);
        //            break;

        //        case 3:
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX, PosY + 15, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 55, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 95, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 40, PosY + 55, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 15, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 55, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 80, PosY + 95, Tam);
        //            break;

        //        case 4:
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX, PosY + 15, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 55, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX, PosY + 95, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 40, PosY + 55, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 80, PosY + 15, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 55, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 80, PosY + 95, Tam);
        //            break;

        //        case 5:
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX, PosY + 15, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 55, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX, PosY + 95, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 40, PosY + 55, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 80, PosY + 15, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 55, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 80, PosY + 95, Tam);
        //            break;

        //        case 6:
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX, PosY + 15, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX, PosY + 55, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX, PosY + 95, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 40, PosY + 55, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 80, PosY + 15, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 80, PosY + 55, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 80, PosY + 95, Tam);
        //            break;

        //        case 7:
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX, PosY + 15, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX, PosY + 55, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX, PosY + 95, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 40, PosY + 55, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 80, PosY + 15, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 80, PosY + 55, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorNumero, PosX + 80, PosY + 95, Tam);
        //            break;

        //        default:
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 15, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 55, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX, PosY + 95, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 40, PosY + 55, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 15, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 55, Tam);
        //            ClsDrawGDI.FillCircle(g, sbCorFundo, PosX + 80, PosY + 95, Tam);
        //            break;
        //    }
        //}
    }
}

