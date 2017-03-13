namespace WindowsFormsApplication1
{
    partial class SpamForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.spambaton1 = new System.Windows.Forms.Button();
            this.spam = new System.Windows.Forms.Button();
            this.spambaton3 = new System.Windows.Forms.Button();
            this.spambaton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // spambaton1
            // 
            this.spambaton1.Location = new System.Drawing.Point(639, 391);
            this.spambaton1.Name = "spambaton1";
            this.spambaton1.Size = new System.Drawing.Size(75, 23);
            this.spambaton1.TabIndex = 0;
            this.spambaton1.Text = "button1";
            this.spambaton1.UseVisualStyleBackColor = true;
            // 
            // spam
            // 
            this.spam.Location = new System.Drawing.Point(387, 231);
            this.spam.Name = "spam";
            this.spam.Size = new System.Drawing.Size(75, 23);
            this.spam.TabIndex = 1;
            this.spam.Text = "button1";
            this.spam.UseVisualStyleBackColor = true;
            // 
            // spambaton3
            // 
            this.spambaton3.Location = new System.Drawing.Point(387, 145);
            this.spambaton3.Name = "spambaton3";
            this.spambaton3.Size = new System.Drawing.Size(75, 23);
            this.spambaton3.TabIndex = 2;
            this.spambaton3.Text = "button1";
            this.spambaton3.UseVisualStyleBackColor = true;
            // 
            // spambaton2
            // 
            this.spambaton2.Location = new System.Drawing.Point(387, 62);
            this.spambaton2.Name = "spambaton2";
            this.spambaton2.Size = new System.Drawing.Size(75, 23);
            this.spambaton2.TabIndex = 3;
            this.spambaton2.Text = "button1";
            this.spambaton2.UseVisualStyleBackColor = true;
            // 
            // SpamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 496);
            this.Controls.Add(this.spambaton2);
            this.Controls.Add(this.spambaton3);
            this.Controls.Add(this.spam);
            this.Controls.Add(this.spambaton1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SpamForm";
            this.Text = "SpamForm";
            this.Load += new System.EventHandler(this.SpamForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button spambaton1;
        private System.Windows.Forms.Button spam;
        private System.Windows.Forms.Button spambaton3;
        private System.Windows.Forms.Button spambaton2;
    }
}