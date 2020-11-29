namespace WindowsFormsApp2
{
    partial class lgoti
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_back_lgoti = new System.Windows.Forms.Button();
            this.button_lgoti_no = new System.Windows.Forms.Button();
            this.button_lgoti_yes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("FSRAILWAYTT Bold", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(80, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(642, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Есть ли у вас какие-либо льготы?";
            // 
            // button_back_lgoti
            // 
            this.button_back_lgoti.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._1PPwF___mir;
            this.button_back_lgoti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_back_lgoti.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_back_lgoti.FlatAppearance.BorderSize = 0;
            this.button_back_lgoti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back_lgoti.Font = new System.Drawing.Font("FSRAILWAYTT Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_back_lgoti.ForeColor = System.Drawing.Color.White;
            this.button_back_lgoti.Location = new System.Drawing.Point(12, 385);
            this.button_back_lgoti.Name = "button_back_lgoti";
            this.button_back_lgoti.Size = new System.Drawing.Size(171, 53);
            this.button_back_lgoti.TabIndex = 54;
            this.button_back_lgoti.Text = "Назад";
            this.button_back_lgoti.UseVisualStyleBackColor = true;
            this.button_back_lgoti.Click += new System.EventHandler(this.button_back_lgoti_Click);
            // 
            // button_lgoti_no
            // 
            this.button_lgoti_no.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._1PPwF;
            this.button_lgoti_no.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_lgoti_no.FlatAppearance.BorderSize = 0;
            this.button_lgoti_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_lgoti_no.Font = new System.Drawing.Font("FSRAILWAYTT Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_lgoti_no.ForeColor = System.Drawing.Color.White;
            this.button_lgoti_no.Location = new System.Drawing.Point(397, 164);
            this.button_lgoti_no.Name = "button_lgoti_no";
            this.button_lgoti_no.Size = new System.Drawing.Size(391, 83);
            this.button_lgoti_no.TabIndex = 8;
            this.button_lgoti_no.Text = "Нет";
            this.button_lgoti_no.UseVisualStyleBackColor = true;
            this.button_lgoti_no.Click += new System.EventHandler(this.button_lgoti_no_Click);
            // 
            // button_lgoti_yes
            // 
            this.button_lgoti_yes.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._1PPwF___mir;
            this.button_lgoti_yes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_lgoti_yes.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_lgoti_yes.FlatAppearance.BorderSize = 0;
            this.button_lgoti_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_lgoti_yes.Font = new System.Drawing.Font("FSRAILWAYTT Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_lgoti_yes.ForeColor = System.Drawing.Color.White;
            this.button_lgoti_yes.Location = new System.Drawing.Point(12, 164);
            this.button_lgoti_yes.Name = "button_lgoti_yes";
            this.button_lgoti_yes.Size = new System.Drawing.Size(379, 83);
            this.button_lgoti_yes.TabIndex = 7;
            this.button_lgoti_yes.Text = "Да";
            this.button_lgoti_yes.UseVisualStyleBackColor = true;
            this.button_lgoti_yes.Click += new System.EventHandler(this.button_lgoti_yes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.RZD_logo_p_1600;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(573, 325);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 113);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lgoti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_back_lgoti);
            this.Controls.Add(this.button_lgoti_no);
            this.Controls.Add(this.button_lgoti_yes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "lgoti";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_lgoti_no;
        private System.Windows.Forms.Button button_lgoti_yes;
        private System.Windows.Forms.Button button_back_lgoti;
    }
}