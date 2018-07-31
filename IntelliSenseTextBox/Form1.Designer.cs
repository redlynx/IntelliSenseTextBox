namespace IntelliSenseTextBox
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.intelliSenseTextBox1 = new IntelliSenseTextBox.Forms.IntelliSenseTextBox();
            this.txtSuggestions = new System.Windows.Forms.TextBox();
            this.intelliSenseTextBox2 = new IntelliSenseTextBox.Forms.IntelliSenseTextBox();
            this.SuspendLayout();
            // 
            // intelliSenseTextBox1
            // 
            this.intelliSenseTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intelliSenseTextBox1.IntelliSenseItems = null;
            this.intelliSenseTextBox1.Location = new System.Drawing.Point(12, 220);
            this.intelliSenseTextBox1.MaxListBoxHeight = 200;
            this.intelliSenseTextBox1.Name = "intelliSenseTextBox1";
            this.intelliSenseTextBox1.Size = new System.Drawing.Size(437, 26);
            this.intelliSenseTextBox1.TabIndex = 2;
            // 
            // txtSuggestions
            // 
            this.txtSuggestions.Location = new System.Drawing.Point(12, 292);
            this.txtSuggestions.Multiline = true;
            this.txtSuggestions.Name = "txtSuggestions";
            this.txtSuggestions.Size = new System.Drawing.Size(437, 89);
            this.txtSuggestions.TabIndex = 3;
            this.txtSuggestions.Text = "Apple\r\nBanana\r\nBlueberries\r\nCoconut\r\nLemon\r\nMango\r\nMandarin\r\nMelon\r\n{$UserName}\r\n" +
    "{InvoiceNumber}\r\n{InvoiceDate}\r\n{OrderNumber}\r\n{TotalAmount}\r\n{$StationId}";
            this.txtSuggestions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // intelliSenseTextBox2
            // 
            this.intelliSenseTextBox2.IntelliSenseItems = ((System.Collections.Generic.List<string>)(resources.GetObject("intelliSenseTextBox2.IntelliSenseItems")));
            this.intelliSenseTextBox2.Location = new System.Drawing.Point(12, 44);
            this.intelliSenseTextBox2.MaxListBoxHeight = 200;
            this.intelliSenseTextBox2.Multiline = true;
            this.intelliSenseTextBox2.Name = "intelliSenseTextBox2";
            this.intelliSenseTextBox2.Size = new System.Drawing.Size(437, 127);
            this.intelliSenseTextBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 393);
            this.Controls.Add(this.intelliSenseTextBox2);
            this.Controls.Add(this.txtSuggestions);
            this.Controls.Add(this.intelliSenseTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Forms.IntelliSenseTextBox intelliSenseTextBox1;
        private System.Windows.Forms.TextBox txtSuggestions;
        private Forms.IntelliSenseTextBox intelliSenseTextBox2;
    }
}

