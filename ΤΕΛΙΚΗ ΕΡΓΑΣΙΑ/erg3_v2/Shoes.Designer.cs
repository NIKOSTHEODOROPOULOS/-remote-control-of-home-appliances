
namespace erg3_v2
{
    partial class Shoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shoes));
            this.activities = new System.Windows.Forms.ComboBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.sports = new System.Windows.Forms.ImageList(this.components);
            this.button17 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.MENU = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.casual = new System.Windows.Forms.ImageList(this.components);
            this.formal = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.all = new System.Windows.Forms.ImageList(this.components);
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // activities
            // 
            this.activities.BackColor = System.Drawing.Color.Teal;
            this.activities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activities.ForeColor = System.Drawing.Color.Transparent;
            this.activities.FormattingEnabled = true;
            this.activities.Items.AddRange(new object[] {
            "ΕΡΓΑΣΙΑ",
            "ΣΧΟΛΕΙΟ",
            "ΕΣΤΙΑΤΟΡΙΟ-ΦΑΓΗΤΟ",
            "ΝΥΧΤΕΡΙΝΗ ΕΞΟΔΟΣ",
            "ΒΟΛΤΑ",
            "ΦΡΟΝΤΙΣΤΗΡΙΟ",
            "ΓΥΜΝΑΣΤΗΡΙΟ",
            "ΑΛΛΗ ΔΡΑΣΤΗΡΙΟΤΗΤΑ"});
            this.activities.Location = new System.Drawing.Point(52, 219);
            this.activities.Name = "activities";
            this.activities.Size = new System.Drawing.Size(167, 24);
            this.activities.TabIndex = 42;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Teal;
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.button17);
            this.panel8.Controls.Add(this.label18);
            this.panel8.ForeColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(321, 60);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(427, 371);
            this.panel8.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageIndex = 0;
            this.label2.ImageList = this.sports;
            this.label2.Location = new System.Drawing.Point(67, 49);
            this.label2.MaximumSize = new System.Drawing.Size(300, 250);
            this.label2.MinimumSize = new System.Drawing.Size(300, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 250);
            this.label2.TabIndex = 6;
            // 
            // sports
            // 
            this.sports.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("sports.ImageStream")));
            this.sports.TransparentColor = System.Drawing.Color.Transparent;
            this.sports.Images.SetKeyName(0, "2310021845_03-huge-huge.jpg");
            this.sports.Images.SetKeyName(1, "ανδρικα-παπουτσια-air-max-97-Bc9BgR.jpg");
            this.sports.Images.SetKeyName(2, "adidas-lite-racer-20.jpg");
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Teal;
            this.button17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button17.ForeColor = System.Drawing.Color.Transparent;
            this.button17.Location = new System.Drawing.Point(147, 303);
            this.button17.Margin = new System.Windows.Forms.Padding(4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(165, 64);
            this.button17.TabIndex = 4;
            this.button17.Text = "CHANGE SHOE";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label18.Location = new System.Drawing.Point(114, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(198, 20);
            this.label18.TabIndex = 4;
            this.label18.Text = "Έξυπνη Παπουτσοθήκη";
            // 
            // close
            // 
            this.close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.close.ForeColor = System.Drawing.Color.Black;
            this.close.Location = new System.Drawing.Point(759, 20);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(29, 27);
            this.close.TabIndex = 40;
            this.close.Text = "Χ";
            this.close.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // MENU
            // 
            this.MENU.BackColor = System.Drawing.Color.Teal;
            this.MENU.ForeColor = System.Drawing.Color.Transparent;
            this.MENU.Location = new System.Drawing.Point(12, 20);
            this.MENU.Name = "MENU";
            this.MENU.Size = new System.Drawing.Size(71, 40);
            this.MENU.TabIndex = 39;
            this.MENU.Text = "MENU";
            this.MENU.UseVisualStyleBackColor = false;
            this.MENU.Click += new System.EventHandler(this.MENU_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "ΘΑ ΘΕΛΑΤΕ ΠΡΟΤΑΣΕΙΣ ΓΙΑ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(52, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 59);
            this.button2.TabIndex = 37;
            this.button2.Text = "ΔΕΙΤΕ ΤΗΝ ΠΡΟΤΑΣΗ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // casual
            // 
            this.casual.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("casual.ImageStream")));
            this.casual.TransparentColor = System.Drawing.Color.Transparent;
            this.casual.Images.SetKeyName(0, "αρχείο λήψης (2).jpg");
            this.casual.Images.SetKeyName(1, "pepe-jeans-marton-basic.jpg");
            this.casual.Images.SetKeyName(2, "M03-14421-34-DSC_0980.jpg");
            this.casual.Images.SetKeyName(3, "images.jpg");
            this.casual.Images.SetKeyName(4, "αρχείο λήψης (1).jpg");
            this.casual.Images.SetKeyName(5, "αρχείο λήψης.jpg");
            this.casual.Images.SetKeyName(6, "2310021845_03-huge-huge.jpg");
            this.casual.Images.SetKeyName(7, "ανδρικα-παπουτσια-air-max-97-Bc9BgR.jpg");
            this.casual.Images.SetKeyName(8, "adidas-lite-racer-20.jpg");
            // 
            // formal
            // 
            this.formal.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("formal.ImageStream")));
            this.formal.TransparentColor = System.Drawing.Color.Transparent;
            this.formal.Images.SetKeyName(0, "αρχείο λήψης (4).jpg");
            this.formal.Images.SetKeyName(1, "pepe-jeans-marton-basic.jpg");
            this.formal.Images.SetKeyName(2, "M03-14421-34-DSC_0980.jpg");
            this.formal.Images.SetKeyName(3, "αρχείο λήψης (3).jpg");
            this.formal.Images.SetKeyName(4, "αρχείο λήψης.jpg");
            this.formal.Images.SetKeyName(5, "E02-14117-54-DSC_0054.jpg");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(16, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 38);
            this.button1.TabIndex = 44;
            this.button1.Text = "HELP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // all
            // 
            this.all.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("all.ImageStream")));
            this.all.TransparentColor = System.Drawing.Color.Transparent;
            this.all.Images.SetKeyName(0, "pepe-jeans-marton-basic.jpg");
            this.all.Images.SetKeyName(1, "αρχείο λήψης (4).jpg");
            this.all.Images.SetKeyName(2, "M03-14421-34-DSC_0980.jpg");
            this.all.Images.SetKeyName(3, "images.jpg");
            this.all.Images.SetKeyName(4, "αρχείο λήψης (3).jpg");
            this.all.Images.SetKeyName(5, "αρχείο λήψης (2).jpg");
            this.all.Images.SetKeyName(6, "αρχείο λήψης (1).jpg");
            this.all.Images.SetKeyName(7, "αρχείο λήψης.jpg");
            this.all.Images.SetKeyName(8, "2310021845_03-huge-huge.jpg");
            // 
            // Shoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.activities);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.close);
            this.Controls.Add(this.MENU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.MaximizeBox = false;
            this.Name = "Shoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shoes";
            this.Load += new System.EventHandler(this.Shoes_Load);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox activities;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList sports;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button MENU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList casual;
        private System.Windows.Forms.ImageList formal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList all;
    }
}