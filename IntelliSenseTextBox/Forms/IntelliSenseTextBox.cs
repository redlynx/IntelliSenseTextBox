using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntelliSenseTextBox.Forms
{
    public partial class IntelliSenseTextBox : TextBox
    {

        public List<string> IntelliSenseItems { get; set; }
        public List<IntelliSenseItem> IntelliSenseItems2 { get; set; } = new List<IntelliSenseItem>();

        public IntelliSenseTextBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }


        // this is responsible for hiding and showing the listbox underneath the textbox
        // the listbox will contain a subset of possible matches
        private void IntelliSenseTextBox_TextChanged(object sender, EventArgs e)
        {
            // subset the items
            string lastWord = GetLastWord().ToLower();
            var subset = IntelliSenseItems.Where(x => x.ToLower().StartsWith(lastWord));
            if (subset.Count() == 0 || lastWord.Length == 0)
            {
                lbxSuggestions.Hide();
            }
            else if (subset.Count() > 0)
            {
                FillSuggestions(subset);
                // make sure to be on top and appear on the caret position
                Point pt = GetPositionFromCharIndex(SelectionStart > 0 ? SelectionStart - 1 : 0);
                pt.Y = Top;
                lbxSuggestions.Location = pt;
                lbxSuggestions.Top += this.Height - 1;
                this.Parent.Controls.Add(lbxSuggestions);
                lbxSuggestions.Show();
                lbxSuggestions.BringToFront();
            }

        }


        // this will handle keycodes in the main textbox. 
        // pressing the arrow down or enter will focus the listbox
        // pressing esc will hide the listbox
        private void IntelliSenseTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                if (lbxSuggestions.Visible)
                {
                    lbxSuggestions.Focus();
                    lbxSuggestions.SelectedItem = lbxSuggestions.Items[0];
                }
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                lbxSuggestions.Hide();
                this.Focus();
                e.Handled = true;
            }
        }

        
        // this will handle keycodes in the listbox
        // in case there's an item selected, enter will close the listbox and copy it to the textbox
        // this will always append an item at the end (after removing the last wordpart)
        private void lbxSuggestions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && lbxSuggestions.SelectedItem != null)
            {
                ReplaceLastWord(lbxSuggestions.SelectedItem.ToString());
                lbxSuggestions.Hide();
                SelectionStart = Text.Length;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                lbxSuggestions.Hide();
                this.Focus();
            }
        }


        private void FillSuggestions(IEnumerable<string> s)
        {
            lbxSuggestions.Items.Clear();
            s.ToList().ForEach(x => lbxSuggestions.Items.Add(x));
        }


        private string GetLastWord()
        {
            // gets the last word, separated by blanks
            var s = Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (s.Length > 0 && !Text.EndsWith(" "))
            {
                return s.Last();
            }
            return "";
        }


        private void ReplaceLastWord(string s)
        {
            int i = Text.LastIndexOf(GetLastWord());
            Text = Text.Remove(i);
            Text += s;
        }
    }

    public class IntelliSenseItem
    {
        public Icon Icon { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }


}
