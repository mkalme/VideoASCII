namespace VideoASCII
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Browse1 = new System.Windows.Forms.Button();
            this.Browse2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Preview = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.View = new System.Windows.Forms.Button();
            this.Convert = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.OpenExisting = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BrowserText3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Options = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Browse1
            // 
            this.Browse1.Location = new System.Drawing.Point(12, 28);
            this.Browse1.Name = "Browse1";
            this.Browse1.Size = new System.Drawing.Size(75, 23);
            this.Browse1.TabIndex = 0;
            this.Browse1.Text = "Browse";
            this.Browse1.UseVisualStyleBackColor = true;
            this.Browse1.Click += new System.EventHandler(this.browser1);
            // 
            // Browse2
            // 
            this.Browse2.Location = new System.Drawing.Point(12, 75);
            this.Browse2.Name = "Browse2";
            this.Browse2.Size = new System.Drawing.Size(75, 23);
            this.Browse2.TabIndex = 1;
            this.Browse2.Text = "Browse";
            this.Browse2.UseVisualStyleBackColor = true;
            this.Browse2.Click += new System.EventHandler(this.browser2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select the video you want to convert.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select the folder you want to save the new video.";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(93, 31);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(613, 20);
            this.TextBox1.TabIndex = 4;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(93, 78);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(612, 20);
            this.TextBox2.TabIndex = 5;
            this.TextBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // Preview
            // 
            this.Preview.BackColor = System.Drawing.Color.AliceBlue;
            this.Preview.Enabled = false;
            this.Preview.Location = new System.Drawing.Point(12, 141);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(693, 247);
            this.Preview.TabIndex = 6;
            this.Preview.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Preview";
            // 
            // View
            // 
            this.View.Enabled = false;
            this.View.Location = new System.Drawing.Point(618, 110);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(85, 25);
            this.View.TabIndex = 8;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.ViewClick);
            // 
            // Convert
            // 
            this.Convert.Enabled = false;
            this.Convert.Location = new System.Drawing.Point(618, 413);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(85, 25);
            this.Convert.TabIndex = 9;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.ConvertClick);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(527, 413);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(85, 25);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.CancelClick);
            // 
            // OpenExisting
            // 
            this.OpenExisting.Location = new System.Drawing.Point(12, 413);
            this.OpenExisting.Name = "OpenExisting";
            this.OpenExisting.Size = new System.Drawing.Size(99, 25);
            this.OpenExisting.TabIndex = 11;
            this.OpenExisting.Text = "Open";
            this.OpenExisting.UseVisualStyleBackColor = true;
            this.OpenExisting.Click += new System.EventHandler(this.OpexExistingClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BrowserText3
            // 
            this.BrowserText3.AutoSize = true;
            this.BrowserText3.Location = new System.Drawing.Point(117, 419);
            this.BrowserText3.Name = "BrowserText3";
            this.BrowserText3.Size = new System.Drawing.Size(0, 13);
            this.BrowserText3.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Options
            // 
            this.Options.Enabled = false;
            this.Options.Location = new System.Drawing.Point(12, 102);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(75, 20);
            this.Options.TabIndex = 13;
            this.Options.Text = "Options";
            this.Options.UseVisualStyleBackColor = true;
            this.Options.Click += new System.EventHandler(this.Options_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.BrowserText3);
            this.Controls.Add(this.OpenExisting);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.View);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Preview);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Browse2);
            this.Controls.Add(this.Browse1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Browse1;
        private System.Windows.Forms.Button Browse2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.RichTextBox Preview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OpenExisting;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.Label BrowserText3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Options;
    }
}

