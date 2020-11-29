namespace WindowsFormsApp2
{
    partial class continue_dialog
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
            this.button_back_lgoti = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_string = new System.Windows.Forms.Label();
            this.timeout_timer = new System.Windows.Forms.Timer(this.components);
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
            this.button_back_lgoti.Location = new System.Drawing.Point(3, 96);
            this.button_back_lgoti.Name = "button_back_lgoti";
            this.button_back_lgoti.Size = new System.Drawing.Size(171, 53);
            this.button_back_lgoti.TabIndex = 56;
            this.button_back_lgoti.Text = "Нет";
            this.button_back_lgoti.UseVisualStyleBackColor = false;
            this.button_back_lgoti.Click += new System.EventHandler(this.button_back_lgoti_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._1PPwF;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("FSRAILWAYTT Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(201, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 53);
            this.button1.TabIndex = 57;
            this.button1.Text = "Да";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("FSRAILWAYTT Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 34);
            this.label1.TabIndex = 58;
            this.label1.Text = "Желаете продолжить?";
            // 
            // timer_string
            // 
            this.timer_string.AutoSize = true;
            this.timer_string.Font = new System.Drawing.Font("FSRAILWAYTT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timer_string.Location = new System.Drawing.Point(146, 67);
            this.timer_string.Name = "timer_string";
            this.timer_string.Size = new System.Drawing.Size(77, 26);
            this.timer_string.TabIndex = 59;
            this.timer_string.Text = "label2";
            // 
            // timeout_timer
            // 
            this.timeout_timer.Enabled = true;
            this.timeout_timer.Tick += new System.EventHandler(this.timeout_timer_Tick);
            // 
            // continue_dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.ControlBox = false;
            this.Controls.Add(this.timer_string);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_back_lgoti);
            this.Name = "continue_dialog";
            this.Text = "continue_dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_back_lgoti;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timer_string;
        private System.Windows.Forms.Timer timeout_timer;
    }
}