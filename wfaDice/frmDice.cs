using System;
using System.Drawing;
using System.Windows.Forms;

namespace wfaDice
{
    public partial class FrmDice : Form
    {
        /// <summary>
        /// Construtor do Form
        /// </summary>
        public FrmDice()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Existe o evento "PaintEventArgs" para desenhar também.
        /// É possível usá-lo para desenhar a moldura ou colocar no próprio 
        /// construtor da classe do Form, abaixo do "InitializeComponent();"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmDice_Paint(object sender, PaintEventArgs e)
        {
            Rectangle RcDraw = new Rectangle
            {
                Height = 130,
                Width = 130,
                X = CmdRollDice.Location.X + 1,
                Y = CmdRollDice.Location.Y - 140
            };

            e.Graphics.DrawRoundedRectangle(new Pen(Color.Blue, 8), RcDraw, 20);

            // Experimente substituir todo o código acima por somente essa única linha abaixo...

            //ClsDiceGDI.DesenhaMolduraDado(this, Color.Blue, CmdRollDice.Location.X + 25, CmdRollDice.Location.Y - 130);
        }

        #region GDI
        /// <summary>
        /// Botão que Rola os Dados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmdRollDice_Click(object sender, EventArgs e)
        {
            Sorteio Sort = new Sorteio();

            string strNum = Sort.Sorteia();

            ClsDiceGDI.DesenhaValorDado(this, Convert.ToByte(strNum), Color.Black, CmdRollDice.Location.X + 25, CmdRollDice.Location.Y - 130, 12);
            LblNumero.Text = strNum;
        }

        /// <summary>
        /// Botão que desenha um dado sem números (0 - não existe). Moldura + Número.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cmd0_Click(object sender, EventArgs e)
        {
            ClsDiceGDI.DesenhaDadoCompleto(this, 0, Color.Red, Color.BurlyWood, CmdRollDice.Location.X + 25, CmdRollDice.Location.Y - 130, 12);
            LblNumero.Text = "0";
        }

        /// <summary>
        /// Botão que desenha o número 1 do dado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cmd1_Click(object sender, EventArgs e)
        {
            ClsDiceGDI.DesenhaValorDado(this, 1, Color.Brown, CmdRollDice.Location.X + 25, CmdRollDice.Location.Y - 130, 12);
            LblNumero.Text = "1";
        }

        /// <summary>
        /// Botão que desenha um dado com o número 2.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cmd2_Click(object sender, EventArgs e)
        {
            ClsDiceGDI.DesenhaValorDado(this, 2, Color.Cyan, CmdRollDice.Location.X + 25, CmdRollDice.Location.Y - 130, 12);
            LblNumero.Text = "2";
        }

        /// <summary>
        /// Botão que desenha um dado com o número 3.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cmd3_Click(object sender, EventArgs e)
        {
            ClsDiceGDI.DesenhaValorDado(this, 3, Color.Tomato, CmdRollDice.Location.X + 25, CmdRollDice.Location.Y - 130, 12);
            LblNumero.Text = "3";
        }

        /// <summary>
        /// Botão que desenha um dado com o número 4.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cmd4_Click(object sender, EventArgs e)
        {
            ClsDiceGDI.DesenhaValorDado(this, 4, Color.Turquoise, CmdRollDice.Location.X + 25, CmdRollDice.Location.Y - 130, 12);
            LblNumero.Text = "4";
        }

        /// <summary>
        /// Botão que desenha um dado com o número 5.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cmd5_Click(object sender, EventArgs e)
        {
            ClsDiceGDI.DesenhaValorDado(this, 5, Color.Yellow, CmdRollDice.Location.X + 25, CmdRollDice.Location.Y - 130, 12);
            LblNumero.Text = "5";
        }

        /// <summary>
        /// Botão que desenha um dado com o número 6.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cmd6_Click(object sender, EventArgs e)
        {
            ClsDiceGDI.DesenhaValorDado(this, 6, Color.Green, CmdRollDice.Location.X + 25, CmdRollDice.Location.Y - 130, 12);
            LblNumero.Text = "6";
        }

        /// <summary>
        /// Botão que desenha um dado o número 7 (não existe). Moldura + Número.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cmd7_Click(object sender, EventArgs e)
        {
            ClsDiceGDI.DesenhaDadoCompleto(this, 7, Color.Red, Color.Red, CmdRollDice.Location.X + 25, CmdRollDice.Location.Y - 130, 12);
            LblNumero.Text = "7";
        }
        #endregion

