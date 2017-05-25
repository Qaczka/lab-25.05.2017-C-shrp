namespace lab_25._05._2017_C_shrp
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
            this.adress = new System.Windows.Forms.TextBox();
            this.moj_port = new System.Windows.Forms.NumericUpDown();
            this.polacz = new System.Windows.Forms.Button();
            this.info_feed = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.moj_port)).BeginInit();
            this.SuspendLayout();
            // 
            // adress
            // 
            this.adress.Location = new System.Drawing.Point(12, 12);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(334, 22);
            this.adress.TabIndex = 0;
            this.adress.Text = "Adres";
            this.adress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // moj_port
            // 
            this.moj_port.Location = new System.Drawing.Point(364, 12);
            this.moj_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.moj_port.Name = "moj_port";
            this.moj_port.Size = new System.Drawing.Size(340, 22);
            this.moj_port.TabIndex = 1;
            this.moj_port.ValueChanged += new System.EventHandler(this.moj_port_ValueChanged);
            // 
            // polacz
            // 
            this.polacz.Location = new System.Drawing.Point(228, 446);
            this.polacz.Name = "polacz";
            this.polacz.Size = new System.Drawing.Size(254, 72);
            this.polacz.TabIndex = 2;
            this.polacz.Text = "button1";
            this.polacz.UseVisualStyleBackColor = true;
            this.polacz.Click += new System.EventHandler(this.polacz_Click);
            // 
            // info_feed
            // 
            this.info_feed.FormattingEnabled = true;
            this.info_feed.ItemHeight = 16;
            this.info_feed.Location = new System.Drawing.Point(12, 52);
            this.info_feed.Name = "info_feed";
            this.info_feed.Size = new System.Drawing.Size(692, 388);
            this.info_feed.TabIndex = 3;
            this.info_feed.SelectedIndexChanged += new System.EventHandler(this.info_feed_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 530);
            this.Controls.Add(this.info_feed);
            this.Controls.Add(this.polacz);
            this.Controls.Add(this.moj_port);
            this.Controls.Add(this.adress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moj_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.NumericUpDown moj_port;
        private System.Windows.Forms.Button polacz;
        private System.Windows.Forms.ListBox info_feed;
    }
}

