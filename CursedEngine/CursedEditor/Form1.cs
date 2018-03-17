using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursedCore;

namespace CursedEditor
{
    public partial class Form1 : Form
    {
        CursedConsole cCons;
        public Form1()
        {
            InitializeComponent();
            cCons = new CursedConsole();
            cCons.init();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void ConsolePanel_Paint(object sender, PaintEventArgs e)
        {
            BufferedGraphicsContext context;
            BufferedGraphics buffer;
            context = BufferedGraphicsManager.Current;
            System.Drawing.Graphics formGraphics;
            formGraphics = ConsolePanel.CreateGraphics();
            buffer = context.Allocate(formGraphics, ConsolePanel.DisplayRectangle);
            cCons.draw(0, 0, buffer.Graphics);
            //cCons.draw(0, 0, formGraphics);
            buffer.Render(formGraphics);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Process.Start("..\\..\\..\\Cursed\\bin\\Debug\\Cursed.exe");
        }
    }
}
