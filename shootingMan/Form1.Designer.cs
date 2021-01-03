namespace shootingMan
{
    partial class Form1
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
            this.enemyThree = new System.Windows.Forms.PictureBox();
            this.enemyTwo = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.Kain = new System.Windows.Forms.PictureBox();
            this.enemyOne = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).BeginInit();
            this.SuspendLayout();
            // 
            // enemyThree
            // 
            this.enemyThree.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.enemyThree.Cursor = System.Windows.Forms.Cursors.Default;
            this.enemyThree.Image = global::shootingMan.Properties.Resources._8_2_zombie_png;
            this.enemyThree.Location = new System.Drawing.Point(639, 2);
            this.enemyThree.Name = "enemyThree";
            this.enemyThree.Size = new System.Drawing.Size(111, 183);
            this.enemyThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyThree.TabIndex = 6;
            this.enemyThree.TabStop = false;
            // 
            // enemyTwo
            // 
            this.enemyTwo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.enemyTwo.Cursor = System.Windows.Forms.Cursors.Default;
            this.enemyTwo.Image = global::shootingMan.Properties.Resources._8_2_zombie_png;
            this.enemyTwo.Location = new System.Drawing.Point(373, 12);
            this.enemyTwo.Name = "enemyTwo";
            this.enemyTwo.Size = new System.Drawing.Size(111, 183);
            this.enemyTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyTwo.TabIndex = 5;
            this.enemyTwo.TabStop = false;
            // 
            // bullet
            // 
            this.bullet.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bullet.Image = global::shootingMan.Properties.Resources.bullets_PNG35565;
            this.bullet.Location = new System.Drawing.Point(384, 393);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(37, 33);
            this.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet.TabIndex = 4;
            this.bullet.TabStop = false;
            // 
            // Kain
            // 
            this.Kain.Image = global::shootingMan.Properties.Resources.shoot;
            this.Kain.Location = new System.Drawing.Point(358, 443);
            this.Kain.Name = "Kain";
            this.Kain.Size = new System.Drawing.Size(82, 79);
            this.Kain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Kain.TabIndex = 3;
            this.Kain.TabStop = false;
            // 
            // enemyOne
            // 
            this.enemyOne.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.enemyOne.Cursor = System.Windows.Forms.Cursors.Default;
            this.enemyOne.Image = global::shootingMan.Properties.Resources._8_2_zombie_png;
            this.enemyOne.Location = new System.Drawing.Point(85, 12);
            this.enemyOne.Name = "enemyOne";
            this.enemyOne.Size = new System.Drawing.Size(111, 183);
            this.enemyOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyOne.TabIndex = 0;
            this.enemyOne.TabStop = false;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score.ForeColor = System.Drawing.Color.Red;
            this.score.Location = new System.Drawing.Point(12, 281);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(24, 25);
            this.score.TabIndex = 7;
            this.score.Text = "0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(821, 545);
            this.Controls.Add(this.score);
            this.Controls.Add(this.enemyThree);
            this.Controls.Add(this.enemyTwo);
            this.Controls.Add(this.Kain);
            this.Controls.Add(this.enemyOne);
            this.Controls.Add(this.bullet);
            this.Name = "Form1";
            this.Text = "Shhoooot";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox enemyOne;
        private System.Windows.Forms.PictureBox Kain;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.PictureBox enemyTwo;
        private System.Windows.Forms.PictureBox enemyThree;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Timer gameTimer;
    }
}

