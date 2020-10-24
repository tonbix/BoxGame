namespace Game
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Score = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Panel();
            this.CustomizationButton = new System.Windows.Forms.Button();
            this.ResumeM = new System.Windows.Forms.Button();
            this.BScoreM = new System.Windows.Forms.Label();
            this.ScoreM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReplayButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.BScore = new System.Windows.Forms.Label();
            this.StartMenu = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.TitleSM = new System.Windows.Forms.Label();
            this.CoinCounter = new System.Windows.Forms.Label();
            this.CustomizationMenu = new System.Windows.Forms.Panel();
            this.CoinsCountMenu = new System.Windows.Forms.Label();
            this.Skin4L = new System.Windows.Forms.Label();
            this.Skin3L = new System.Windows.Forms.Label();
            this.Skin2L = new System.Windows.Forms.Label();
            this.Skin1L = new System.Windows.Forms.Label();
            this.Skin4 = new System.Windows.Forms.PictureBox();
            this.Skin3 = new System.Windows.Forms.PictureBox();
            this.Skin2 = new System.Windows.Forms.PictureBox();
            this.Skin1 = new System.Windows.Forms.PictureBox();
            this.CustMenuCloseButton = new System.Windows.Forms.Button();
            this.CustMenuLabel = new System.Windows.Forms.Label();
            this.PauseButton = new System.Windows.Forms.Button();
            this.PipeUp = new System.Windows.Forms.PictureBox();
            this.PipeDown = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.coin = new System.Windows.Forms.PictureBox();
            this.CheatMenu = new System.Windows.Forms.Panel();
            this.AllZero = new System.Windows.Forms.Button();
            this.UnlimMoney = new System.Windows.Forms.Button();
            this.SpeedUpL = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            this.StartMenu.SuspendLayout();
            this.CustomizationMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Skin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            this.CheatMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.White;
            this.Score.Location = new System.Drawing.Point(34, 19);
            this.Score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(47, 13);
            this.Score.TabIndex = 5;
            this.Score.Text = "Score: 0";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.White;
            this.Menu.Controls.Add(this.CustomizationButton);
            this.Menu.Controls.Add(this.ResumeM);
            this.Menu.Controls.Add(this.BScoreM);
            this.Menu.Controls.Add(this.ScoreM);
            this.Menu.Controls.Add(this.label1);
            this.Menu.Controls.Add(this.ReplayButton);
            this.Menu.Controls.Add(this.CloseButton);
            this.Menu.Location = new System.Drawing.Point(150, -5);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(259, 1);
            this.Menu.TabIndex = 7;
            this.Menu.Visible = false;
            // 
            // CustomizationButton
            // 
            this.CustomizationButton.Location = new System.Drawing.Point(10, 295);
            this.CustomizationButton.Name = "CustomizationButton";
            this.CustomizationButton.Size = new System.Drawing.Size(240, 50);
            this.CustomizationButton.TabIndex = 14;
            this.CustomizationButton.Text = "Customization";
            this.CustomizationButton.UseVisualStyleBackColor = true;
            this.CustomizationButton.Click += new System.EventHandler(this.CustomizationButton_Click);
            // 
            // ResumeM
            // 
            this.ResumeM.Location = new System.Drawing.Point(10, 240);
            this.ResumeM.Name = "ResumeM";
            this.ResumeM.Size = new System.Drawing.Size(240, 50);
            this.ResumeM.TabIndex = 13;
            this.ResumeM.Text = "Resume";
            this.ResumeM.UseVisualStyleBackColor = true;
            this.ResumeM.Visible = false;
            this.ResumeM.Click += new System.EventHandler(this.ResumeM_Click);
            // 
            // BScoreM
            // 
            this.BScoreM.Location = new System.Drawing.Point(0, 100);
            this.BScoreM.Name = "BScoreM";
            this.BScoreM.Size = new System.Drawing.Size(259, 13);
            this.BScoreM.TabIndex = 12;
            this.BScoreM.Text = "Your best score: 0";
            this.BScoreM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreM
            // 
            this.ScoreM.Location = new System.Drawing.Point(0, 78);
            this.ScoreM.Name = "ScoreM";
            this.ScoreM.Size = new System.Drawing.Size(259, 13);
            this.ScoreM.TabIndex = 11;
            this.ScoreM.Text = "Your score: 0";
            this.ScoreM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 86);
            this.label1.TabIndex = 8;
            this.label1.Text = "Game over";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReplayButton
            // 
            this.ReplayButton.Location = new System.Drawing.Point(10, 130);
            this.ReplayButton.Name = "ReplayButton";
            this.ReplayButton.Size = new System.Drawing.Size(240, 50);
            this.ReplayButton.TabIndex = 9;
            this.ReplayButton.Text = "Replay";
            this.ReplayButton.UseVisualStyleBackColor = true;
            this.ReplayButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(10, 185);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(241, 50);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Exit game";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // BScore
            // 
            this.BScore.AutoSize = true;
            this.BScore.BackColor = System.Drawing.Color.White;
            this.BScore.Location = new System.Drawing.Point(34, 38);
            this.BScore.Name = "BScore";
            this.BScore.Size = new System.Drawing.Size(69, 13);
            this.BScore.TabIndex = 10;
            this.BScore.Text = "Best score: 0";
            // 
            // StartMenu
            // 
            this.StartMenu.BackColor = System.Drawing.Color.White;
            this.StartMenu.Controls.Add(this.StartButton);
            this.StartMenu.Controls.Add(this.TitleSM);
            this.StartMenu.Location = new System.Drawing.Point(160, 1025);
            this.StartMenu.Name = "StartMenu";
            this.StartMenu.Size = new System.Drawing.Size(300, 140);
            this.StartMenu.TabIndex = 11;
            this.StartMenu.Visible = false;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(10, 56);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(280, 75);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // TitleSM
            // 
            this.TitleSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleSM.Location = new System.Drawing.Point(0, 0);
            this.TitleSM.Name = "TitleSM";
            this.TitleSM.Size = new System.Drawing.Size(300, 53);
            this.TitleSM.TabIndex = 0;
            this.TitleSM.Text = "Odnoklassniki travel";
            this.TitleSM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CoinCounter
            // 
            this.CoinCounter.AutoSize = true;
            this.CoinCounter.BackColor = System.Drawing.Color.White;
            this.CoinCounter.Location = new System.Drawing.Point(33, 57);
            this.CoinCounter.Name = "CoinCounter";
            this.CoinCounter.Size = new System.Drawing.Size(45, 13);
            this.CoinCounter.TabIndex = 13;
            this.CoinCounter.Text = "Coins: 0";
            // 
            // CustomizationMenu
            // 
            this.CustomizationMenu.BackColor = System.Drawing.Color.White;
            this.CustomizationMenu.Controls.Add(this.CoinsCountMenu);
            this.CustomizationMenu.Controls.Add(this.Skin4L);
            this.CustomizationMenu.Controls.Add(this.Skin3L);
            this.CustomizationMenu.Controls.Add(this.Skin2L);
            this.CustomizationMenu.Controls.Add(this.Skin1L);
            this.CustomizationMenu.Controls.Add(this.Skin4);
            this.CustomizationMenu.Controls.Add(this.Skin3);
            this.CustomizationMenu.Controls.Add(this.Skin2);
            this.CustomizationMenu.Controls.Add(this.Skin1);
            this.CustomizationMenu.Controls.Add(this.CustMenuCloseButton);
            this.CustomizationMenu.Controls.Add(this.CustMenuLabel);
            this.CustomizationMenu.Location = new System.Drawing.Point(17, -1000);
            this.CustomizationMenu.Name = "CustomizationMenu";
            this.CustomizationMenu.Size = new System.Drawing.Size(570, 380);
            this.CustomizationMenu.TabIndex = 15;
            this.CustomizationMenu.Visible = false;
            // 
            // CoinsCountMenu
            // 
            this.CoinsCountMenu.AutoSize = true;
            this.CoinsCountMenu.Location = new System.Drawing.Point(24, 39);
            this.CoinsCountMenu.Name = "CoinsCountMenu";
            this.CoinsCountMenu.Size = new System.Drawing.Size(39, 13);
            this.CoinsCountMenu.TabIndex = 24;
            this.CoinsCountMenu.Text = "Coins: ";
            // 
            // Skin4L
            // 
            this.Skin4L.AutoSize = true;
            this.Skin4L.Location = new System.Drawing.Point(240, 141);
            this.Skin4L.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Skin4L.Name = "Skin4L";
            this.Skin4L.Size = new System.Drawing.Size(71, 13);
            this.Skin4L.TabIndex = 23;
            this.Skin4L.Text = "Buy: 25 coins";
            // 
            // Skin3L
            // 
            this.Skin3L.AutoSize = true;
            this.Skin3L.Location = new System.Drawing.Point(166, 141);
            this.Skin3L.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Skin3L.Name = "Skin3L";
            this.Skin3L.Size = new System.Drawing.Size(71, 13);
            this.Skin3L.TabIndex = 22;
            this.Skin3L.Text = "Buy: 50 coins";
            // 
            // Skin2L
            // 
            this.Skin2L.AutoSize = true;
            this.Skin2L.Location = new System.Drawing.Point(90, 141);
            this.Skin2L.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Skin2L.Name = "Skin2L";
            this.Skin2L.Size = new System.Drawing.Size(71, 13);
            this.Skin2L.TabIndex = 21;
            this.Skin2L.Text = "Buy: 10 coins";
            // 
            // Skin1L
            // 
            this.Skin1L.AutoSize = true;
            this.Skin1L.Location = new System.Drawing.Point(13, 142);
            this.Skin1L.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Skin1L.Name = "Skin1L";
            this.Skin1L.Size = new System.Drawing.Size(46, 13);
            this.Skin1L.TabIndex = 20;
            this.Skin1L.Text = "Installed";
            // 
            // Skin4
            // 
            this.Skin4.BackColor = System.Drawing.Color.SlateGray;
            this.Skin4.Image = global::Game.Properties.Resources.котек;
            this.Skin4.Location = new System.Drawing.Point(242, 83);
            this.Skin4.Name = "Skin4";
            this.Skin4.Size = new System.Drawing.Size(70, 55);
            this.Skin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Skin4.TabIndex = 19;
            this.Skin4.TabStop = false;
            this.Skin4.Click += new System.EventHandler(this.Skin4_Click);
            // 
            // Skin3
            // 
            this.Skin3.BackColor = System.Drawing.Color.SlateGray;
            this.Skin3.Image = global::Game.Properties.Resources._60_оттенков_скителса;
            this.Skin3.Location = new System.Drawing.Point(166, 83);
            this.Skin3.Name = "Skin3";
            this.Skin3.Size = new System.Drawing.Size(70, 55);
            this.Skin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Skin3.TabIndex = 18;
            this.Skin3.TabStop = false;
            this.Skin3.Click += new System.EventHandler(this.Skin3_Click);
            // 
            // Skin2
            // 
            this.Skin2.BackColor = System.Drawing.Color.SlateGray;
            this.Skin2.Image = global::Game.Properties.Resources.AAAAAAAAAAAAAAAAAAA;
            this.Skin2.Location = new System.Drawing.Point(91, 83);
            this.Skin2.Name = "Skin2";
            this.Skin2.Size = new System.Drawing.Size(70, 55);
            this.Skin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Skin2.TabIndex = 17;
            this.Skin2.TabStop = false;
            this.Skin2.Click += new System.EventHandler(this.Skin2_Click);
            // 
            // Skin1
            // 
            this.Skin1.BackColor = System.Drawing.Color.SlateGray;
            this.Skin1.Image = global::Game.Properties.Resources.Player;
            this.Skin1.Location = new System.Drawing.Point(15, 84);
            this.Skin1.Name = "Skin1";
            this.Skin1.Size = new System.Drawing.Size(70, 55);
            this.Skin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Skin1.TabIndex = 16;
            this.Skin1.TabStop = false;
            this.Skin1.Click += new System.EventHandler(this.Skin1_Click);
            // 
            // CustMenuCloseButton
            // 
            this.CustMenuCloseButton.BackColor = System.Drawing.Color.Red;
            this.CustMenuCloseButton.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustMenuCloseButton.ForeColor = System.Drawing.Color.White;
            this.CustMenuCloseButton.Location = new System.Drawing.Point(505, 15);
            this.CustMenuCloseButton.Name = "CustMenuCloseButton";
            this.CustMenuCloseButton.Size = new System.Drawing.Size(45, 45);
            this.CustMenuCloseButton.TabIndex = 1;
            this.CustMenuCloseButton.Text = "X";
            this.CustMenuCloseButton.UseVisualStyleBackColor = false;
            this.CustMenuCloseButton.Click += new System.EventHandler(this.CustMenuCloseButton_Click);
            // 
            // CustMenuLabel
            // 
            this.CustMenuLabel.AutoSize = true;
            this.CustMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustMenuLabel.Location = new System.Drawing.Point(16, 15);
            this.CustMenuLabel.Name = "CustMenuLabel";
            this.CustMenuLabel.Size = new System.Drawing.Size(140, 24);
            this.CustMenuLabel.TabIndex = 0;
            this.CustMenuLabel.Text = "Customization";
            // 
            // PauseButton
            // 
            this.PauseButton.BackColor = System.Drawing.Color.White;
            this.PauseButton.BackgroundImage = global::Game.Properties.Resources.pauseButton;
            this.PauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PauseButton.Enabled = false;
            this.PauseButton.Location = new System.Drawing.Point(537, 12);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(50, 50);
            this.PauseButton.TabIndex = 0;
            this.PauseButton.UseVisualStyleBackColor = false;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // PipeUp
            // 
            this.PipeUp.BackColor = System.Drawing.Color.ForestGreen;
            this.PipeUp.Image = global::Game.Properties.Resources.pipe;
            this.PipeUp.Location = new System.Drawing.Point(400, -205);
            this.PipeUp.Name = "PipeUp";
            this.PipeUp.Size = new System.Drawing.Size(55, 425);
            this.PipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeUp.TabIndex = 3;
            this.PipeUp.TabStop = false;
            // 
            // PipeDown
            // 
            this.PipeDown.BackColor = System.Drawing.Color.ForestGreen;
            this.PipeDown.Image = global::Game.Properties.Resources.pipe;
            this.PipeDown.Location = new System.Drawing.Point(400, 350);
            this.PipeDown.Name = "PipeDown";
            this.PipeDown.Size = new System.Drawing.Size(55, 425);
            this.PipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeDown.TabIndex = 2;
            this.PipeDown.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.SlateGray;
            this.Player.Image = global::Game.Properties.Resources.Player;
            this.Player.Location = new System.Drawing.Point(12, 177);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(70, 55);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.Color.Transparent;
            this.coin.Image = global::Game.Properties.Resources.coin;
            this.coin.Location = new System.Drawing.Point(477, 95);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(44, 56);
            this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin.TabIndex = 12;
            this.coin.TabStop = false;
            // 
            // CheatMenu
            // 
            this.CheatMenu.BackColor = System.Drawing.Color.White;
            this.CheatMenu.Controls.Add(this.UnlimMoney);
            this.CheatMenu.Controls.Add(this.AllZero);
            this.CheatMenu.Location = new System.Drawing.Point(406, -310);
            this.CheatMenu.Name = "CheatMenu";
            this.CheatMenu.Size = new System.Drawing.Size(199, 100);
            this.CheatMenu.TabIndex = 16;
            // 
            // AllZero
            // 
            this.AllZero.Location = new System.Drawing.Point(12, 9);
            this.AllZero.Name = "AllZero";
            this.AllZero.Size = new System.Drawing.Size(169, 36);
            this.AllZero.TabIndex = 1;
            this.AllZero.Text = "Все значения: 0";
            this.AllZero.UseVisualStyleBackColor = true;
            this.AllZero.Click += new System.EventHandler(this.AllZero_Click);
            // 
            // UnlimMoney
            // 
            this.UnlimMoney.Location = new System.Drawing.Point(12, 51);
            this.UnlimMoney.Name = "UnlimMoney";
            this.UnlimMoney.Size = new System.Drawing.Size(169, 36);
            this.UnlimMoney.TabIndex = 2;
            this.UnlimMoney.Text = "Деньги в займ";
            this.UnlimMoney.UseVisualStyleBackColor = true;
            this.UnlimMoney.Click += new System.EventHandler(this.UnlimMoney_Click);
            // 
            // SpeedUpL
            // 
            this.SpeedUpL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SpeedUpL.AutoSize = true;
            this.SpeedUpL.BackColor = System.Drawing.Color.White;
            this.SpeedUpL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpeedUpL.Location = new System.Drawing.Point(250, 2000);
            this.SpeedUpL.Name = "SpeedUpL";
            this.SpeedUpL.Size = new System.Drawing.Size(117, 24);
            this.SpeedUpL.TabIndex = 17;
            this.SpeedUpL.Text = "SPEED UP!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(599, 401);
            this.Controls.Add(this.SpeedUpL);
            this.Controls.Add(this.CheatMenu);
            this.Controls.Add(this.CustomizationMenu);
            this.Controls.Add(this.CoinCounter);
            this.Controls.Add(this.StartMenu);
            this.Controls.Add(this.BScore);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.PipeUp);
            this.Controls.Add(this.PipeDown);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.coin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Odnoklassniki travel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Menu.ResumeLayout(false);
            this.StartMenu.ResumeLayout(false);
            this.CustomizationMenu.ResumeLayout(false);
            this.CustomizationMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Skin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            this.CheatMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox PipeDown;
        private System.Windows.Forms.PictureBox PipeUp;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReplayButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label BScore;
        private System.Windows.Forms.Label ScoreM;
        private System.Windows.Forms.Label BScoreM;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button ResumeM;
        private System.Windows.Forms.Panel StartMenu;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label TitleSM;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.Label CoinCounter;
        private System.Windows.Forms.Button CustomizationButton;
        private System.Windows.Forms.Panel CustomizationMenu;
        private System.Windows.Forms.Label CustMenuLabel;
        private System.Windows.Forms.Button CustMenuCloseButton;
        private System.Windows.Forms.PictureBox Skin4;
        private System.Windows.Forms.PictureBox Skin3;
        private System.Windows.Forms.PictureBox Skin2;
        private System.Windows.Forms.PictureBox Skin1;
        private System.Windows.Forms.Label Skin1L;
        private System.Windows.Forms.Label Skin4L;
        private System.Windows.Forms.Label Skin3L;
        private System.Windows.Forms.Label Skin2L;
        private System.Windows.Forms.Label CoinsCountMenu;
        private System.Windows.Forms.Panel CheatMenu;
        private System.Windows.Forms.Button UnlimMoney;
        private System.Windows.Forms.Button AllZero;
        private System.Windows.Forms.Label SpeedUpL;
    }
}