        #region Skiasharp

        private void CmdRollDiceSkiasharp_Click(object sender, EventArgs e)
        {
            Sorteio Sort = new Sorteio();

            string strNum = Sort.Sorteia();

            ClsDiceSkia.DesenhaDadoCompleto(ref pcbDiceSkiasharp, Convert.ToByte(strNum), "#0000FF", "#000000", CmdRollDiceSkiasharp.Location.X + 25, CmdRollDiceSkiasharp.Location.Y - 130, 12);
            LblNumeroSkia.Text = strNum;
        }

        private void Cmd0Skia_Click(object sender, EventArgs e)
        {
            ClsDiceSkia.DesenhaDadoCompleto(ref pcbDiceSkiasharp, 0, ClsDiceSkia.ColorToHex(Color.Red), ClsDiceSkia.ColorToHex(Color.OrangeRed), CmdRollDiceSkiasharp.Location.X + 25, CmdRollDiceSkiasharp.Location.Y - 130, 12);
            LblNumeroSkia.Text = "0";
        }

        private void Cmd1Skia_Click(object sender, EventArgs e)
        {
            ClsDiceSkia.DesenhaDadoCompleto(ref pcbDiceSkiasharp, 1, "#00FF00", "#FF0000", CmdRollDiceSkiasharp.Location.X + 25, CmdRollDiceSkiasharp.Location.Y - 130, 12);
            LblNumeroSkia.Text = "1";
        }

        private void Cmd2Skia_Click(object sender, EventArgs e)
        {
            ClsDiceSkia.DesenhaDadoCompleto(ref pcbDiceSkiasharp, 2, "#000000", "#FF00FF", CmdRollDiceSkiasharp.Location.X + 25, CmdRollDiceSkiasharp.Location.Y - 130, 12);
            LblNumeroSkia.Text = "2";
        }

        private void Cmd3Skia_Click(object sender, EventArgs e)
        {
            ClsDiceSkia.DesenhaDadoCompleto(ref pcbDiceSkiasharp, 3, ClsDiceSkia.ColorToHex(Color.Blue), ClsDiceSkia.ColorToHex(Color.BlueViolet), CmdRollDiceSkiasharp.Location.X + 25, CmdRollDiceSkiasharp.Location.Y - 130, 12);
            LblNumeroSkia.Text = "3";
        }

        private void Cmd4Skia_Click(object sender, EventArgs e)
        {
            ClsDiceSkia.DesenhaDadoCompleto(ref pcbDiceSkiasharp, 4, ClsDiceSkia.ColorToHex(Color.Violet), ClsDiceSkia.ColorToHex(Color.DarkGoldenrod), CmdRollDiceSkiasharp.Location.X + 25, CmdRollDiceSkiasharp.Location.Y - 130, 12);
            LblNumeroSkia.Text = "4";
        }

        private void Cmd5Skia_Click(object sender, EventArgs e)
        {
            ClsDiceSkia.DesenhaDadoCompleto(ref pcbDiceSkiasharp, 5, ClsDiceSkia.ColorToHex(Color.OrangeRed), ClsDiceSkia.ColorToHex(Color.GreenYellow), CmdRollDiceSkiasharp.Location.X + 25, CmdRollDiceSkiasharp.Location.Y - 130, 12);
            LblNumeroSkia.Text = "5";
        }

        private void Cmd6Skia_Click(object sender, EventArgs e)
        {
            ClsDiceSkia.DesenhaDadoCompleto(ref pcbDiceSkiasharp, 6, ClsDiceSkia.ColorToHex(Color.DarkBlue), ClsDiceSkia.ColorToHex(Color.DarkGreen), CmdRollDiceSkiasharp.Location.X + 25, CmdRollDiceSkiasharp.Location.Y - 130, 12);
            LblNumeroSkia.Text = "6";
        }

        private void Cmd7Skia_Click(object sender, EventArgs e)
        {
            ClsDiceSkia.DesenhaDadoCompleto(ref pcbDiceSkiasharp, 7, ClsDiceSkia.ColorToHex(Color.Red), ClsDiceSkia.ColorToHex(Color.DarkOliveGreen), CmdRollDiceSkiasharp.Location.X + 25, CmdRollDiceSkiasharp.Location.Y - 130, 12);
            LblNumeroSkia.Text = "7";
        }

        #endregion
    }
}
