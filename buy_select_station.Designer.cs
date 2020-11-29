namespace WindowsFormsApp2
{
    partial class buy_select_station
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
            this.button_back_to_main_2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_paper = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_back_to_main_2
            // 
            this.button_back_to_main_2.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._1PPwF___mir;
            this.button_back_to_main_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_back_to_main_2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_back_to_main_2.FlatAppearance.BorderSize = 0;
            this.button_back_to_main_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back_to_main_2.Font = new System.Drawing.Font("FSRAILWAYTT Bold", 21.75F, System.Drawing.FontStyle.Italic);
            this.button_back_to_main_2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_back_to_main_2.Location = new System.Drawing.Point(12, 385);
            this.button_back_to_main_2.Name = "button_back_to_main_2";
            this.button_back_to_main_2.Size = new System.Drawing.Size(171, 53);
            this.button_back_to_main_2.TabIndex = 53;
            this.button_back_to_main_2.Text = "Назад";
            this.button_back_to_main_2.UseVisualStyleBackColor = true;
            this.button_back_to_main_2.Click += new System.EventHandler(this.button_back_to_main_2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.RZD_logo_p_1600;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(573, 325);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 113);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button_paper
            // 
            this.button_paper.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._1PPwF;
            this.button_paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_paper.FlatAppearance.BorderSize = 0;
            this.button_paper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_paper.Font = new System.Drawing.Font("FSRAILWAYTT Bold", 21.75F, System.Drawing.FontStyle.Italic);
            this.button_paper.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_paper.Location = new System.Drawing.Point(354, 385);
            this.button_paper.Name = "button_paper";
            this.button_paper.Size = new System.Drawing.Size(171, 53);
            this.button_paper.TabIndex = 55;
            this.button_paper.Text = "Дальше";
            this.button_paper.UseVisualStyleBackColor = true;
            this.button_paper.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("FSRAILWAYTT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(43, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(716, 52);
            this.comboBox1.TabIndex = 56;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 57;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buy_select_station
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_paper);
            this.Controls.Add(this.button_back_to_main_2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "buy_select_station";
            this.Text = "buy_select_station";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_back_to_main_2;
        private System.Windows.Forms.Button button_paper;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
    }
}