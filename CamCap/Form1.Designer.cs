namespace CamCap
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
            this.camchoose = new System.Windows.Forms.ComboBox();
            this.camstrt = new System.Windows.Forms.Button();
            this.pornhub = new System.Windows.Forms.PictureBox();
            this.capturebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pornhub)).BeginInit();
            this.SuspendLayout();
            // 
            // camchoose
            // 
            this.camchoose.FormattingEnabled = true;
            this.camchoose.Location = new System.Drawing.Point(294, 37);
            this.camchoose.Name = "camchoose";
            this.camchoose.Size = new System.Drawing.Size(157, 21);
            this.camchoose.TabIndex = 0;
            this.camchoose.Text = "Choose source";
            // 
            // camstrt
            // 
            this.camstrt.Location = new System.Drawing.Point(266, 64);
            this.camstrt.Name = "camstrt";
            this.camstrt.Size = new System.Drawing.Size(218, 23);
            this.camstrt.TabIndex = 1;
            this.camstrt.Text = "REVV UP THOSE FRYERS";
            this.camstrt.UseVisualStyleBackColor = true;
            this.camstrt.Click += new System.EventHandler(this.Camstrt_Click);
            // 
            // pornhub
            // 
            this.pornhub.Location = new System.Drawing.Point(109, 122);
            this.pornhub.Name = "pornhub";
            this.pornhub.Size = new System.Drawing.Size(539, 294);
            this.pornhub.TabIndex = 2;
            this.pornhub.TabStop = false;
            // 
            // capturebtn
            // 
            this.capturebtn.Location = new System.Drawing.Point(306, 93);
            this.capturebtn.Name = "capturebtn";
            this.capturebtn.Size = new System.Drawing.Size(145, 23);
            this.capturebtn.TabIndex = 3;
            this.capturebtn.Text = "TAKE AN UGLY PICTURE";
            this.capturebtn.UseVisualStyleBackColor = true;
            this.capturebtn.Click += new System.EventHandler(this.Capturebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.capturebtn);
            this.Controls.Add(this.pornhub);
            this.Controls.Add(this.camstrt);
            this.Controls.Add(this.camchoose);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pornhub)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox camchoose;
        private System.Windows.Forms.Button camstrt;
        private System.Windows.Forms.PictureBox pornhub;
        private System.Windows.Forms.Button capturebtn;
    }
}

