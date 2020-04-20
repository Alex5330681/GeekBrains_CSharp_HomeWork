namespace Lesson_7_HomeWork_WF
{
    partial class MainMenu
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
            this.btnGame1 = new System.Windows.Forms.Button();
            this.btnGame2 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGame1
            // 
            this.btnGame1.BackColor = System.Drawing.SystemColors.Info;
            this.btnGame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGame1.Location = new System.Drawing.Point(204, 113);
            this.btnGame1.Name = "btnGame1";
            this.btnGame1.Size = new System.Drawing.Size(409, 66);
            this.btnGame1.TabIndex = 0;
            this.btnGame1.Text = "Игра \"Угадай число\"";
            this.btnGame1.UseVisualStyleBackColor = false;
            this.btnGame1.Click += new System.EventHandler(this.btnGame1_Click);
            // 
            // btnGame2
            // 
            this.btnGame2.BackColor = System.Drawing.SystemColors.Info;
            this.btnGame2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGame2.Location = new System.Drawing.Point(204, 201);
            this.btnGame2.Name = "btnGame2";
            this.btnGame2.Size = new System.Drawing.Size(409, 66);
            this.btnGame2.TabIndex = 1;
            this.btnGame2.Text = "Игра \"Удвоитель\"";
            this.btnGame2.UseVisualStyleBackColor = false;
            this.btnGame2.Click += new System.EventHandler(this.btnGame2_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Info;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(204, 285);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(409, 66);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "ВЫХОД";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGame2);
            this.Controls.Add(this.btnGame1);
            this.Name = "Form1";
            this.Text = "MENU GAME";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGame1;
        private System.Windows.Forms.Button btnGame2;
        private System.Windows.Forms.Button btnExit;
    }
}

