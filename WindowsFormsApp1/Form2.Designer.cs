namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.btnNxt1 = new System.Windows.Forms.Button();
            this.txtBoxPIN = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.picBox_HNBlogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HNBlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the PIN:";
            // 
            // btnBack1
            // 
            this.btnBack1.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack1.ForeColor = System.Drawing.Color.White;
            this.btnBack1.Location = new System.Drawing.Point(90, 334);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(126, 56);
            this.btnBack1.TabIndex = 7;
            this.btnBack1.Text = "Back";
            this.btnBack1.UseVisualStyleBackColor = false;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // btnNxt1
            // 
            this.btnNxt1.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNxt1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNxt1.ForeColor = System.Drawing.Color.White;
            this.btnNxt1.Location = new System.Drawing.Point(566, 334);
            this.btnNxt1.Name = "btnNxt1";
            this.btnNxt1.Size = new System.Drawing.Size(126, 56);
            this.btnNxt1.TabIndex = 8;
            this.btnNxt1.Text = "Next";
            this.btnNxt1.UseVisualStyleBackColor = false;
            this.btnNxt1.Click += new System.EventHandler(this.btnNxt1_Click);
            // 
            // txtBoxPIN
            // 
            this.txtBoxPIN.Location = new System.Drawing.Point(316, 213);
            this.txtBoxPIN.Name = "txtBoxPIN";
            this.txtBoxPIN.Size = new System.Drawing.Size(290, 22);
            this.txtBoxPIN.TabIndex = 9;
            this.txtBoxPIN.UseSystemPasswordChar = true;
            this.txtBoxPIN.TextChanged += new System.EventHandler(this.txtBoxPIN_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // picBox_HNBlogo
            // 
            this.picBox_HNBlogo.Image = ((System.Drawing.Image)(resources.GetObject("picBox_HNBlogo.Image")));
            this.picBox_HNBlogo.Location = new System.Drawing.Point(250, 12);
            this.picBox_HNBlogo.Name = "picBox_HNBlogo";
            this.picBox_HNBlogo.Size = new System.Drawing.Size(246, 90);
            this.picBox_HNBlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_HNBlogo.TabIndex = 10;
            this.picBox_HNBlogo.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBox_HNBlogo);
            this.Controls.Add(this.txtBoxPIN);
            this.Controls.Add(this.btnNxt1);
            this.Controls.Add(this.btnBack1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HNBlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack1;
        private System.Windows.Forms.Button btnNxt1;
        private System.Windows.Forms.TextBox txtBoxPIN;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox picBox_HNBlogo;
    }
}