
namespace IDS_v2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openButton = new System.Windows.Forms.Button();
            this.notePort = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hLy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.oLy = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tLy = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tempPict = new System.Windows.Forms.PictureBox();
            this.tempGif = new System.Windows.Forms.PictureBox();
            this.heartPict = new System.Windows.Forms.PictureBox();
            this.heartGif = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lungsPict = new System.Windows.Forms.PictureBox();
            this.lungsGif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tempPict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartPict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lungsPict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lungsGif)).BeginInit();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(434, 485);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(132, 40);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Start";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // notePort
            // 
            this.notePort.AutoSize = true;
            this.notePort.Font = new System.Drawing.Font("Microsoft Himalaya", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notePort.Location = new System.Drawing.Point(-4, 548);
            this.notePort.Name = "notePort";
            this.notePort.Size = new System.Drawing.Size(0, 17);
            this.notePort.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hLy
            // 
            this.hLy.AutoSize = true;
            this.hLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hLy.Location = new System.Drawing.Point(484, 346);
            this.hLy.Name = "hLy";
            this.hLy.Size = new System.Drawing.Size(0, 24);
            this.hLy.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Heart Rate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(525, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "bpm";
            // 
            // oLy
            // 
            this.oLy.AutoSize = true;
            this.oLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oLy.Location = new System.Drawing.Point(172, 345);
            this.oLy.Name = "oLy";
            this.oLy.Size = new System.Drawing.Size(0, 24);
            this.oLy.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "SPO2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(213, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "%";
            // 
            // tLy
            // 
            this.tLy.AutoSize = true;
            this.tLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tLy.Location = new System.Drawing.Point(785, 344);
            this.tLy.Name = "tLy";
            this.tLy.Size = new System.Drawing.Size(0, 24);
            this.tLy.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(735, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Temperature";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(815, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "C°";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 400;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tempPict
            // 
            this.tempPict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tempPict.Image = global::IDS_v2.Properties.Resources.ezgif_com_gif_maker_5_gif_00_delay_0_02s;
            this.tempPict.Location = new System.Drawing.Point(735, 126);
            this.tempPict.Name = "tempPict";
            this.tempPict.Size = new System.Drawing.Size(99, 111);
            this.tempPict.TabIndex = 0;
            this.tempPict.TabStop = false;
            // 
            // tempGif
            // 
            this.tempGif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tempGif.Image = ((System.Drawing.Image)(resources.GetObject("tempGif.Image")));
            this.tempGif.Location = new System.Drawing.Point(735, 128);
            this.tempGif.Name = "tempGif";
            this.tempGif.Size = new System.Drawing.Size(99, 111);
            this.tempGif.TabIndex = 0;
            this.tempGif.TabStop = false;
            // 
            // heartPict
            // 
            this.heartPict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.heartPict.Image = global::IDS_v2.Properties.Resources.ezgif_com_gif_maker_3_gif_00_delay_0_03s;
            this.heartPict.Location = new System.Drawing.Point(429, 128);
            this.heartPict.Name = "heartPict";
            this.heartPict.Size = new System.Drawing.Size(122, 113);
            this.heartPict.TabIndex = 0;
            this.heartPict.TabStop = false;
            // 
            // heartGif
            // 
            this.heartGif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.heartGif.Image = ((System.Drawing.Image)(resources.GetObject("heartGif.Image")));
            this.heartGif.Location = new System.Drawing.Point(429, 128);
            this.heartGif.Name = "heartGif";
            this.heartGif.Size = new System.Drawing.Size(122, 113);
            this.heartGif.TabIndex = 0;
            this.heartGif.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Image = global::IDS_v2.Properties.Resources.ezgif_com_gif_maker;
            this.pictureBox4.Location = new System.Drawing.Point(700, 100);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(200, 200);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::IDS_v2.Properties.Resources.ezgif_com_gif_maker;
            this.pictureBox2.Location = new System.Drawing.Point(400, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lungsPict
            // 
            this.lungsPict.BackColor = System.Drawing.Color.Transparent;
            this.lungsPict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lungsPict.Image = global::IDS_v2.Properties.Resources.ezgif_com_gif_maker_8_gif_00_delay_0_03s__1_;
            this.lungsPict.Location = new System.Drawing.Point(100, 100);
            this.lungsPict.Name = "lungsPict";
            this.lungsPict.Size = new System.Drawing.Size(200, 200);
            this.lungsPict.TabIndex = 0;
            this.lungsPict.TabStop = false;
            // 
            // lungsGif
            // 
            this.lungsGif.BackColor = System.Drawing.Color.Transparent;
            this.lungsGif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lungsGif.Image = ((System.Drawing.Image)(resources.GetObject("lungsGif.Image")));
            this.lungsGif.Location = new System.Drawing.Point(100, 100);
            this.lungsGif.Name = "lungsGif";
            this.lungsGif.Size = new System.Drawing.Size(200, 200);
            this.lungsGif.TabIndex = 0;
            this.lungsGif.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tLy);
            this.Controls.Add(this.oLy);
            this.Controls.Add(this.hLy);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.notePort);
            this.Controls.Add(this.tempPict);
            this.Controls.Add(this.tempGif);
            this.Controls.Add(this.heartPict);
            this.Controls.Add(this.heartGif);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lungsPict);
            this.Controls.Add(this.lungsGif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "IDS v2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tempPict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartPict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lungsPict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lungsGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lungsGif;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox heartGif;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox tempGif;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.PictureBox heartPict;
        private System.Windows.Forms.PictureBox tempPict;
        private System.Windows.Forms.PictureBox lungsPict;
        private System.Windows.Forms.Label notePort;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label hLy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label oLy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label tLy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer2;
    }
}

