namespace Lesson_7_HomeWork_WF
{
    partial class Game2
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
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblCmdCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(441, 75);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(166, 62);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "button1";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMultiply.Location = new System.Drawing.Point(441, 191);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(166, 62);
            this.btnMultiply.TabIndex = 1;
            this.btnMultiply.Text = "button2";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(441, 304);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(166, 62);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "button3";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNum.Location = new System.Drawing.Point(227, 207);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(32, 32);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "0";
            this.lblNum.Click += new System.EventHandler(this.lblNum_Click);
            // 
            // lblCmdCounter
            // 
            this.lblCmdCounter.AutoSize = true;
            this.lblCmdCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCmdCounter.Location = new System.Drawing.Point(152, 292);
            this.lblCmdCounter.Name = "lblCmdCounter";
            this.lblCmdCounter.Size = new System.Drawing.Size(158, 29);
            this.lblCmdCounter.TabIndex = 4;
            this.lblCmdCounter.Text = "Всего ходов:";
            this.lblCmdCounter.Click += new System.EventHandler(this.lblCmdCounter_Click);
            // 
            // Game2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCmdCounter);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnPlus);
            this.Name = "Game2";
            this.Text = "Game2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblCmdCounter;
    }
}