namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunny = new System.Windows.Forms.PictureBox();
            this.dog = new System.Windows.Forms.PictureBox();
            this.cat = new System.Windows.Forms.PictureBox();
            this.pig = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pig)).BeginInit();
            this.SuspendLayout();
            // 
            // bunny
            // 
            this.bunny.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bunny;
            this.bunny.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunny.Location = new System.Drawing.Point(133, 159);
            this.bunny.Name = "bunny";
            this.bunny.Size = new System.Drawing.Size(110, 100);
            this.bunny.TabIndex = 41;
            this.bunny.TabStop = false;
            this.bunny.Click += new System.EventHandler(this.bunny_Click);
            // 
            // dog
            // 
            this.dog.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.dog;
            this.dog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dog.Location = new System.Drawing.Point(17, 159);
            this.dog.Name = "dog";
            this.dog.Size = new System.Drawing.Size(110, 100);
            this.dog.TabIndex = 40;
            this.dog.TabStop = false;
            this.dog.Click += new System.EventHandler(this.dog_Click);
            // 
            // cat
            // 
            this.cat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cat.BackgroundImage")));
            this.cat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cat.Location = new System.Drawing.Point(17, 53);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(110, 100);
            this.cat.TabIndex = 39;
            this.cat.TabStop = false;
            this.cat.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pig
            // 
            this.pig.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.pig;
            this.pig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pig.Location = new System.Drawing.Point(133, 53);
            this.pig.Name = "pig";
            this.pig.Size = new System.Drawing.Size(110, 100);
            this.pig.TabIndex = 38;
            this.pig.TabStop = false;
            this.pig.Click += new System.EventHandler(this.pig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Please Select a Character";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunny);
            this.Controls.Add(this.dog);
            this.Controls.Add(this.cat);
            this.Controls.Add(this.pig);
            this.Name = "Form1";
            this.Text = "Wheel Of Fortune";
            ((System.ComponentModel.ISupportInitialize)(this.bunny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bunny;
        private System.Windows.Forms.PictureBox dog;
        private System.Windows.Forms.PictureBox cat;
        private System.Windows.Forms.PictureBox pig;
        private System.Windows.Forms.Label label1;


    }
}

