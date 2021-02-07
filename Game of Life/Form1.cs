using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_Life
{
    public partial class Game : Form
    {
        
        private Graphics graphics;
        private int resolution;
        private GameEngine gameEngine;
        public Game()
        {
            InitializeComponent();
        }
        private void StartGame()
        {
            if(timerG.Enabled)
            {
                return;
            }

            numResolution.Enabled = false;
            numPlot.Enabled = false;
            resolution = (int)numResolution.Value;
            gameEngine = new GameEngine
            (
                rows: pictureBoxGame.Height / resolution,
                cols: pictureBoxGame.Width / resolution,
                density:(int)(numPlot.Minimum)+ (int)numPlot.Maximum - (int)numPlot.Value
            );
            labelCur.Text = $"Generation: {gameEngine.CurGen}";
            pictureBoxGame.Image = new Bitmap(pictureBoxGame.Width, pictureBoxGame.Height);
            graphics = Graphics.FromImage(pictureBoxGame.Image);
            timerG.Start();
        }
        private void NextGeneration()
        {
            graphics.Clear(Color.MintCream);
            var field = gameEngine.GetCurGen();
            for(int x = 0;  x < field.GetLength(0); x++)
            {
                for(int y = 0; y < field.GetLength(1); y++)
                {
                    if(field[x,y])
                        graphics.FillRectangle(Brushes.MediumSpringGreen, x * resolution, y * resolution, resolution - 1, resolution - 1);
                }
            }
            pictureBoxGame.Refresh();
            labelCur.Text = $"Generation: {gameEngine.CurGen}";
            gameEngine.NextGeneration();
        }
        private void StopGame()
        {
            if (!timerG.Enabled)
                return;
            timerG.Stop();
            numResolution.Enabled = true;
            numPlot.Enabled = true;
        }
        
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void pictureBoxGame_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (!timerG.Enabled)
                return;
            if (e.Button == MouseButtons.Left)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                gameEngine.AddCell(x, y);
            }
            if (e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                gameEngine.RemoveCell(x, y);
            }
        }
    }
}
