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
            this.txtSuggestions = new System.Windows.Forms.TextBox();
            this.intelliSenseTextBox2 = new IntelliSenseTextBox.Forms.IntelliSenseTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.intelliSenseTextBox1 = new IntelliSenseTextBox.Forms.IntelliSenseTextBox();
            this.intelliSenseTextBox3 = new IntelliSenseTextBox.Forms.IntelliSenseTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSuggestions
            // 
            this.txtSuggestions.Location = new System.Drawing.Point(12, 363);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.intelliSenseTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 62);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // intelliSenseTextBox1
            // 
            this.intelliSenseTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intelliSenseTextBox1.IntelliSenseItems = null;
            this.intelliSenseTextBox1.Location = new System.Drawing.Point(6, 19);
            this.intelliSenseTextBox1.MaxListBoxHeight = 200;
            this.intelliSenseTextBox1.Name = "intelliSenseTextBox1";
            this.intelliSenseTextBox1.Size = new System.Drawing.Size(418, 26);
            this.intelliSenseTextBox1.TabIndex = 3;
            // 
            // intelliSenseTextBox3
            // 
            this.intelliSenseTextBox3.IntelliSenseItems = ((System.Collections.Generic.List<string>)(resources.GetObject("intelliSenseTextBox3.IntelliSenseItems")));
            this.intelliSenseTextBox3.Location = new System.Drawing.Point(12, 270);
            this.intelliSenseTextBox3.MaxListBoxHeight = 200;
            this.intelliSenseTextBox3.Name = "intelliSenseTextBox3";
            this.intelliSenseTextBox3.Size = new System.Drawing.Size(437, 20);
            this.intelliSenseTextBox3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 559);
            this.Controls.Add(this.intelliSenseTextBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.intelliSenseTextBox2);
            this.Controls.Add(this.txtSuggestions);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSuggestions;
        private Forms.IntelliSenseTextBox intelliSenseTextBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Forms.IntelliSenseTextBox intelliSenseTextBox1;
        private Forms.IntelliSenseTextBox intelliSenseTextBox3;
    }
}

