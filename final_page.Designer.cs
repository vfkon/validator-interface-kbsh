namespace WindowsFormsApp2
{
    partial class final_page
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
            this.label_thankyou = new System.Windows.Forms.Label();
            this.button_back_final_page = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_thankyou
            // 
            this.label_thankyou.AutoSize = true;
            this.label_thankyou.BackColor = System.Drawing.Color.Transparent;
            this.label_thankyou.Font = new System.Drawing.Font("FSRAILWAYTT Bold", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label_thankyou.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.label_thankyou.Location = new System.Drawing.Point(186, 65);
            this.label_thankyou.Name = "label_thankyou";
            this.label_thankyou.Size = new System.Drawing.Size(457, 45);
            this.label_thankyou.TabIndex = 10;
            this.label_thankyou.Text = "Спасибо за покупку!";
            this.label_thankyou.Visible = false;
            this.label_thankyou.Click += new System.EventHandler(this.label_thankyou_Click);
            // 
            // button_back_final_page
            // 
            this.button_back_final_page.BackColor = System.Drawing.Color.Transparent;
            this.button_back_final_page.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._1PPwF___mir;
            this.button_back_final_page.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_back_final_page.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_back_final_page.FlatAppearance.BorderSize = 0;
            this.button_back_final_page.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back_final_page.Font = new System.Drawing.Font("FSRAILWAYTT Bold", 21.75F, System.Drawing.FontStyle.Italic);
            this.button_back_final_page.ForeColor = System.Drawing.Color.White;
            this.button_back_final_page.Location = new System.Drawing.Point(12, 385);
            this.button_back_final_page.Name = "button_back_final_page";
            this.button_back_final_page.Size = new System.Drawing.Size(201, 53);
            this.button_back_final_page.TabIndex = 56;
            this.button_back_final_page.Text = "Завершить";
            this.button_back_final_page.UseVisualStyleBackColor = false;
            this.button_back_final_page.Click += new System.EventHandler(this.button_back_final_page_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.RZD_logo_p_1600;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(573, 325);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 113);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // final_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.scale_1200;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_back_final_page);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_thankyou);
            this.DoubleBuffered = true;
            this.Name = "final_page";
            this.Text = "final_page";
            this.Click += new System.EventHandler(this.final_page_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_thankyou;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_back_final_page;
    }
}