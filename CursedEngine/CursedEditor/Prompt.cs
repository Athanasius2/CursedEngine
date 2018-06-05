using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursedEditor
{
    public static class Prompt
    {

        private static bool cancelled { get; set; }

        public static string RenameDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 300;
            prompt.Height = 150;
            prompt.Text = caption;
            Label textLabel = new Label() { Left = 10, Top = 20, Text = text };
            TextBox inputBox = new TextBox() { Left = 10, Top = 50, Width = 200 };
            Button confirmation = new Button() { Text = "Ok", Left = 10, Width = 75, Top = 70 };
            Button cancellation = new Button() { Text = "Cancel", Left = confirmation.Location.X + confirmation.Width + 10, Width = confirmation.Width, Top = confirmation.Location.Y };
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancellation;
     
            
            confirmation.Click += (sender, e) => { prompt.Close(); cancelled = false; };
            cancellation.Click += (sender, e) => { prompt.Close(); cancelled = true; };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancellation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.ShowDialog();
            prompt.Focus();
            inputBox.Focus();
            if (!cancelled)
                return inputBox.Text;
            else return null;
        }



       

    }
}
