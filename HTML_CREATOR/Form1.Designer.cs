namespace HTML_CREATOR
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Toevoegen = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.buttonOpslaan = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Links = new System.Windows.Forms.Button();
            this.Rechts = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Op pagina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Items";
            // 
            // Toevoegen
            // 
            this.Toevoegen.Enabled = false;
            this.Toevoegen.Location = new System.Drawing.Point(26, 428);
            this.Toevoegen.Name = "Toevoegen";
            this.Toevoegen.Size = new System.Drawing.Size(139, 30);
            this.Toevoegen.TabIndex = 22;
            this.Toevoegen.Text = "Item Toevoegen";
            this.Toevoegen.UseVisualStyleBackColor = true;
            this.Toevoegen.Click += new System.EventHandler(this.Toevoegen_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(236, 106);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(138, 238);
            this.listBox2.TabIndex = 21;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(510, 45);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(483, 462);
            this.webBrowser1.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 401);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Voer een titel voor uw HTML-pagina:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(26, 50);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(193, 20);
            this.textBoxTitle.TabIndex = 14;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(26, 106);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(139, 238);
            this.listBox1.TabIndex = 15;
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Location = new System.Drawing.Point(26, 374);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(139, 20);
            this.textBoxLabel.TabIndex = 17;
            this.textBoxLabel.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonOpslaan
            // 
            this.buttonOpslaan.Enabled = false;
            this.buttonOpslaan.Location = new System.Drawing.Point(40, 475);
            this.buttonOpslaan.Name = "buttonOpslaan";
            this.buttonOpslaan.Size = new System.Drawing.Size(108, 42);
            this.buttonOpslaan.TabIndex = 16;
            this.buttonOpslaan.Text = "Opslaan";
            this.buttonOpslaan.UseVisualStyleBackColor = true;
            this.buttonOpslaan.Click += new System.EventHandler(this.button1_Click);
            // 
            // Min
            // 
            this.Min.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Min.Image = global::HTML_CREATOR.Properties.Resources.Min;
            this.Min.Location = new System.Drawing.Point(172, 284);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(57, 49);
            this.Min.TabIndex = 27;
            this.Min.UseVisualStyleBackColor = true;
            this.Min.Click += new System.EventHandler(this.Min_Click);
            // 
            // Plus
            // 
            this.Plus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plus.Image = global::HTML_CREATOR.Properties.Resources.Add;
            this.Plus.Location = new System.Drawing.Point(172, 229);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(57, 49);
            this.Plus.TabIndex = 26;
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Links
            // 
            this.Links.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Links.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Links.Image = global::HTML_CREATOR.Properties.Resources.Left;
            this.Links.Location = new System.Drawing.Point(172, 171);
            this.Links.Name = "Links";
            this.Links.Size = new System.Drawing.Size(57, 49);
            this.Links.TabIndex = 25;
            this.Links.UseVisualStyleBackColor = true;
            this.Links.Click += new System.EventHandler(this.Links_Click);
            // 
            // Rechts
            // 
            this.Rechts.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Rechts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rechts.Image = global::HTML_CREATOR.Properties.Resources.Right;
            this.Rechts.Location = new System.Drawing.Point(172, 117);
            this.Rechts.Name = "Rechts";
            this.Rechts.Size = new System.Drawing.Size(57, 49);
            this.Rechts.TabIndex = 19;
            this.Rechts.UseVisualStyleBackColor = true;
            this.Rechts.Click += new System.EventHandler(this.Rechts_Click);
            // 
            // Up
            // 
            this.Up.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Up.Image = global::HTML_CREATOR.Properties.Resources.Up2;
            this.Up.Location = new System.Drawing.Point(377, 114);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(37, 60);
            this.Up.TabIndex = 28;
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.UP_Click);
            // 
            // Down
            // 
            this.Down.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Down.Image = global::HTML_CREATOR.Properties.Resources.Down;
            this.Down.Location = new System.Drawing.Point(377, 177);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(37, 60);
            this.Down.TabIndex = 29;
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nieuw item:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1021, 545);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Links);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Toevoegen);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rechts);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.buttonOpslaan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "HTML_CREATOR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Toevoegen;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Rechts;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.Button buttonOpslaan;
        private System.Windows.Forms.Button Links;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Label label4;
    }
}

