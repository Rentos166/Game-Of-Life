namespace Game_of_Life
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.splitContainerGame = new System.Windows.Forms.SplitContainer();
            this.labelCur = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.numPlot = new System.Windows.Forms.NumericUpDown();
            this.labelPlot = new System.Windows.Forms.Label();
            this.numResolution = new System.Windows.Forms.NumericUpDown();
            this.labelResolution = new System.Windows.Forms.Label();
            this.pictureBoxGame = new System.Windows.Forms.PictureBox();
            this.timerG = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGame)).BeginInit();
            this.splitContainerGame.Panel1.SuspendLayout();
            this.splitContainerGame.Panel2.SuspendLayout();
            this.splitContainerGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerGame
            // 
            this.splitContainerGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerGame.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerGame.IsSplitterFixed = true;
            this.splitContainerGame.Location = new System.Drawing.Point(0, 0);
            this.splitContainerGame.Name = "splitContainerGame";
            // 
            // splitContainerGame.Panel1
            // 
            this.splitContainerGame.Panel1.BackColor = System.Drawing.Color.Azure;
            this.splitContainerGame.Panel1.Controls.Add(this.labelCur);
            this.splitContainerGame.Panel1.Controls.Add(this.buttonStop);
            this.splitContainerGame.Panel1.Controls.Add(this.buttonStart);
            this.splitContainerGame.Panel1.Controls.Add(this.numPlot);
            this.splitContainerGame.Panel1.Controls.Add(this.labelPlot);
            this.splitContainerGame.Panel1.Controls.Add(this.numResolution);
            this.splitContainerGame.Panel1.Controls.Add(this.labelResolution);
            // 
            // splitContainerGame.Panel2
            // 
            this.splitContainerGame.Panel2.Controls.Add(this.pictureBoxGame);
            this.splitContainerGame.Size = new System.Drawing.Size(926, 411);
            this.splitContainerGame.SplitterDistance = 194;
            this.splitContainerGame.TabIndex = 0;
            this.splitContainerGame.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // labelCur
            // 
            this.labelCur.AutoSize = true;
            this.labelCur.BackColor = System.Drawing.Color.Azure;
            this.labelCur.Font = new System.Drawing.Font("OCR A Extended", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCur.ForeColor = System.Drawing.Color.LightCoral;
            this.labelCur.Location = new System.Drawing.Point(7, 272);
            this.labelCur.Name = "labelCur";
            this.labelCur.Size = new System.Drawing.Size(129, 17);
            this.labelCur.TabIndex = 6;
            this.labelCur.Text = "Generation:";
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Teal;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStop.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.ForeColor = System.Drawing.Color.Indigo;
            this.buttonStop.Location = new System.Drawing.Point(10, 169);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(170, 41);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Teal;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.Indigo;
            this.buttonStart.Location = new System.Drawing.Point(10, 122);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(170, 41);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // numPlot
            // 
            this.numPlot.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPlot.Location = new System.Drawing.Point(10, 83);
            this.numPlot.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numPlot.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numPlot.Name = "numPlot";
            this.numPlot.Size = new System.Drawing.Size(170, 24);
            this.numPlot.TabIndex = 3;
            this.numPlot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPlot.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // labelPlot
            // 
            this.labelPlot.AutoSize = true;
            this.labelPlot.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlot.ForeColor = System.Drawing.Color.Indigo;
            this.labelPlot.Location = new System.Drawing.Point(3, 63);
            this.labelPlot.Name = "labelPlot";
            this.labelPlot.Size = new System.Drawing.Size(96, 17);
            this.labelPlot.TabIndex = 2;
            this.labelPlot.Text = "Density:";
            // 
            // numResolution
            // 
            this.numResolution.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numResolution.Location = new System.Drawing.Point(10, 32);
            this.numResolution.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numResolution.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numResolution.Name = "numResolution";
            this.numResolution.Size = new System.Drawing.Size(170, 24);
            this.numResolution.TabIndex = 1;
            this.numResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numResolution.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResolution.ForeColor = System.Drawing.Color.Indigo;
            this.labelResolution.Location = new System.Drawing.Point(3, 12);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(129, 17);
            this.labelResolution.TabIndex = 0;
            this.labelResolution.Text = "Resolution:";
            // 
            // pictureBoxGame
            // 
            this.pictureBoxGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxGame.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxGame.Name = "pictureBoxGame";
            this.pictureBoxGame.Size = new System.Drawing.Size(724, 407);
            this.pictureBoxGame.TabIndex = 0;
            this.pictureBoxGame.TabStop = false;
            this.pictureBoxGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxGame_MouseMove_1);
            // 
            // timerG
            // 
            this.timerG.Interval = 40;
            this.timerG.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 411);
            this.Controls.Add(this.splitContainerGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "Game Of Life";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Game_Load);
            this.splitContainerGame.Panel1.ResumeLayout(false);
            this.splitContainerGame.Panel1.PerformLayout();
            this.splitContainerGame.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGame)).EndInit();
            this.splitContainerGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerGame;
        private System.Windows.Forms.NumericUpDown numResolution;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.PictureBox pictureBoxGame;
        private System.Windows.Forms.NumericUpDown numPlot;
        private System.Windows.Forms.Label labelPlot;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timerG;
        private System.Windows.Forms.Label labelCur;
    }
}

