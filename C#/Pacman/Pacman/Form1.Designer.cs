namespace Pacman
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
            this.goButton = new System.Windows.Forms.Button();
            this.pacClosed = new System.Windows.Forms.PictureBox();
            this.pacOpen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pacClosed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(171, 201);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(118, 57);
            this.goButton.TabIndex = 0;
            this.goButton.Text = "Go!!!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // pacClosed
            // 
            this.pacClosed.Image = global::Pacman.Properties.Resources.pacMouthClosed1;
            this.pacClosed.Location = new System.Drawing.Point(-1, 1);
            this.pacClosed.Name = "pacClosed";
            this.pacClosed.Size = new System.Drawing.Size(51, 49);
            this.pacClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pacClosed.TabIndex = 1;
            this.pacClosed.TabStop = false;
            this.pacClosed.Visible = false;
            // 
            // pacOpen
            // 
            this.pacOpen.Image = global::Pacman.Properties.Resources.pacMouthOpen;
            this.pacOpen.Location = new System.Drawing.Point(-1, 1);
            this.pacOpen.Name = "pacOpen";
            this.pacOpen.Size = new System.Drawing.Size(51, 48);
            this.pacOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pacOpen.TabIndex = 2;
            this.pacOpen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(500, 481);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.pacOpen);
            this.Controls.Add(this.pacClosed);
            this.Name = "Form1";
            this.Text = "Pacman";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacClosed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.PictureBox pacClosed;
        private System.Windows.Forms.PictureBox pacOpen;
    }
}

