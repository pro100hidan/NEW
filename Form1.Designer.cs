
namespace FORM_PROGET
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
            this.CALL = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CALL
            // 
            this.CALL.AutoSize = true;
            this.CALL.Location = new System.Drawing.Point(41, 53);
            this.CALL.Name = "CALL";
            this.CALL.Size = new System.Drawing.Size(100, 50);
            this.CALL.TabIndex = 0;
            this.CALL.Text = "Нажми!!!";
            this.CALL.UseVisualStyleBackColor = true;
            this.CALL.Click += new System.EventHandler(this.CALL_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "ОНА ЗАКРОЕТ ПРОГРАММУ";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CALL);
            this.MaximumSize = new System.Drawing.Size(200, 200);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "Form1";
            this.Text = "хе-хе";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CALL;
        private System.Windows.Forms.TextBox textBox1;
    }
}

