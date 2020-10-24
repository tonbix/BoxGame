using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int x = 20;
        public int y = 200;
        public int step = 10; //шаг движения по вертикали (8)
        public int stepHorizont = 3; //шаг движения по горизонтали (2)
        public int stepPipe = 5; //шаг движения трубы (5)
        public int PipesX = 400;
        public int PipesY = 140;
        public bool up = false;
        public bool down = false;
        public bool left = false;
        public bool right = false;
        public int pipeUpY;
        public Random rnd = new Random();
        public int score = 0;
        public int score1 = 0;
        public int bestScore = 0;
        public double speedAcc = 10;
        public int height = 0;
        public bool pause = false;
        public bool death = false;
        public int coinY = 440;
        public int coinsCount = 0;//кол-во монет (0)
        public int coinX = 110;
        public int skin = 1;
        public int coinSpawn = 1;
        public int skinNumber = 1;
        public int SpeedUpTime = 0;

        public bool skin2B = false;//купленные скины
        public bool skin3B = false;
        public bool skin4B = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DataLoad();
                if(skinNumber == 1)
            {

                this.Skin1Ch();
            }

                if (skinNumber == 2)
            {
                this.Skin2Ch();
            }

                if (skinNumber == 3)
            {
                this.Skin3Ch();
            }

                if (skinNumber == 4)
            {
                this.Skin4Ch();
            }

            StartMenu.Top = 125;
            StartMenu.Visible = true;
            CoinCounter.Text = "Coins: " + coinsCount;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.W:
                    up = true;
                    break;

                case Keys.S:
                    down = true;
                    break;

                case Keys.D:
                    right = true;
                    break;

                case Keys.A:
                    left = true;
                    break;

                case Keys.Escape:
                    this.PauseMenu();    
                    break;
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {//START//START//START//START//START//START//START//START//START//START//START//START//START//START//START//START//START//START//START//START//START//START//START//
            if (SpeedUpTime == 0)
            {
                SpeedUpL.Top = 2000;
                SpeedUpL.Left = 250;
            }
            SpeedUpTime--;
            //variable
            bool intersectedUp = Player.Bounds.IntersectsWith(PipeUp.Bounds);
            bool intersectedDown = Player.Bounds.IntersectsWith(PipeDown.Bounds);
            bool intersectedCoin = Player.Bounds.IntersectsWith(coin.Bounds);
            bool intersectedCoinUp = coin.Bounds.IntersectsWith(PipeUp.Bounds);
            bool intersectedCoinDown = coin.Bounds.IntersectsWith(PipeDown.Bounds);

            //walls
            if (y < 0)
            {
                y = 10;
            }
            if (y + Player.Height * 2 > this.Size.Height)
            {
                y = this.Size.Height - 105;
            }
            if (x < 0)
            {
                x = 10;
            }
            if (x > this.Size.Width - Player.Width)
            {
                x = this.Size.Width - Player.Width;
            }

           //whenPipeLoop
            if (PipeDown.Location.X < -100)
            {
                coinSpawn = rnd.Next(0, 10);
                PipesX = 650;
                PipesY = rnd.Next(110, 400);
                score++;
                score1++;
                if(bestScore < score)
                {
                    bestScore = score;
                }
                if(score1 == speedAcc)
                {
                    stepPipe += 2;
                    speedAcc += 15;
                    score1 = 0;
                    SpeedUpL.Top = 200;
                    SpeedUpL.Left = 250;
                    SpeedUpTime = 50;
                }
            }

            //whenCoinLoop
            if (coin.Location.X < -100)
            {
                if (coinSpawn == 5)
                {
                    coinY = rnd.Next(110, 350);
                    coinX = rnd.Next(700, 900);
                }         
            }
            if(intersectedCoinDown || intersectedCoinUp)
            {
                coinY = rnd.Next(110, 350);
                coinX = rnd.Next(700, 900);
            }

          //colision|deathTrigger
            if (intersectedUp || intersectedDown) 
            {
                death = true;
                ResumeM.Visible = false;
                label1.Text = "Game over";
                timer1.Stop();
                Menu.Visible = true;
                while (height < 247) 
                {
                    height += 2;
                    Menu.Height = height;
                }
                ScoreM.Text = "Your score: " + score;
                BScoreM.Text = "Your best score: " + bestScore;
            }

            //colision|coinIntersect
            if (intersectedCoin)
            {
                coinY = -1000;
                coinsCount++;
                CoinCounter.Text = "Coins: " + coinsCount;
            }
           
           //moving
            y = up ? y - step : y;
            y = down ? y + step : y;
            x = left ? x - stepHorizont : x;
            x = right ? x + stepHorizont : x;

            //always repeating actions
            PipesX -= stepPipe;
            coinX -= stepPipe;
            PipeDown.Left = PipeUp.Left = PipesX;

            pipeUpY = (PipeDown.Location.Y - PipeUp.Height) - 110;
            coin.Left = coinX;
            Player.Left = x;
            Player.Top = y;
            coin.Top = coinY;
            PipeDown.Top = PipesY;
            PipeUp.Top = pipeUpY;
            Score.Text = "Score: " + score;
            BScore.Text = "Best score: " + bestScore;

        }//END///END//END//END//END//END//END//END//END//END//END//END//END//END//END//END//END//END//END//END//END//

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    up = false;
                    break;

                case Keys.S:
                    down = false;
                    break;

                case Keys.D:
                    right = false;
                    break;

                case Keys.A:
                    left = false;
                    break;
            }
        }

        private void RestartButton_Click(object sender, EventArgs e) //restart
        {
            death = false;
            PipeUp.Left = 400;
            PipeDown.Left = 400;
            Player.Left = 10;
            x = 10;
            PipesX = 400;
            height = 0;
            Menu.Visible = false;
            this.StartGame();
            score = score1 = 0;
            stepPipe = 5; // (5)
        }

        private void CloseButton_Click(object sender, EventArgs e)//menu close button 
        {
            this.Close();
            this.DataSave();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (death == false)
            {
                this.PauseMenu();
            }           
        }
        private void StartGame()
        {
            timer1.Start();
            this.Focus();
        }

        private void PauseMenu()
        {
            if (death == false)
            {
                ScoreM.Text = "Your score: " + score;
                BScoreM.Text = "Your best score: " + bestScore;
                pause = true;
                ResumeM.Visible = true;
                timer1.Stop();
                label1.Text = "Pause";
                Menu.Visible = true;
                while (height < 361)
                {
                    height += 2;
                    Menu.Height = height;
                }
            }
        }
        private void resume()
        {
            pause = false;
            height = 0;
            Menu.Visible = false;
            this.StartGame();
        }

        private void ResumeM_Click(object sender, EventArgs e)
        {
            this.resume();
        }

        private void CustomizationButton_Click(object sender, EventArgs e)
        {
            CustomizationMenu.Top = 12;
            CustomizationMenu.Visible = true;
            CoinsCountMenu.Text = "Coins " + coinsCount;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            PauseButton.Enabled = true;
            this.resume();
            StartMenu.Left = 500;
            StartMenu.Visible = false;
            this.Focus();

        }

        private void CustMenuCloseButton_Click(object sender, EventArgs e)
        {
            CustomizationMenu.Top = -1000;
            CustomizationMenu.Visible = false;
        }

        private void Skin1_Click(object sender, EventArgs e)
        {
            this.Skin1Ch();
        }

        private void Skin2_Click(object sender, EventArgs e)
        {
            if (skin2B == true)
            {
                this.Skin2Ch();
            }
            else if(coinsCount >= 10)
            {
                skin2B = true;
                Skin2L.Text = "Uninstalled";
                coinsCount -= 10;
                CoinCounter.Text = "Coins: " + coinsCount;
                CoinsCountMenu.Text = "Coins: " + coinsCount;
            }
        }

        private void Skin3_Click(object sender, EventArgs e)
        {
            if(skin3B == true)
            {
                this.Skin3Ch();
            }
            else if (coinsCount >= 50)
            {
                skin3B = true;
                Skin3L.Text = "Uninstalled";
                coinsCount -= 50;
                CoinCounter.Text = "Coins: " + coinsCount;
                CoinsCountMenu.Text = "Coins: " + coinsCount;
            }
        }

        private void Skin4_Click(object sender, EventArgs e)
        {
            if(skin4B == true)
            {
                this.Skin4Ch();
            }
            else if (coinsCount >= 25)
            {
                skin4B = true;
                Skin4L.Text = "Uninstalled";
                coinsCount -= 25;
                CoinCounter.Text = "Coins: " + coinsCount;
                CoinsCountMenu.Text = "Coins: " + coinsCount;
            }
        }

        private void DataSave()
        {
            /*FileStream file = File.Create(@"./save.txt");
            byte[] text = Encoding.UTF8.GetBytes(coinsCount + "\r\n" + skinNumber + "\r\n" + bestScore + "\r\n" + skin2B + "\r\n" + skin3B + "\r\n" + skin4B);
            file.Write(text, 0, text.Length);*/
            //file.Close();
            using (var stream = new FileStream("save.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            using (var writer = new BinaryWriter(stream))
            {
                writer.Write(coinsCount);
                writer.Write(skinNumber);
                writer.Write(bestScore);
                writer.Write(skin2B);
                writer.Write(skin3B);
                writer.Write(skin4B);
            }
        }
        private void DataLoad()
        {
            var array = new int[] { coinsCount, skinNumber, bestScore, Convert.ToInt32(skin2B), Convert.ToInt32(skin3B), Convert.ToInt32(skin4B) };
            using (var stream = new FileStream("save.bin", FileMode.Open, FileAccess.Read, FileShare.None))
            using (var reader = new BinaryReader(stream))
            {
                coinsCount = reader.ReadInt32();
                skinNumber = reader.ReadInt32();
                bestScore = reader.ReadInt32();
                skin2B = reader.ReadBoolean();
                skin3B = reader.ReadBoolean();
                skin4B = reader.ReadBoolean();
            }
        }
        private void Skin1Ch()
        {
            Player.Image = Game.Properties.Resources.Player;
            skinNumber = 1;
            Skin1L.Text = "Installed";
            if (skin2B == true)
            {
                Skin2L.Text = "Uninstalled";
            }
            else
            {
                Skin2L.Text = "Buy: 10";
            }
            if (skin3B == true)
            {
                Skin3L.Text = "Uninstalled";
            }
            else
            {
                Skin3L.Text = "Buy: 50";
            }
            if (skin4B == true)
            {
                Skin4L.Text = "Uninstalled";
            }
            else
            {
                Skin4L.Text = "Buy: 25";
            }
        }
        private void Skin2Ch()
        {
            Player.Image = Game.Properties.Resources.AAAAAAAAAAAAAAAAAAA;
            skinNumber = 2;
            Skin2L.Text = "Installed";
            Skin1L.Text = "Uninstalled";
            if (skin3B == true)
            {
                Skin3L.Text = "Uninstalled";
            }
            if (skin4B == true)
            {
                Skin4L.Text = "Uninstalled";
            }
        }
        private void Skin3Ch()
        {
            Player.Image = Game.Properties.Resources._60_оттенков_скителса;
            skinNumber = 3;
            Skin3L.Text = "Installed";
            Skin1L.Text = "Uninstalled";
            if (skin2B == true)
            {
                Skin2L.Text = "Uninstalled";
            }
            if (skin4B == true)
            {
                Skin4L.Text = "Uninstalled";
            }
        }
        private void Skin4Ch()
        {
            Player.Image = Game.Properties.Resources.котек;
            skinNumber = 4;
            Skin4L.Text = "Installed";
            Skin1L.Text = "Uninstalled";
            if (skin2B == true)
            {
                Skin2L.Text = "Uninstalled";
            }
            if (skin3B == true)
            {
                Skin3L.Text = "Uninstalled";
            }
        }

        private void AllZero_Click(object sender, EventArgs e)
        {
            coinsCount = 0;
            bestScore = 0;
            score = 0;
            skin2B = false;
            skin3B = false;
            skin4B = false;
            this.Skin1Ch();
            CoinCounter.Text = "Coins: " + coinsCount;
        }

        private void UnlimMoney_Click(object sender, EventArgs e)
        {
            coinsCount = 99999;
            CoinCounter.Text = "Coins: " + coinsCount;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DataSave();
        }
    }
}
