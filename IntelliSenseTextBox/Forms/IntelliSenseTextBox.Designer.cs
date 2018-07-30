namespace IntelliSenseTextBox.Forms
{
    partial class IntelliSenseTextBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxSuggestions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxSuggestions
            // 
            this.lbxSuggestions.FormattingEnabled = true;
            this.lbxSuggestions.Location = new System.Drawing.Point(0, 0);
            this.lbxSuggestions.Name = "lbxSuggestions";
            this.lbxSuggestions.Size = new System.Drawing.Size(120, 200);
            this.lbxSuggestions.TabIndex = 0;
            this.lbxSuggestions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbxSuggestions_KeyDown);
            // 
            // IntelliSenseTextBox
            // 
            this.TextChanged += new System.EventHandler(this.IntelliSenseTextBox_TextChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IntelliSenseTextBox_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxSuggestions;
    }
}
