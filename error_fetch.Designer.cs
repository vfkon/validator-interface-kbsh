namespace WindowsFormsApp2
{
    partial class error_fetch
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
            this.button_back_lgoti = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_back_lgoti
            // 
            this.button_back_lgoti.BackColor = System.Drawing.Color.Transparent;
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
            this.button_back_lgoti.TabIndex = 55;
            this.button_back_lgoti.Text = "Назад";
            this.button_back_lgoti.UseVisualStyleBackColor = false;
            this.button_back_lgoti.Click += new System.EventHandler(this.button_back_lgoti_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("FSRAILWAYTT Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.label1.Location = new System.Drawing.Point(12, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(777, 34);
            this.label1.TabIndex = 56;
            this.label1.Text = "Произошла ошибка при загрузке списка станций";
            // 
            // error_fetch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.scale_1200;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_back_lgoti);
            this.DoubleBuffered = true;
            this.Name = "error_fetch";
            this.Text = "error_fetch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_back_lgoti;
        private System.Windows.Forms.Label label1;
    }
}