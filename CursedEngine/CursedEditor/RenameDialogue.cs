using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursedEditor
{
    public partial class RenameDialogue : Form
    {
        private TreeNode n;
        private CursedCore.Level l;
        private CursedCore.Room r;
        public RenameDialogue()
        {
            InitializeComponent();
            this.Visible = true;
            this.Focus();
        }

        public RenameDialogue(TreeNode node)
        {
            InitializeComponent();
            this.Visible = true;
            this.Focus();
            n = node;
        }

        public RenameDialogue(CursedCore.Level level)
        {
            InitializeComponent();
            this.Visible = true;
            this.Focus();
            l = level;
        }

        public RenameDialogue(CursedCore.Room room)
        {
            InitializeComponent();
            this.Visible = true;
            this.Focus();
            r = room;
        }

        private void RenameDialogue_Load(object sender, EventArgs e)
        {
           
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            if (n != null)
                n.Text = NewNameText.Text;
            else if (l != null)
                l.name = NewNameText.Text;
            else if (r != null)
                r.name = NewNameText.Text;

            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
