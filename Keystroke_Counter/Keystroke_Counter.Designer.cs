namespace Keystroke_Counter
{
    partial class Main
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
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.last_key = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.total_char_text = new System.Windows.Forms.Label();
            this.lastkey = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            // 
            // last_key
            // 
            this.last_key.AutoSize = true;
            this.last_key.Location = new System.Drawing.Point(267, 122);
            this.last_key.Name = "last_key";
            this.last_key.Size = new System.Drawing.Size(0, 0);
            this.last_key.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(103, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 47);
            this.label1.TabIndex = 12;
            this.label1.Text = "TOTAL KEYPRESS:";
            // 
            // total_char_text
            // 
            this.total_char_text.AutoSize = true;
            this.total_char_text.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_char_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.total_char_text.Location = new System.Drawing.Point(389, 108);
            this.total_char_text.Name = "total_char_text";
            this.total_char_text.Size = new System.Drawing.Size(39, 47);
            this.total_char_text.TabIndex = 13;
            this.total_char_text.Text = "0";
            // 
            // lastkey
            // 
            this.lastkey.AutoSize = true;
            this.lastkey.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastkey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.lastkey.Location = new System.Drawing.Point(275, 178);
            this.lastkey.Name = "lastkey";
            this.lastkey.Size = new System.Drawing.Size(42, 47);
            this.lastkey.TabIndex = 15;
            this.lastkey.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(103, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 47);
            this.label3.TabIndex = 14;
            this.label3.Text = "LAST KEY:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 309);
            this.Controls.Add(this.lastkey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.total_char_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.last_key);
            this.Name = "Main";
            this.Resizable = false;
            this.Text = "Keystroke Counter";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel last_key;
        private System.Windows.Forms.Label lastkey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label total_char_text;
    }
}

