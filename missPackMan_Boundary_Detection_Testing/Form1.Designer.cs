namespace missPackMan_Boundary_Detection_Testing
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
            this.components = new System.ComponentModel.Container();
            this.wall1 = new System.Windows.Forms.PictureBox();
            this.wall2 = new System.Windows.Forms.PictureBox();
            this.wall4 = new System.Windows.Forms.PictureBox();
            this.wall3 = new System.Windows.Forms.PictureBox();
            this.block = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block)).BeginInit();
            this.SuspendLayout();
            // 
            // wall1
            // 
            this.wall1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.wall1.Location = new System.Drawing.Point(82, 166);
            this.wall1.Name = "wall1";
            this.wall1.Size = new System.Drawing.Size(15, 120);
            this.wall1.TabIndex = 0;
            this.wall1.TabStop = false;
            this.wall1.Tag = "wall";
            // 
            // wall2
            // 
            this.wall2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.wall2.Location = new System.Drawing.Point(255, 166);
            this.wall2.Name = "wall2";
            this.wall2.Size = new System.Drawing.Size(15, 120);
            this.wall2.TabIndex = 1;
            this.wall2.TabStop = false;
            this.wall2.Tag = "wall";
            // 
            // wall4
            // 
            this.wall4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.wall4.Location = new System.Drawing.Point(558, 166);
            this.wall4.Name = "wall4";
            this.wall4.Size = new System.Drawing.Size(15, 120);
            this.wall4.TabIndex = 2;
            this.wall4.TabStop = false;
            this.wall4.Tag = "wall";
            // 
            // wall3
            // 
            this.wall3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.wall3.Location = new System.Drawing.Point(414, 166);
            this.wall3.Name = "wall3";
            this.wall3.Size = new System.Drawing.Size(15, 120);
            this.wall3.TabIndex = 3;
            this.wall3.TabStop = false;
            this.wall3.Tag = "wall";
            // 
            // block
            // 
            this.block.BackColor = System.Drawing.Color.Red;
            this.block.Location = new System.Drawing.Point(94, 46);
            this.block.Name = "block";
            this.block.Size = new System.Drawing.Size(50, 50);
            this.block.TabIndex = 4;
            this.block.TabStop = false;
            this.block.Tag = "block";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.block);
            this.Controls.Add(this.wall3);
            this.Controls.Add(this.wall4);
            this.Controls.Add(this.wall2);
            this.Controls.Add(this.wall1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.wall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox wall1;
        private System.Windows.Forms.PictureBox wall2;
        private System.Windows.Forms.PictureBox wall4;
        private System.Windows.Forms.PictureBox wall3;
        private System.Windows.Forms.PictureBox block;
        private System.Windows.Forms.Timer timer1;
    }
}

