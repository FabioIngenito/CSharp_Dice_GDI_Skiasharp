using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clsDiceSkiasharp
{
    public partial class UcDiceSkia : UserControl
    {
        public UcDiceSkia()
        {
            InitializeComponent();
        }

        private void CmdRollDiceSkiasharp_Click(object sender, EventArgs e)
        {
            string strNum = ClsSorteio.Sorteia();

            ClsDiceSkia.DesenhaDadoCompleto(ref pcbDiceSkiasharp, Convert.ToByte(strNum), "#000000", "#FF0000", CmdRollDiceSkiasharp.Location.X + 25, CmdRollDiceSkiasharp.Location.Y - 130, 12);
            LblNumeroSkia.Text = strNum;
        }

        private void Cmd0Skia_Click(object sender, EventArgs e)
        {
            ClsDiceSkia.DesenhaDadoCompleto(ref pcbDiceSkiasharp, 0, ClsDiceSkia.ColorToHex(Color.Red), ClsDiceSkia.ColorToHex(Color.Chocolate), CmdRollDiceSkiasharp.Location.X + 25, CmdRollDiceSkiasharp.Location.Y - 130, 12);
            LblNumeroSkia.Text = "0";
        }

        private void Cmd1Skia_Click(object sender, EventArgs e)
        {
            ClsDiceSkia.DesenhaDadoCompleto(ref pcbDiceSkiasharp, 1, ClsDiceSkia.ColorToHex(Color.DarkMagenta), "#FF1000", CmdRollDiceSkiasharp.Location.X + 25, CmdRollDiceSkiasharp.Location.Y - 130, 12);
            LblNumeroSkia.Text = "1";
        }

        private void Cmd2Skia_Click(object sender, EventArgs e)
        {
            ClsDiceSkia.DesenhaDadoCompleto(ref pcbDiceSkiasharp, 2, "#990000", "#FF99FF", CmdRollDiceSkiasharp.Location.X + 25, CmdRollDiceSkiasharp.Location.Y - 130, 12);
            LblNumeroSkia.Text = "2";
        }

        private void Cmd3Skia_Click(object sender, EventArgs e)
        {
            ClsDiceSkia.DesenhaDadoCompleto(ref pcbDiceSkiasharp, 3, ClsDiceSkia.ColorToHex(Color.CadetBlue), ClsDiceSkia.ColorToHex(Color.DarkOliveGreen), CmdRollDiceSkiasharp.Location.X + 25, CmdRollDiceSkiasharp.Location.Y - 130, 12);
            LblNumeroSkia.Text = "3";
        }

        private void Cmd4Skia_Click(object sender, EventArgs e)
        {
            ClsDiceSkia.DesenhaDadoCompleto(ref pcbDiceSkiasharp, 4, ClsDiceSkia.ColorToHex(Color.DarkSeaGreen), ClsDiceSkia.ColorToHex(Color.DarkRed), CmdRollDiceSkiasharp.Location.X + 25, CmdRollDiceSkiasharp.Location.Y - 130, 12);
            LblNumeroSkia.Text = "4";
        }

        private void Cmd5Skia_Click(object sender, EventArgs e)
        {
            ClsDiceSkia.DesenhaDadoCompleto(ref pcbDiceSkiasharp, 5, ClsDiceSkia.ColorToHex(Color.Firebrick), ClsDiceSkia.ColorToHex(Color.DodgerBlue), CmdRollDiceSkiasharp.Location.X + 25, CmdRollDiceSkiasharp.Location.Y - 130, 12);
            LblNumeroSkia.Text = "5";
        }

        private void Cmd6Skia_Click(object sender, EventArgs e)
        {
            ClsDiceSkia.DesenhaDadoCompleto(ref pcbDiceSkiasharp, 6, ClsDiceSkia.ColorToHex(Color.DimGray), ClsDiceSkia.ColorToHex(Color.DeepPink), CmdRollDiceSkiasharp.Location.X + 25, CmdRollDiceSkiasharp.Location.Y - 130, 12);
            LblNumeroSkia.Text = "6";
        }

        private void Cmd7Skia_Click(object sender, EventArgs e)
        {
            ClsDiceSkia.DesenhaDadoCompleto(ref pcbDiceSkiasharp, 7, ClsDiceSkia.ColorToHex(Color.IndianRed), ClsDiceSkia.ColorToHex(Color.DarkSlateGray), CmdRollDiceSkiasharp.Location.X + 25, CmdRollDiceSkiasharp.Location.Y - 130, 12);
            LblNumeroSkia.Text = "7";
        }
    }
}
