
namespace erg3_v2
{
    partial class plan
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
            this.activities = new System.Windows.Forms.ComboBox();
            this.close = new System.Windows.Forms.Button();
            this.finishtime = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.starttime = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.choosingday = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MENU = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
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
            "ΕΣΤΙΑΤΟΡΕΙΟ-ΦΑΓΗΤΟ",
            "ΝΥΧΤΕΡΙΝΗ ΕΞΟΔΟΣ",
            "ΒΟΛΤΑ",
            "ΦΡΟΝΤΙΣΤΗΡΙΟ",
            "ΓΥΜΝΑΣΤΗΡΙΟ",
            "ΑΛΛΗ ΔΡΑΣΤΗΡΙΟΤΗΤΑ"});
            this.activities.Location = new System.Drawing.Point(247, 239);
            this.activities.Name = "activities";
            this.activities.Size = new System.Drawing.Size(148, 24);
            this.activities.TabIndex = 31;
            // 
            // close
            // 
            this.close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.close.ForeColor = System.Drawing.Color.Black;
            this.close.Location = new System.Drawing.Point(791, 21);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(29, 27);
            this.close.TabIndex = 30;
            this.close.Text = "Χ";
            this.close.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // finishtime
            // 
            this.finishtime.BackColor = System.Drawing.Color.Teal;
            this.finishtime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.finishtime.ForeColor = System.Drawing.Color.Transparent;
            this.finishtime.FormattingEnabled = true;
            this.finishtime.Items.AddRange(new object[] {
            "1:00",
            "2:00",
            "3:00",
            "4:00",
            "5:00",
            "6:00",
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00",
            "00:00"});
            this.finishtime.Location = new System.Drawing.Point(247, 193);
            this.finishtime.Name = "finishtime";
            this.finishtime.Size = new System.Drawing.Size(148, 24);
            this.finishtime.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(42, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "ΩΡΑ ΛΗΞΗΣ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "ΩΡΑ ΕΝΑΡΞΗΣ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // starttime
            // 
            this.starttime.BackColor = System.Drawing.Color.Teal;
            this.starttime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.starttime.ForeColor = System.Drawing.Color.Transparent;
            this.starttime.FormattingEnabled = true;
            this.starttime.Items.AddRange(new object[] {
            "1:00",
            "2:00",
            "3:00",
            "4:00",
            "5:00",
            "6:00",
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00",
            "00:00"});
            this.starttime.Location = new System.Drawing.Point(247, 136);
            this.starttime.Name = "starttime";
            this.starttime.Size = new System.Drawing.Size(148, 24);
            this.starttime.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(247, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 52);
            this.button1.TabIndex = 23;
            this.button1.Text = "καταχωρηση";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // choosingday
            // 
            this.choosingday.AllowDrop = true;
            this.choosingday.BackColor = System.Drawing.Color.Teal;
            this.choosingday.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.choosingday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choosingday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.choosingday.ForeColor = System.Drawing.Color.Transparent;
            this.choosingday.FormattingEnabled = true;
            this.choosingday.Items.AddRange(new object[] {
            "ΔΕΥΤΕΡΑ",
            "ΤΡΙΤΗ",
            "ΤΕΤΑΡΤΗ",
            "ΠΕΜΠΤΗ",
            "ΠΑΡΑΣΚΕΥΗ",
            "ΣΑΒΒΑΤΟ",
            "ΚΥΡΙΑΚΗ"});
            this.choosingday.Location = new System.Drawing.Point(247, 94);
            this.choosingday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.choosingday.Name = "choosingday";
            this.choosingday.Size = new System.Drawing.Size(148, 28);
            this.choosingday.TabIndex = 21;
            this.choosingday.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "ΔΙΑΛΕΞΕ ΗΜΕΡΑ";
            // 
            // MENU
            // 
            this.MENU.BackColor = System.Drawing.Color.Teal;
            this.MENU.ForeColor = System.Drawing.Color.Transparent;
            this.MENU.Location = new System.Drawing.Point(12, 16);
            this.MENU.Name = "MENU";
            this.MENU.Size = new System.Drawing.Size(71, 40);
            this.MENU.TabIndex = 32;
            this.MENU.Text = "MENU";
            this.MENU.UseVisualStyleBackColor = false;
            this.MENU.Click += new System.EventHandler(this.MENU_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(250, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 56);
            this.button2.TabIndex = 33;
            this.button2.Text = "δειτε το προγραμμα";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Teal;
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(89, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 40);
            this.button4.TabIndex = 41;
            this.button4.Text = "HELP";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "ΔΡΑΣΤΗΡΙΟΤΗΤΑ";
            // 
            // plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(831, 569);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MENU);
            this.Controls.Add(this.activities);
            this.Controls.Add(this.close);
            this.Controls.Add(this.finishtime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.starttime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.choosingday);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "plan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "plan";
            this.Load += new System.EventHandler(this.plan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox activities;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ComboBox finishtime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox starttime;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox choosingday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MENU;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
    }
}