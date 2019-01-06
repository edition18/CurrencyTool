namespace CurrTracker
{
    partial class MainWindow
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
            this.exRateBox = new System.Windows.Forms.TextBox();
            this.usdinValues = new System.Windows.Forms.TextBox();
            this.outputValues = new System.Windows.Forms.TextBox();
            this.inputValues = new System.Windows.Forms.TextBox();
            this.usdoutValues = new System.Windows.Forms.TextBox();
            this.CurrencyDrop = new System.Windows.Forms.ComboBox();
            this.pairBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exRateBox
            // 
            this.exRateBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.exRateBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.exRateBox.Location = new System.Drawing.Point(620, 3);
            this.exRateBox.Name = "exRateBox";
            this.exRateBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.exRateBox.Size = new System.Drawing.Size(171, 20);
            this.exRateBox.TabIndex = 0;
            this.exRateBox.Text = "1";
            this.exRateBox.TextChanged += new System.EventHandler(this.exRateBox_TextChanged);
            // 
            // usdinValues
            // 
            this.usdinValues.BackColor = System.Drawing.Color.White;
            this.usdinValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usdinValues.ForeColor = System.Drawing.SystemColors.WindowText;
            this.usdinValues.Location = new System.Drawing.Point(85, 106);
            this.usdinValues.Name = "usdinValues";
            this.usdinValues.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.usdinValues.Size = new System.Drawing.Size(250, 29);
            this.usdinValues.TabIndex = 1;
            this.usdinValues.Text = "0";
            this.usdinValues.TextChanged += new System.EventHandler(this.usdinValues_TextChanged);
            // 
            // outputValues
            // 
            this.outputValues.BackColor = System.Drawing.Color.LightGray;
            this.outputValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputValues.ForeColor = System.Drawing.SystemColors.WindowText;
            this.outputValues.Location = new System.Drawing.Point(461, 106);
            this.outputValues.Name = "outputValues";
            this.outputValues.ReadOnly = true;
            this.outputValues.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.outputValues.Size = new System.Drawing.Size(250, 29);
            this.outputValues.TabIndex = 2;
            this.outputValues.Text = "outputValues";
            // 
            // inputValues
            // 
            this.inputValues.BackColor = System.Drawing.Color.White;
            this.inputValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputValues.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inputValues.Location = new System.Drawing.Point(85, 245);
            this.inputValues.Name = "inputValues";
            this.inputValues.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.inputValues.Size = new System.Drawing.Size(250, 29);
            this.inputValues.TabIndex = 3;
            this.inputValues.Text = "0";
            this.inputValues.TextChanged += new System.EventHandler(this.inputValues_TextChanged);
            // 
            // usdoutValues
            // 
            this.usdoutValues.BackColor = System.Drawing.Color.LightGray;
            this.usdoutValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usdoutValues.ForeColor = System.Drawing.SystemColors.WindowText;
            this.usdoutValues.Location = new System.Drawing.Point(461, 245);
            this.usdoutValues.Name = "usdoutValues";
            this.usdoutValues.ReadOnly = true;
            this.usdoutValues.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.usdoutValues.Size = new System.Drawing.Size(250, 29);
            this.usdoutValues.TabIndex = 4;
            this.usdoutValues.Text = "usdoutValues";
            // 
            // CurrencyDrop
            // 
            this.CurrencyDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrencyDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyDrop.FormattingEnabled = true;
            this.CurrencyDrop.Location = new System.Drawing.Point(-1, -2);
            this.CurrencyDrop.Name = "CurrencyDrop";
            this.CurrencyDrop.Size = new System.Drawing.Size(232, 28);
            this.CurrencyDrop.TabIndex = 5;
            this.CurrencyDrop.SelectedIndexChanged += new System.EventHandler(this.CurrencyDrop_SelectedIndexChanged);
            // 
            // pairBox
            // 
            this.pairBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pairBox.ForeColor = System.Drawing.Color.Olive;
            this.pairBox.Location = new System.Drawing.Point(320, 3);
            this.pairBox.Name = "pairBox";
            this.pairBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.pairBox.Size = new System.Drawing.Size(171, 20);
            this.pairBox.TabIndex = 6;
            this.pairBox.Text = "pairBox";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "USD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "USD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "???";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 400);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pairBox);
            this.Controls.Add(this.CurrencyDrop);
            this.Controls.Add(this.usdoutValues);
            this.Controls.Add(this.inputValues);
            this.Controls.Add(this.outputValues);
            this.Controls.Add(this.usdinValues);
            this.Controls.Add(this.exRateBox);
            this.Name = "MainWindow";
            this.Text = "CurrTrackerMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox exRateBox;
        private System.Windows.Forms.TextBox usdinValues;
        private System.Windows.Forms.TextBox outputValues;
        private System.Windows.Forms.TextBox inputValues;
        public System.Windows.Forms.TextBox usdoutValues;
        private System.Windows.Forms.ComboBox CurrencyDrop;
        private System.Windows.Forms.TextBox pairBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

