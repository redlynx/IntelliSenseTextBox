﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntelliSenseTextBox.Forms
{
    public partial class IntelliSenseTextBox : TextBox
    {
        public List<string> IntelliSenseItems { get; set; } = new List<string>();
        public int MaxListBoxHeight { get; set; } = 200;


        public IntelliSenseTextBox()
        {
            InitializeComponent();            
        }


        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }


        // this is responsible for populating, hiding, and showing the listbox underneath the textbox
        // the listbox will contain a subset of possible matches
        private void IntelliSenseTextBox_TextChanged(object sender, EventArgs e)
        {
            string w = GetWordAtPosition().ToLower();
            if (w.Length == 0 || IntelliSenseItems == null) return;
            var subset = IntelliSenseItems.Where(x => x.ToLower().Contains(w));

            if (subset.Count() == 0 || w.Length == 0)
            {
                lbxSuggestions.Hide();
            }
            else if (subset.Count() > 0)
            {
                FillSuggestions(subset);

                // make sure to be on top and appear on the caret position
                Point pt = GetPositionFromCharIndex(SelectionStart > 0 ? SelectionStart - 1 : 0);
                pt.Y += this.Location.Y;
                pt.X += this.Left;
                // multi-line textboxes behave differently
                if (this.Multiline)
                {
                    pt.Y -= this.Height - this.FontHeight - 5;
                }
                lbxSuggestions.Location = pt;
                // get rid of the top border (i.e. overlap with textbox bottom border)
                lbxSuggestions.Top += this.Height - 1;
                this.Parent.Controls.Add(lbxSuggestions);
                
                // avoid scrolling - resize listbox
                lbxSuggestions.Height = MaxListBoxHeight;
                var reqHeight = lbxSuggestions.ItemHeight * lbxSuggestions.Items.Count;
                if (reqHeight < MaxListBoxHeight)
                {
                    lbxSuggestions.Height = reqHeight + lbxSuggestions.ItemHeight;
                }

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
                if (lbxSuggestions.Visible && lbxSuggestions.Items.Count > 0)
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
                InsertWordAtPosition(lbxSuggestions.SelectedItem.ToString());
                lbxSuggestions.Hide();
                this.Focus();
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


        private string GetWordAtPosition()
        {
            int pos = this.SelectionStart;
            var textPart = this.Text.Substring(0, pos);
            var s = Regex.Split(textPart, @"[^a-zA-Z0-9_'\{]");
            if (s.Length > 0 && !Text.EndsWith(" "))
            {
                return s.Last();
            }
            return "";
        }


        private void InsertWordAtPosition(string s)
        {
            string w = GetWordAtPosition();

            int i = this.SelectionStart;
            Text = Text.Remove(i - w.Length, w.Length);
            Text = Text.Insert(i - w.Length, s);
            // position the cursor right after the word
            this.SelectionStart = i - w.Length + s.Length;
        }
    }
}
