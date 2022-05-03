
namespace Game_Pong
{
    partial class Principal
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
            this.playground = new System.Windows.Forms.Panel();
            this.raquet = new System.Windows.Forms.PictureBox();
            this.boll = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raquet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boll)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.Controls.Add(this.raquet);
            this.playground.Controls.Add(this.boll);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(800, 450);
            this.playground.TabIndex = 0;
            // 
            // raquet
            // 
            this.raquet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.raquet.Location = new System.Drawing.Point(31, 409);
            this.raquet.Name = "raquet";
            this.raquet.Size = new System.Drawing.Size(200, 20);
            this.raquet.TabIndex = 1;
            this.raquet.TabStop = false;
            // 
            // boll
            // 
            this.boll.BackColor = System.Drawing.Color.Red;
            this.boll.Location = new System.Drawing.Point(42, 12);
            this.boll.Name = "boll";
            this.boll.Size = new System.Drawing.Size(30, 30);
            this.boll.TabIndex = 0;
            this.boll.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playground);
            this.Name = "Principal";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Principal_KeyDown);
            this.playground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.raquet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox raquet;
        private System.Windows.Forms.PictureBox boll;
        private System.Windows.Forms.Timer timer1;
    }
}

