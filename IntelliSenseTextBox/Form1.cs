using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntelliSenseTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var items = txtSuggestions.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            var sorted = items.ToList();
            sorted.Sort();
            intelliSenseTextBox1.IntelliSenseItems = sorted;
        }
    }
}
