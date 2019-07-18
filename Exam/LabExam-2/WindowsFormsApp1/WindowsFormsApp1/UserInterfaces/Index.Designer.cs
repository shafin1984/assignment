namespace WindowsFormsApp1
{
    partial class indexForm
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
            this.FirstButton = new System.Windows.Forms.Button();
            this.SecondButton = new System.Windows.Forms.Button();
            this.ThirdButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstButton
            // 
            this.FirstButton.Location = new System.Drawing.Point(123, 95);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(423, 37);
            this.FirstButton.TabIndex = 0;
            this.FirstButton.Text = "Save Customer and Account Info";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // SecondButton
            // 
            this.SecondButton.Location = new System.Drawing.Point(123, 163);
            this.SecondButton.Name = "SecondButton";
            this.SecondButton.Size = new System.Drawing.Size(423, 37);
            this.SecondButton.TabIndex = 1;
            this.SecondButton.Text = "Transaction";
            this.SecondButton.UseVisualStyleBackColor = true;
            this.SecondButton.Click += new System.EventHandler(this.SecondButton_Click);
            // 
            // ThirdButton
            // 
            this.ThirdButton.Location = new System.Drawing.Point(123, 227);
            this.ThirdButton.Name = "ThirdButton";
            this.ThirdButton.Size = new System.Drawing.Size(423, 37);
            this.ThirdButton.TabIndex = 2;
            this.ThirdButton.Text = "Search Customer and Account Info";
            this.ThirdButton.UseVisualStyleBackColor = true;
            this.ThirdButton.Click += new System.EventHandler(this.ThirdButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 100;
            this.label1.Text = "Banking System";
            // 
            // indexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ThirdButton);
            this.Controls.Add(this.SecondButton);
            this.Controls.Add(this.FirstButton);
            this.Name = "indexForm";
            this.Text = "Index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button SecondButton;
        private System.Windows.Forms.Button ThirdButton;
        private System.Windows.Forms.Label label1;
    }
}

