
namespace Zjazd5
{
    partial class mainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLog = new System.Windows.Forms.Label();
            this.textBoxReg = new System.Windows.Forms.TextBox();
            this.checkBoxRodo = new System.Windows.Forms.CheckBox();
            this.butReg = new System.Windows.Forms.Button();
            this.textBoxRegPass = new System.Windows.Forms.TextBox();
            this.textBoxRegPassConf = new System.Windows.Forms.TextBox();
            this.lblReg = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.textBoxLogPass = new System.Windows.Forms.TextBox();
            this.butLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLog.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblLog.Location = new System.Drawing.Point(68, 66);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(145, 29);
            this.lblLog.TabIndex = 0;
            this.lblLog.Text = "Rejestracja";
            // 
            // textBoxReg
            // 
            this.textBoxReg.Location = new System.Drawing.Point(68, 111);
            this.textBoxReg.Name = "textBoxReg";
            this.textBoxReg.PlaceholderText = "Nazwa użytkownika";
            this.textBoxReg.Size = new System.Drawing.Size(150, 23);
            this.textBoxReg.TabIndex = 1;
            // 
            // checkBoxRodo
            // 
            this.checkBoxRodo.AutoSize = true;
            this.checkBoxRodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxRodo.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkBoxRodo.Location = new System.Drawing.Point(68, 246);
            this.checkBoxRodo.Name = "checkBoxRodo";
            this.checkBoxRodo.Size = new System.Drawing.Size(136, 24);
            this.checkBoxRodo.TabIndex = 2;
            this.checkBoxRodo.Text = "Zgoda RODO";
            this.checkBoxRodo.UseVisualStyleBackColor = true;
            // 
            // butReg
            // 
            this.butReg.BackColor = System.Drawing.Color.White;
            this.butReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butReg.ForeColor = System.Drawing.Color.DarkBlue;
            this.butReg.Location = new System.Drawing.Point(60, 286);
            this.butReg.Name = "butReg";
            this.butReg.Size = new System.Drawing.Size(158, 40);
            this.butReg.TabIndex = 3;
            this.butReg.Text = "Zarejestruj";
            this.butReg.UseVisualStyleBackColor = false;
            this.butReg.Click += new System.EventHandler(this.butReg_Click);
            // 
            // textBoxRegPass
            // 
            this.textBoxRegPass.CausesValidation = false;
            this.textBoxRegPass.Location = new System.Drawing.Point(68, 156);
            this.textBoxRegPass.Name = "textBoxRegPass";
            this.textBoxRegPass.PlaceholderText = "Hasło";
            this.textBoxRegPass.Size = new System.Drawing.Size(150, 23);
            this.textBoxRegPass.TabIndex = 4;
            this.textBoxRegPass.UseSystemPasswordChar = true;
            // 
            // textBoxRegPassConf
            // 
            this.textBoxRegPassConf.Location = new System.Drawing.Point(68, 201);
            this.textBoxRegPassConf.Name = "textBoxRegPassConf";
            this.textBoxRegPassConf.PlaceholderText = "Powtórz hasło";
            this.textBoxRegPassConf.Size = new System.Drawing.Size(150, 23);
            this.textBoxRegPassConf.TabIndex = 5;
            this.textBoxRegPassConf.UseSystemPasswordChar = true;
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReg.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblReg.Location = new System.Drawing.Point(360, 66);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(141, 29);
            this.lblReg.TabIndex = 6;
            this.lblReg.Text = "Logowanie";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(351, 111);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.PlaceholderText = "Nazwa użytkownika";
            this.textBoxLog.Size = new System.Drawing.Size(150, 23);
            this.textBoxLog.TabIndex = 7;
            // 
            // textBoxLogPass
            // 
            this.textBoxLogPass.CausesValidation = false;
            this.textBoxLogPass.Location = new System.Drawing.Point(351, 156);
            this.textBoxLogPass.Name = "textBoxLogPass";
            this.textBoxLogPass.PlaceholderText = "Hasło";
            this.textBoxLogPass.Size = new System.Drawing.Size(150, 23);
            this.textBoxLogPass.TabIndex = 8;
            this.textBoxLogPass.UseSystemPasswordChar = true;
            // 
            // butLog
            // 
            this.butLog.BackColor = System.Drawing.Color.White;
            this.butLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butLog.ForeColor = System.Drawing.Color.DarkBlue;
            this.butLog.Location = new System.Drawing.Point(351, 286);
            this.butLog.Name = "butLog";
            this.butLog.Size = new System.Drawing.Size(140, 40);
            this.butLog.TabIndex = 9;
            this.butLog.Text = "Zaloguj";
            this.butLog.UseVisualStyleBackColor = false;
            this.butLog.Click += new System.EventHandler(this.butLog_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(550, 392);
            this.Controls.Add(this.butLog);
            this.Controls.Add(this.textBoxLogPass);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.textBoxRegPassConf);
            this.Controls.Add(this.textBoxRegPass);
            this.Controls.Add(this.butReg);
            this.Controls.Add(this.checkBoxRodo);
            this.Controls.Add(this.textBoxReg);
            this.Controls.Add(this.lblLog);
            this.Name = "mainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.TextBox textBoxReg;
        private System.Windows.Forms.CheckBox checkBoxRodo;
        private System.Windows.Forms.Button butReg;
        private System.Windows.Forms.TextBox textBoxRegPass;
        private System.Windows.Forms.TextBox textBoxRegPassConf;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TextBox textBoxLogPass;
        private System.Windows.Forms.Button butLog;
    }
}

