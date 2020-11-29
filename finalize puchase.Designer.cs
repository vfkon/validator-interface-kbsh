namespace WindowsFormsApp2
{
    partial class finalize_puchase
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_back_finalize = new System.Windows.Forms.Button();
            this.button_paper = new System.Windows.Forms.Button();
            this.button_card = new System.Windows.Forms.Button();
            this.timeout_payment = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("FSRAILWAYTT Bold", 21.75F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.label1.Location = new System.Drawing.Point(194, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выберите метод оплаты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("FSRAILWAYTT Bold", 21.75F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.label2.Location = new System.Drawing.Point(194, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 34);
            this.label2.TabIndex = 56;
            this.label2.Text = "Цена за билет составляет:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 20.25F);
            this.label3.Location = new System.Drawing.Point(358, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 32);
            this.label3.TabIndex = 57;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("FSRAILWAYTT Bold", 21.75F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.label4.Location = new System.Drawing.Point(238, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 34);
            this.label4.TabIndex = 58;
            this.label4.Text = "Завершите оплату";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button_back_finalize
            // 
            this.button_back_finalize.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._1PPwF___mir;
            this.button_back_finalize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_back_finalize.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_back_finalize.FlatAppearance.BorderSize = 0;
            this.button_back_finalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back_finalize.Font = new System.Drawing.Font("FSRAILWAYTT Bold", 21.75F, System.Drawing.FontStyle.Italic);
            this.button_back_finalize.ForeColor = System.Drawing.Color.White;
            this.button_back_finalize.Location = new System.Drawing.Point(12, 385);
            this.button_back_finalize.Name = "button_back_finalize";
            this.button_back_finalize.Size = new System.Drawing.Size(171, 53);
            this.button_back_finalize.TabIndex = 55;
            this.button_back_finalize.Text = "Назад";
            this.button_back_finalize.UseVisualStyleBackColor = true;
            this.button_back_finalize.Click += new System.EventHandler(this.button_back_finalize_Click);
            // 
            // button_paper
            // 
            this.button_paper.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._1PPwF;
            this.button_paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_paper.FlatAppearance.BorderSize = 0;
            this.button_paper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_paper.Font = new System.Drawing.Font("FSRAILWAYTT Bold", 21.75F, System.Drawing.FontStyle.Italic);
            this.button_paper.ForeColor = System.Drawing.Color.White;
            this.button_paper.Location = new System.Drawing.Point(397, 213);
            this.button_paper.Name = "button_paper";
            this.button_paper.Size = new System.Drawing.Size(391, 83);
            this.button_paper.TabIndex = 3;
            this.button_paper.Text = "Наличными";
            this.button_paper.UseVisualStyleBackColor = true;
            this.button_paper.Click += new System.EventHandler(this.button_paper_Click);
            // 
            // button_card
            // 
            this.button_card.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._1PPwF___mir;
            this.button_card.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_card.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_card.FlatAppearance.BorderSize = 0;
            this.button_card.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_card.Font = new System.Drawing.Font("FSRAILWAYTT Bold", 21.75F, System.Drawing.FontStyle.Italic);
            this.button_card.ForeColor = System.Drawing.Color.White;
            this.button_card.Location = new System.Drawing.Point(12, 213);
            this.button_card.Name = "button_card";
            this.button_card.Size = new System.Drawing.Size(379, 83);
            this.button_card.TabIndex = 2;
            this.button_card.Text = "Безналичный";
            this.button_card.UseVisualStyleBackColor = true;
            this.button_card.Click += new System.EventHandler(this.button_card_Click);
            // 
            // timeout_payment
            // 
            this.timeout_payment.Enabled = true;
            this.timeout_payment.Tick += new System.EventHandler(this.timeout_payment_Tick);
            // 
            // finalize_puchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_back_finalize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_paper);
            this.Controls.Add(this.button_card);
            this.Name = "finalize_puchase";
            this.Text = "finalize_puchase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_paper;
        private System.Windows.Forms.Button button_card;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_back_finalize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timeout_payment;
    }
}