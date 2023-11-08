namespace ITSC.Graduation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            lblFullName = new Label();
            lblCareer = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(30, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 178);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lblFullName.Location = new Point(203, 92);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(400, 86);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "lblFullName";
            // 
            // lblCareer
            // 
            lblCareer.AutoSize = true;
            lblCareer.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            lblCareer.Location = new Point(210, 178);
            lblCareer.Name = "lblCareer";
            lblCareer.Size = new Size(171, 51);
            lblCareer.TabIndex = 2;
            lblCareer.Text = "lblCareer";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.itsclogo;
            pictureBox2.Location = new Point(880, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 86);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(974, 341);
            Controls.Add(pictureBox2);
            Controls.Add(lblCareer);
            Controls.Add(lblFullName);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INSTITUTO TECNICO SUPERIOR COMUNITARIO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblFullName;
        private Label lblCareer;
        private PictureBox pictureBox2;
    }
}