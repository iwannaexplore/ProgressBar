
namespace ProgressBar
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.readyBox = new System.Windows.Forms.TextBox();
            this.neadedBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Subject = new System.Windows.Forms.TextBox();
            this.history = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(4, 86);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(235, 20);
            this.progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Готово";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Надо";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(96, 109);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(50, 32);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "0%";
            // 
            // readyBox
            // 
            this.readyBox.Location = new System.Drawing.Point(11, 43);
            this.readyBox.Name = "readyBox";
            this.readyBox.Size = new System.Drawing.Size(75, 20);
            this.readyBox.TabIndex = 4;
            // 
            // neadedBox
            // 
            this.neadedBox.Location = new System.Drawing.Point(92, 43);
            this.neadedBox.Name = "neadedBox";
            this.neadedBox.Size = new System.Drawing.Size(75, 20);
            this.neadedBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GetResult);
            // 
            // Subject
            // 
            this.Subject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Subject.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Subject.Location = new System.Drawing.Point(38, 1);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(157, 23);
            this.Subject.TabIndex = 7;
            this.Subject.Text = "Предмет";
            this.Subject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // history
            // 
            this.history.Location = new System.Drawing.Point(4, 165);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(235, 170);
            this.history.TabIndex = 8;
            this.history.Text = "C# Pro - 10.05.2000 - 14/305 - 35%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "История";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(249, 347);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.history);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.neadedBox);
            this.Controls.Add(this.readyBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прогресс";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox readyBox;
        private System.Windows.Forms.TextBox neadedBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.RichTextBox history;
        private System.Windows.Forms.Label label4;
    }
}

