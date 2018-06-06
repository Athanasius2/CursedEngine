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
            roomText.KeyPress += new KeyPressEventHandler(roomText_KeyPress);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            
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

       
        // TODO User should have a chance to rename node after it is created
        // TODO User should be able to change the order of the nodes 
        // TODO User should recieve a message telling them if their name is not unique or empty
        private void newLevelButton_Click(object sender, EventArgs e)
        {
            string name = "";
            while (!Level.isUnique(name, game))
            {
                name = Prompt.RenameDialog("New Level", "Enter new level name");
                if (name == null)
                    return;
            }
            Level l = new Level(name);
            TreeNode node = new TreeNode();
            node.Text = l.name;
            game.addLevel(l);
            gameMap.Nodes.Add(node);
        }

        // TODO this is a pretty crappy way to add a new room.  clean this up later.
        private void newRoomButton_Click(object sender, EventArgs e)
        {
            if (gameMap.SelectedNode != null)
            {
                if (gameMap.SelectedNode.Level == 0)
                {
                    string name = "";
                    Level l = game.getLevel(gameMap.SelectedNode.Text);
                    while (!Room.isUnique(name, l))
                    {
                        name = Prompt.RenameDialog("New Room", "Enter new room name");
                        if (name == null)
                            return;
                    }
                    Room r = new Room(name);
                    l.addRoom(r);
                    TreeNode node = new TreeNode();
                    node.Text = r.name;
                    gameMap.SelectedNode.Nodes.Add(node);
                }
            }
        }

        private void newActorButton_Click(object sender, EventArgs e)
        {
            if (gameMap.SelectedNode != null)
            {
                if (gameMap.SelectedNode.Level == 1)
                {
                    string name = "";
                    Level l = game.getLevel(gameMap.SelectedNode.Parent.Text);
                    Room r = l.getRoom(gameMap.SelectedNode.Text);
                    while (!r.IsUniqueActor(name))
                    {
                        name = Prompt.RenameDialog("New Actor", "Enter new actor name");
                        if (name == null)
                            return;
                    }
                    Actor a = new Actor(name, new List<CursedCore.Action>());
                    r.addActor(a);
                    TreeNode node = new TreeNode();
                    node.Text = a.name;
                    gameMap.SelectedNode.Nodes.Add(node);
                }
            }
        }


        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addActionButton_Click(object sender, EventArgs e)
        {
            actionGridView.Rows.Add();
        }

        private void roomText_KeyPress(object sender, KeyPressEventArgs e)
        {
            TreeNode node = gameMap.SelectedNode;
            string room = node.Text;
            Room r = game.getLevel(node.Parent.Text).getRoom(room);
            r.text = roomText.Text;
        }

        private void gameMap_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            if (node != null)
            {
                switch (node.Level)
                {
                    case 0:
                        Level l = game.getLevel(node.Text);
                        break;
                    case 1:
                        Room r = game.getLevel(node.Parent.Text).getRoom(node.Text);
                        if (r.text != null)
                        {
                            roomText.Text = r.text;
                        }
                        else
                        {
                            roomText.Clear();
                        }
                        break;
                    case 2:
                        Actor a = game.getLevel(node.Parent.Parent.Text).getRoom(node.Parent.Text).getActor(node.Text);
                        break;
                }
            }
        }

        
    }
}
