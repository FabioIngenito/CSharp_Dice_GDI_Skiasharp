using System;
using System.Drawing;
using System.Windows.Forms;

namespace clsDiceGDI
{
    public partial class UcDiceGDI : UserControl
    {
        /// <summary>
        /// Construtor do User Control
        /// </summary>
        public UcDiceGDI()
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
        private void UcDiceGDI_Paint(object sender, PaintEventArgs e)
        {
            ClsDiceGDI.DesenhaMolduraDado(this, Color.Black, CmdRollDice.Location.X + 25, CmdRollDice.Location.Y - 130);
        }

        /// <summary>
        /// Botão que Rola os Dados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmdRollDice_Click(object sender, EventArgs e)
        {
            string strNum = ClsSorteio.Sorteia();

            ClsDiceGDI.DesenhaValorDado(this, Convert.ToByte(strNum), Color.Red, CmdRollDice.Location.X + 25, CmdRollDice.Location.Y - 130, 12);
            LblNumero.Text = strNum;
        }

        /// <summary>
        /// Botão que desenha um dado sem números (0 - não existe). Moldura + Número.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cmd0_Click(object sender, EventArgs e)
        {
            ClsDiceGDI.DesenhaDadoCompleto(this, 0, Color.Red, Color.Blue, CmdRollDice.Location.X + 25, CmdRollDice.Location.Y - 130, 12);
            LblNumero.Text = "0";
        }

        /// <summary>
        /// Botão que desenha um dado com o número 1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cmd1_Click(object sender, EventArgs e)
        {
            ClsDiceGDI.DesenhaValorDado(this, 1, Color.OrangeRed, CmdRollDice.Location.X + 25, CmdRollDice.Location.Y - 130, 12);
            LblNumero.Text = "1";
        }

        /// <summary>
        /// Botão que desenha um dado com o número 2.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cmd2_Click(object sender, EventArgs e)
        {
            ClsDiceGDI.DesenhaValorDado(this, 2, Color.Moccasin, CmdRollDice.Location.X + 25, CmdRollDice.Location.Y - 130, 12);
            LblNumero.Text = "2";
        }

        /// <summary>
        /// Botão que desenha um dado com o número 3.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cmd3_Click(object sender, EventArgs e)
        {
            ClsDiceGDI.DesenhaValorDado(this, 3, Color.Navy, CmdRollDice.Location.X + 25, CmdRollDice.Location.Y - 130, 12);
            LblNumero.Text = "3";
        }

        /// <summary>
        /// Botão que desenha um dado com o número 4.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cmd4_Click(object sender, EventArgs e)
        {
            ClsDiceGDI.DesenhaValorDado(this, 4, Color.Azure, CmdRollDice.Location.X + 25, CmdRollDice.Location.Y - 130, 12);
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
            ClsDiceGDI.DesenhaValorDado(this, 6, Color.RosyBrown, CmdRollDice.Location.X + 25, CmdRollDice.Location.Y - 130, 12);
            LblNumero.Text = "6";
        }

        /// <summary>
        /// Botão que desenha um dado o número 7 (não existe). Moldura + Número.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cmd7_Click(object sender, EventArgs e)
        {
            ClsDiceGDI.DesenhaDadoCompleto(this, 7, Color.Red, Color.Brown, CmdRollDice.Location.X + 25, CmdRollDice.Location.Y - 130, 12);
            LblNumero.Text = "7";
        }
    }
}
