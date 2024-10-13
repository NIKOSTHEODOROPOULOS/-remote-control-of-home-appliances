
namespace erg3_v2
{
    partial class menu
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
            this.logout = new System.Windows.Forms.Button();
            this.pets = new System.Windows.Forms.Button();
            this.planday = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.homedevices = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logout
            // 
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.ForeColor = System.Drawing.Color.Transparent;
            this.logout.Location = new System.Drawing.Point(319, 340);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(116, 34);
            this.logout.TabIndex = 16;
            this.logout.Text = "LOG OUT";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // pets
            // 
            this.pets.BackColor = System.Drawing.Color.Teal;
            this.pets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.pets.ForeColor = System.Drawing.Color.Transparent;
            this.pets.Location = new System.Drawing.Point(301, 250);
            this.pets.Name = "pets";
            this.pets.Size = new System.Drawing.Size(158, 65);
            this.pets.TabIndex = 15;
            this.pets.Text = "κατοικίδια ";
            this.pets.UseVisualStyleBackColor = false;
            this.pets.Click += new System.EventHandler(this.pets_Click);
            // 
            // planday
            // 
            this.planday.BackColor = System.Drawing.Color.Teal;
            this.planday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.planday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.planday.ForeColor = System.Drawing.Color.Transparent;
            this.planday.Location = new System.Drawing.Point(301, 87);
            this.planday.Name = "planday";
            this.planday.Size = new System.Drawing.Size(158, 73);
            this.planday.TabIndex = 13;
            this.planday.Text = "πλάνο ημέρας";
            this.planday.UseVisualStyleBackColor = false;
            this.planday.Click += new System.EventHandler(this.planday_Click);
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(888, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 30);
            this.button3.TabIndex = 12;
            this.button3.Text = "Χ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // homedevices
            // 
            this.homedevices.BackColor = System.Drawing.Color.Teal;
            this.homedevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homedevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.homedevices.ForeColor = System.Drawing.Color.Transparent;
            this.homedevices.Location = new System.Drawing.Point(301, 175);
            this.homedevices.Name = "homedevices";
            this.homedevices.Size = new System.Drawing.Size(158, 58);
            this.homedevices.TabIndex = 17;
            this.homedevices.Text = "οικιακές συσκευές";
            this.homedevices.UseVisualStyleBackColor = false;
            this.homedevices.Click += new System.EventHandler(this.homedevices_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "HELP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // close
            // 
            this.close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.close.ForeColor = System.Drawing.Color.Black;
            this.close.Location = new System.Drawing.Point(761, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(29, 27);
            this.close.TabIndex = 31;
            this.close.Text = "Χ";
            this.close.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(802, 496);
            this.Controls.Add(this.close);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.homedevices);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.pets);
            this.Controls.Add(this.planday);
            this.Controls.Add(this.button3);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button pets;
        private System.Windows.Forms.Button planday;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button homedevices;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button close;
    }
}