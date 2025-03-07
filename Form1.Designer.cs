namespace TicTacToe
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.picTL = new System.Windows.Forms.PictureBox();
            this.picM = new System.Windows.Forms.PictureBox();
            this.picTM = new System.Windows.Forms.PictureBox();
            this.picMR = new System.Windows.Forms.PictureBox();
            this.picDR = new System.Windows.Forms.PictureBox();
            this.picDM = new System.Windows.Forms.PictureBox();
            this.picML = new System.Windows.Forms.PictureBox();
            this.picDL = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.turns = new System.Windows.Forms.Label();
            this.playAgainButton = new DevExpress.XtraEditors.SimpleButton();
            this.wins = new System.Windows.Forms.Label();
            this.quitButton = new DevExpress.XtraEditors.SimpleButton();
            this.picTR = new System.Windows.Forms.PictureBox();
            this.LogInPage = new DevExpress.XtraEditors.PanelControl();
            this.Welcome = new System.Windows.Forms.Label();
            this.LogInQuitButton = new DevExpress.XtraEditors.SimpleButton();
            this.LogInButton = new DevExpress.XtraEditors.SimpleButton();
            this.player2NameBox = new DevExpress.XtraEditors.TextEdit();
            this.player1NameBox = new DevExpress.XtraEditors.TextEdit();
            this.player2Name = new DevExpress.XtraEditors.LabelControl();
            this.player1Name = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.picTL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogInPage)).BeginInit();
            this.LogInPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2NameBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1NameBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // picTL
            // 
            this.picTL.Location = new System.Drawing.Point(65, 55);
            this.picTL.Name = "picTL";
            this.picTL.Size = new System.Drawing.Size(115, 101);
            this.picTL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTL.TabIndex = 0;
            this.picTL.TabStop = false;
            this.picTL.Click += new System.EventHandler(this.picTL_Click);
            // 
            // picM
            // 
            this.picM.Location = new System.Drawing.Point(214, 183);
            this.picM.Name = "picM";
            this.picM.Size = new System.Drawing.Size(102, 103);
            this.picM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picM.TabIndex = 1;
            this.picM.TabStop = false;
            this.picM.Click += new System.EventHandler(this.picM_Click);
            // 
            // picTM
            // 
            this.picTM.Location = new System.Drawing.Point(214, 55);
            this.picTM.Name = "picTM";
            this.picTM.Size = new System.Drawing.Size(102, 101);
            this.picTM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTM.TabIndex = 2;
            this.picTM.TabStop = false;
            this.picTM.Click += new System.EventHandler(this.picTM_Click);
            // 
            // picMR
            // 
            this.picMR.Location = new System.Drawing.Point(349, 183);
            this.picMR.Name = "picMR";
            this.picMR.Size = new System.Drawing.Size(112, 103);
            this.picMR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMR.TabIndex = 4;
            this.picMR.TabStop = false;
            this.picMR.Click += new System.EventHandler(this.picMR_Click);
            // 
            // picDR
            // 
            this.picDR.Location = new System.Drawing.Point(349, 318);
            this.picDR.Name = "picDR";
            this.picDR.Size = new System.Drawing.Size(112, 105);
            this.picDR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDR.TabIndex = 5;
            this.picDR.TabStop = false;
            this.picDR.Click += new System.EventHandler(this.picDR_Click);
            // 
            // picDM
            // 
            this.picDM.Location = new System.Drawing.Point(204, 318);
            this.picDM.Name = "picDM";
            this.picDM.Size = new System.Drawing.Size(112, 105);
            this.picDM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDM.TabIndex = 6;
            this.picDM.TabStop = false;
            this.picDM.Click += new System.EventHandler(this.picDM_Click);
            // 
            // picML
            // 
            this.picML.Location = new System.Drawing.Point(65, 183);
            this.picML.Name = "picML";
            this.picML.Size = new System.Drawing.Size(103, 103);
            this.picML.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picML.TabIndex = 7;
            this.picML.TabStop = false;
            this.picML.Click += new System.EventHandler(this.picML_Click);
            // 
            // picDL
            // 
            this.picDL.Location = new System.Drawing.Point(65, 318);
            this.picDL.Name = "picDL";
            this.picDL.Size = new System.Drawing.Size(103, 105);
            this.picDL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDL.TabIndex = 8;
            this.picDL.TabStop = false;
            this.picDL.Click += new System.EventHandler(this.picDL_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            // 
            // turns
            // 
            this.turns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.turns.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turns.ForeColor = System.Drawing.Color.White;
            this.turns.Location = new System.Drawing.Point(-12, 0);
            this.turns.Name = "turns";
            this.turns.Size = new System.Drawing.Size(538, 43);
            this.turns.TabIndex = 0;
            this.turns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playAgainButton
            // 
            this.playAgainButton.Appearance.BackColor = System.Drawing.Color.Green;
            this.playAgainButton.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.playAgainButton.Appearance.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainButton.Appearance.ForeColor = System.Drawing.Color.Black;
            this.playAgainButton.Appearance.Options.UseBackColor = true;
            this.playAgainButton.Appearance.Options.UseBorderColor = true;
            this.playAgainButton.Appearance.Options.UseFont = true;
            this.playAgainButton.Appearance.Options.UseForeColor = true;
            this.playAgainButton.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.playAgainButton.AppearanceDisabled.Options.UseForeColor = true;
            this.playAgainButton.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.playAgainButton.AppearanceHovered.Options.UseForeColor = true;
            this.playAgainButton.AppearancePressed.ForeColor = System.Drawing.Color.Black;
            this.playAgainButton.AppearancePressed.Options.UseForeColor = true;
            this.playAgainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playAgainButton.Location = new System.Drawing.Point(65, 449);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(251, 43);
            this.playAgainButton.TabIndex = 9;
            this.playAgainButton.Text = "Play again";
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // wins
            // 
            this.wins.BackColor = System.Drawing.Color.Teal;
            this.wins.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wins.Font = new System.Drawing.Font("Segoe Script", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wins.ForeColor = System.Drawing.Color.White;
            this.wins.ImageKey = "(none)";
            this.wins.Location = new System.Drawing.Point(1, 138);
            this.wins.Name = "wins";
            this.wins.Size = new System.Drawing.Size(538, 199);
            this.wins.TabIndex = 10;
            this.wins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quitButton
            // 
            this.quitButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.quitButton.Appearance.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Appearance.Options.UseBackColor = true;
            this.quitButton.Appearance.Options.UseFont = true;
            this.quitButton.Location = new System.Drawing.Point(349, 449);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(112, 43);
            this.quitButton.TabIndex = 11;
            this.quitButton.Text = "quit";
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // picTR
            // 
            this.picTR.Location = new System.Drawing.Point(349, 55);
            this.picTR.Name = "picTR";
            this.picTR.Size = new System.Drawing.Size(112, 101);
            this.picTR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTR.TabIndex = 3;
            this.picTR.TabStop = false;
            this.picTR.Click += new System.EventHandler(this.picTR_Click);
            // 
            // LogInPage
            // 
            this.LogInPage.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.LogInPage.Appearance.Options.UseBackColor = true;
            this.LogInPage.ContentImage = global::TicTacToe.Properties.Resources.FirstScreen;
            this.LogInPage.ContentImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.LogInPage.Controls.Add(this.Welcome);
            this.LogInPage.Controls.Add(this.LogInQuitButton);
            this.LogInPage.Controls.Add(this.LogInButton);
            this.LogInPage.Controls.Add(this.player2NameBox);
            this.LogInPage.Controls.Add(this.player1NameBox);
            this.LogInPage.Controls.Add(this.player2Name);
            this.LogInPage.Controls.Add(this.player1Name);
            this.LogInPage.Location = new System.Drawing.Point(-4, -7);
            this.LogInPage.Name = "LogInPage";
            this.LogInPage.Size = new System.Drawing.Size(530, 524);
            this.LogInPage.TabIndex = 12;
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.Color.White;
            this.Welcome.Location = new System.Drawing.Point(7, 19);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(478, 37);
            this.Welcome.TabIndex = 6;
            this.Welcome.Text = "WELCOME TO TIC TAC TOE GAME";
            // 
            // LogInQuitButton
            // 
            this.LogInQuitButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.LogInQuitButton.Appearance.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInQuitButton.Appearance.Options.UseBackColor = true;
            this.LogInQuitButton.Appearance.Options.UseFont = true;
            this.LogInQuitButton.Location = new System.Drawing.Point(419, 361);
            this.LogInQuitButton.Name = "LogInQuitButton";
            this.LogInQuitButton.Size = new System.Drawing.Size(96, 47);
            this.LogInQuitButton.TabIndex = 5;
            this.LogInQuitButton.Text = "Quit";
            this.LogInQuitButton.Click += new System.EventHandler(this.LogInQuitButton_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.LogInButton.Appearance.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInButton.Appearance.Options.UseBackColor = true;
            this.LogInButton.Appearance.Options.UseFont = true;
            this.LogInButton.Location = new System.Drawing.Point(28, 361);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(292, 47);
            this.LogInButton.TabIndex = 4;
            this.LogInButton.Text = "Play Now";
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click_1);
            // 
            // player2NameBox
            // 
            this.player2NameBox.Location = new System.Drawing.Point(318, 222);
            this.player2NameBox.Name = "player2NameBox";
            this.player2NameBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2NameBox.Properties.Appearance.Options.UseFont = true;
            this.player2NameBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.player2NameBox.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.player2NameBox.Size = new System.Drawing.Size(198, 44);
            this.player2NameBox.TabIndex = 3;
            // 
            // player1NameBox
            // 
            this.player1NameBox.EditValue = "";
            this.player1NameBox.Location = new System.Drawing.Point(317, 129);
            this.player1NameBox.Name = "player1NameBox";
            this.player1NameBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1NameBox.Properties.Appearance.Options.UseFont = true;
            this.player1NameBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.player1NameBox.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.player1NameBox.Size = new System.Drawing.Size(198, 44);
            this.player1NameBox.TabIndex = 2;
            // 
            // player2Name
            // 
            this.player2Name.Appearance.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Name.Appearance.ForeColor = System.Drawing.Color.Black;
            this.player2Name.Appearance.Options.UseFont = true;
            this.player2Name.Appearance.Options.UseForeColor = true;
            this.player2Name.Location = new System.Drawing.Point(16, 217);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(283, 55);
            this.player2Name.TabIndex = 1;
            this.player2Name.Text = "player2 name = \r\n";
            // 
            // player1Name
            // 
            this.player1Name.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.player1Name.Appearance.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Name.Appearance.ForeColor = System.Drawing.Color.Black;
            this.player1Name.Appearance.Options.UseBackColor = true;
            this.player1Name.Appearance.Options.UseFont = true;
            this.player1Name.Appearance.Options.UseForeColor = true;
            this.player1Name.Location = new System.Drawing.Point(16, 126);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(283, 55);
            this.player1Name.TabIndex = 0;
            this.player1Name.Text = "player1 name = \r\n";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::TicTacToe.Properties.Resources.dashTicTacToe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(524, 504);
            this.Controls.Add(this.LogInPage);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.wins);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.turns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picDL);
            this.Controls.Add(this.picML);
            this.Controls.Add(this.picDM);
            this.Controls.Add(this.picDR);
            this.Controls.Add(this.picMR);
            this.Controls.Add(this.picTR);
            this.Controls.Add(this.picTM);
            this.Controls.Add(this.picM);
            this.Controls.Add(this.picTL);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Tic Tac Toe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogInPage)).EndInit();
            this.LogInPage.ResumeLayout(false);
            this.LogInPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2NameBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1NameBox.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picTL;
        private System.Windows.Forms.PictureBox picM;
        private System.Windows.Forms.PictureBox picTM;
        private System.Windows.Forms.PictureBox picMR;
        private System.Windows.Forms.PictureBox picDR;
        private System.Windows.Forms.PictureBox picDM;
        private System.Windows.Forms.PictureBox picML;
        private System.Windows.Forms.PictureBox picDL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label turns;
        private DevExpress.XtraEditors.SimpleButton playAgainButton;
        private System.Windows.Forms.Label wins;
        private DevExpress.XtraEditors.SimpleButton quitButton;
        private System.Windows.Forms.PictureBox picTR;
        private DevExpress.XtraEditors.PanelControl LogInPage;
        private DevExpress.XtraEditors.LabelControl player2Name;
        private DevExpress.XtraEditors.LabelControl player1Name;
        private DevExpress.XtraEditors.TextEdit player2NameBox;
        private DevExpress.XtraEditors.TextEdit player1NameBox;
        private DevExpress.XtraEditors.SimpleButton LogInQuitButton;
        private DevExpress.XtraEditors.SimpleButton LogInButton;
        private System.Windows.Forms.Label Welcome;
    }
}

