namespace War
{
    partial class FrmWar
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.btnBattle = new System.Windows.Forms.Button();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.lblStats1 = new System.Windows.Forms.Label();
            this.lblStats2 = new System.Windows.Forms.Label();
            this.chkSlowPlay = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(168, 75);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 43);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Shuffle And Redeal";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnReStart_Click);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(23, 23);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(45, 13);
            this.lblPlayer1.TabIndex = 1;
            this.lblPlayer1.Text = "Player 1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(258, 23);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(45, 13);
            this.lblPlayer2.TabIndex = 2;
            this.lblPlayer2.Text = "Player 2";
            // 
            // btnBattle
            // 
            this.btnBattle.Location = new System.Drawing.Point(168, 23);
            this.btnBattle.Name = "btnBattle";
            this.btnBattle.Size = new System.Drawing.Size(75, 23);
            this.btnBattle.TabIndex = 0;
            this.btnBattle.Text = "Battle";
            this.btnBattle.UseVisualStyleBackColor = true;
            this.btnBattle.Click += new System.EventHandler(this.btnBattle_Click);
            // 
            // rtbResults
            // 
            this.rtbResults.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResults.Location = new System.Drawing.Point(26, 130);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.Size = new System.Drawing.Size(368, 216);
            this.rtbResults.TabIndex = 5;
            this.rtbResults.Text = "";
            // 
            // lblStats1
            // 
            this.lblStats1.Location = new System.Drawing.Point(26, 52);
            this.lblStats1.Name = "lblStats1";
            this.lblStats1.Size = new System.Drawing.Size(136, 63);
            this.lblStats1.TabIndex = 6;
            // 
            // lblStats2
            // 
            this.lblStats2.Location = new System.Drawing.Point(258, 52);
            this.lblStats2.Name = "lblStats2";
            this.lblStats2.Size = new System.Drawing.Size(136, 63);
            this.lblStats2.TabIndex = 7;
            // 
            // chkSlowPlay
            // 
            this.chkSlowPlay.AutoSize = true;
            this.chkSlowPlay.Location = new System.Drawing.Point(168, 52);
            this.chkSlowPlay.Name = "chkSlowPlay";
            this.chkSlowPlay.Size = new System.Drawing.Size(78, 17);
            this.chkSlowPlay.TabIndex = 8;
            this.chkSlowPlay.Text = "Slow Play?";
            this.chkSlowPlay.UseVisualStyleBackColor = true;
            // 
            // FrmWar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 358);
            this.Controls.Add(this.chkSlowPlay);
            this.Controls.Add(this.lblStats2);
            this.Controls.Add(this.lblStats1);
            this.Controls.Add(this.rtbResults);
            this.Controls.Add(this.btnBattle);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.btnStart);
            this.Name = "FrmWar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "War!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Button btnBattle;
        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.Label lblStats1;
        private System.Windows.Forms.Label lblStats2;
        private System.Windows.Forms.CheckBox chkSlowPlay;
    }
}

