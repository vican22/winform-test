using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak02
{
    public partial class Form1 : Form
    {
        private const int WH = 20;
        private const int BROJ_PANELA = 200;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < BROJ_PANELA; i++)
            {
                flp.Controls.Add(GetPanel());
            }
        }

        private Panel GetPanel()
        {
            Panel pnl = new Panel();
            pnl.Size = new Size(WH, WH);
            pnl.ContextMenuStrip = opcijeDesnogKlika;
            pnl.BorderStyle = BorderStyle.FixedSingle;

            return pnl;
        }

        private void odaberiBojuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel oznacenaPanela = opcijeDesnogKlika.SourceControl as Panel;

            if(teskeBoje.ShowDialog() == DialogResult.OK)
            {
                oznacenaPanela.BackColor = teskeBoje.Color;
            }
        }

        private void poništiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel oznacenaPanela = opcijeDesnogKlika.SourceControl as Panel;
            oznacenaPanela.BackColor = Color.Transparent;
        }
    }
}
