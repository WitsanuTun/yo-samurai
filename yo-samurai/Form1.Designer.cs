namespace yo_samurai
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.laCircum = new System.Windows.Forms.Label();
            this.laArea = new System.Windows.Forms.Label();
            this.tRadius = new System.Windows.Forms.TextBox();
            this.bcircum = new System.Windows.Forms.Button();
            this.bArea = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(388, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "คำนวนวงกลมแบบชาวไซย่า";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::yo_samurai.Properties.Resources._013af4dd96aa4ad1a38a90107c888dc8_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(12, 221);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 228);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Image = global::yo_samurai.Properties.Resources._1390213417_1379562842_o_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(-62, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(587, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TH Sarabun New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(454, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "รัศมี";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TH Sarabun New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(454, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "เส้นรอบวง";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("TH Sarabun New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "พื้นที่วงกลม";
            // 
            // laCircum
            // 
            this.laCircum.AutoSize = true;
            this.laCircum.Font = new System.Drawing.Font("TH Sarabun New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laCircum.Location = new System.Drawing.Point(548, 224);
            this.laCircum.Name = "laCircum";
            this.laCircum.Size = new System.Drawing.Size(139, 36);
            this.laCircum.TabIndex = 6;
            this.laCircum.Text = "...............................";
            // 
            // laArea
            // 
            this.laArea.AutoSize = true;
            this.laArea.Font = new System.Drawing.Font("TH Sarabun New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laArea.Location = new System.Drawing.Point(548, 281);
            this.laArea.Name = "laArea";
            this.laArea.Size = new System.Drawing.Size(139, 36);
            this.laArea.TabIndex = 7;
            this.laArea.Text = "...............................";
            // 
            // tRadius
            // 
            this.tRadius.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tRadius.Font = new System.Drawing.Font("TH Sarabun New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRadius.Location = new System.Drawing.Point(519, 167);
            this.tRadius.Name = "tRadius";
            this.tRadius.Size = new System.Drawing.Size(181, 43);
            this.tRadius.TabIndex = 0;
            // 
            // bcircum
            // 
            this.bcircum.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bcircum.Font = new System.Drawing.Font("TH Sarabun New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcircum.Location = new System.Drawing.Point(720, 221);
            this.bcircum.Name = "bcircum";
            this.bcircum.Size = new System.Drawing.Size(99, 43);
            this.bcircum.TabIndex = 9;
            this.bcircum.Text = "กดดิค้าบ";
            this.bcircum.UseVisualStyleBackColor = false;
            this.bcircum.Click += new System.EventHandler(this.bcircum_Click);
            // 
            // bArea
            // 
            this.bArea.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bArea.Font = new System.Drawing.Font("TH Sarabun New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bArea.Location = new System.Drawing.Point(720, 278);
            this.bArea.Name = "bArea";
            this.bArea.Size = new System.Drawing.Size(99, 43);
            this.bArea.TabIndex = 10;
            this.bArea.Text = "กดดิสาส";
            this.bArea.UseVisualStyleBackColor = false;
            this.bArea.Click += new System.EventHandler(this.bArea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(976, 450);
            this.Controls.Add(this.bArea);
            this.Controls.Add(this.bcircum);
            this.Controls.Add(this.tRadius);
            this.Controls.Add(this.laArea);
            this.Controls.Add(this.laCircum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "โปรแกรมคำนวนวงกลม";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label laCircum;
        private System.Windows.Forms.Label laArea;
        private System.Windows.Forms.TextBox tRadius;
        private System.Windows.Forms.Button bcircum;
        private System.Windows.Forms.Button bArea;
    }
}

