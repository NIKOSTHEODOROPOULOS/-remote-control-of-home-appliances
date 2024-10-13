
namespace ergasia3check
{
    partial class Live
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Live));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.MENU = new System.Windows.Forms.Button();
            this.timerA1 = new System.Windows.Forms.Timer(this.components);
            this.timerA2 = new System.Windows.Forms.Timer(this.components);
            this.timerA3 = new System.Windows.Forms.Timer(this.components);
            this.timerA4 = new System.Windows.Forms.Timer(this.components);
            this.timerA5 = new System.Windows.Forms.Timer(this.components);
            this.timerA0 = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(23, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 318);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.imageList3;
            this.label1.Location = new System.Drawing.Point(38, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 280);
            this.label1.TabIndex = 2;
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "Screen-Shot-2019-09-05-at-11.22.12-AM.png");
            this.imageList3.Images.SetKeyName(1, "yourdog.co_.uk_.jpg");
            this.imageList3.Images.SetKeyName(2, "free-feeding-dogs.jpg");
            this.imageList3.Images.SetKeyName(3, "dog-eating-messily-thinkstockphotos-497385058-335.jpg");
            this.imageList3.Images.SetKeyName(4, "how-to-slow-down-dog-drinking-water-1024x683.jpg");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(143, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Live Video";
            // 
            // MENU
            // 
            this.MENU.Location = new System.Drawing.Point(12, 12);
            this.MENU.Name = "MENU";
            this.MENU.Size = new System.Drawing.Size(71, 40);
            this.MENU.TabIndex = 38;
            this.MENU.Text = "MENU";
            this.MENU.UseVisualStyleBackColor = true;
            this.MENU.Click += new System.EventHandler(this.MENU_Click);
            // 
            // timerA1
            // 
            this.timerA1.Interval = 1000;
            this.timerA1.Tick += new System.EventHandler(this.timerA1_Tick);
            // 
            // timerA2
            // 
            this.timerA2.Interval = 1000;
            this.timerA2.Tick += new System.EventHandler(this.timerA2_Tick);
            // 
            // timerA3
            // 
            this.timerA3.Interval = 1000;
            this.timerA3.Tick += new System.EventHandler(this.timerA3_Tick);
            // 
            // timerA4
            // 
            this.timerA4.Interval = 1000;
            this.timerA4.Tick += new System.EventHandler(this.timerA4_Tick);
            // 
            // timerA5
            // 
            this.timerA5.Interval = 1000;
            this.timerA5.Tick += new System.EventHandler(this.timerA5_Tick);
            // 
            // timerA0
            // 
            this.timerA0.Interval = 1000;
            this.timerA0.Tick += new System.EventHandler(this.timerA0_Tick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 26);
            this.button4.TabIndex = 41;
            this.button4.Text = "HELP";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Live
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(422, 426);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.MENU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "Live";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Live";
            this.Load += new System.EventHandler(this.Live_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MENU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.Timer timerA1;
        private System.Windows.Forms.Timer timerA2;
        private System.Windows.Forms.Timer timerA3;
        private System.Windows.Forms.Timer timerA4;
        private System.Windows.Forms.Timer timerA5;
        private System.Windows.Forms.Timer timerA0;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}