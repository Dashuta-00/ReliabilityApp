
namespace НадёжностьЭлементов
{
    partial class TheFirstPresentationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.DataBaseButton = new System.Windows.Forms.Button();
            this.ReliabilityButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Здравствуйте!\r\nС чем будете работать?";
            // 
            // DataBaseButton
            // 
            this.DataBaseButton.Location = new System.Drawing.Point(58, 139);
            this.DataBaseButton.Name = "DataBaseButton";
            this.DataBaseButton.Size = new System.Drawing.Size(129, 65);
            this.DataBaseButton.TabIndex = 1;
            this.DataBaseButton.Text = "База данных";
            this.DataBaseButton.UseVisualStyleBackColor = true;
            this.DataBaseButton.Click += new System.EventHandler(this.DataBaseButton_Click);
            // 
            // ReliabilityButton
            // 
            this.ReliabilityButton.Location = new System.Drawing.Point(287, 139);
            this.ReliabilityButton.Name = "ReliabilityButton";
            this.ReliabilityButton.Size = new System.Drawing.Size(141, 65);
            this.ReliabilityButton.TabIndex = 2;
            this.ReliabilityButton.Text = "Расчёт надежности";
            this.ReliabilityButton.UseVisualStyleBackColor = true;
            this.ReliabilityButton.Click += new System.EventHandler(this.ReliabilityButton_Click);
            // 
            // TheFirstPresentationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 255);
            this.Controls.Add(this.ReliabilityButton);
            this.Controls.Add(this.DataBaseButton);
            this.Controls.Add(this.label1);
            this.Name = "TheFirstPresentationForm";
            this.Text = "Приветствие";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DataBaseButton;
        private System.Windows.Forms.Button ReliabilityButton;
    }
}