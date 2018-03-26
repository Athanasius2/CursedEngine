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
        private NewGame newGame;
        private Game game;
        CursedConsole cCons;
        public Form1()
        {
            InitializeComponent();
            cCons = new CursedConsole();
            cCons.init();
            game = new Game();
            
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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame = new NewGame();
            newGame.Show();
        }

        // TODO we need to implement a way to rename the tree node so that it will also be renamed in te game object
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        // TODO User should have a chance to rename node after it is created
        // TODO User should be able to change the order of the nodes 
        private void newLevelButton_Click(object sender, EventArgs e)
        {
            Level l = new Level("Sample Level");
            game.addLevel(l);
            gameMap.Nodes.Add(l.getName());
        }

        // TODO this is a pretty crappy way to add a new room.  clean this up later.
        private void newRoomButton_Click(object sender, EventArgs e)
        {
            Room r = new Room("Sample Room");
            TreeNode node = gameMap.SelectedNode;
            game.getLevel(node.Text).addRoom(r);
            node.Nodes.Add(r.getName());

            
        }
    }
}
