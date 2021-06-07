
namespace Task1._2
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
            this.RunBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunBtn
            // 
            this.RunBtn.AutoSize = true;
            this.RunBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunBtn.Location = new System.Drawing.Point(129, 201);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(109, 39);
            this.RunBtn.TabIndex = 0;
            this.RunBtn.Text = "Run";
            this.RunBtn.UseVisualStyleBackColor = true;
            this.RunBtn.MouseEnter += new System.EventHandler(this.RunBtn_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RunBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RunBtn;
    }
}

