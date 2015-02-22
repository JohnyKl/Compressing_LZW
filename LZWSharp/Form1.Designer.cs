namespace LZWSharp
{
    partial class Form1
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
            this.btnPack = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnUnpack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPack
            // 
            this.btnPack.Location = new System.Drawing.Point(12, 65);
            this.btnPack.Name = "btnPack";
            this.btnPack.Size = new System.Drawing.Size(82, 23);
            this.btnPack.TabIndex = 0;
            this.btnPack.Text = "Упаковать";
            this.btnPack.UseVisualStyleBackColor = true;
            this.btnPack.Click += new System.EventHandler(this.btnPack_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 25);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(497, 20);
            this.txtPath.TabIndex = 1;
            // 
            // btnUnpack
            // 
            this.btnUnpack.Location = new System.Drawing.Point(112, 65);
            this.btnUnpack.Name = "btnUnpack";
            this.btnUnpack.Size = new System.Drawing.Size(88, 23);
            this.btnUnpack.TabIndex = 2;
            this.btnUnpack.Text = "Распаковать";
            this.btnUnpack.UseVisualStyleBackColor = true;
            this.btnUnpack.Click += new System.EventHandler(this.btnUnpack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 287);
            this.Controls.Add(this.btnUnpack);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnPack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPack;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnUnpack;
    }
}

