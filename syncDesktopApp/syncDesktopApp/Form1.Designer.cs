
namespace syncDesktopApp
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
            this.sender = new System.Windows.Forms.TextBox();
            this.receiver = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sender
            // 
            this.sender.Location = new System.Drawing.Point(54, 59);
            this.sender.Multiline = true;
            this.sender.Name = "sender";
            this.sender.Size = new System.Drawing.Size(886, 317);
            this.sender.TabIndex = 0;
            // 
            // receiver
            // 
            this.receiver.Location = new System.Drawing.Point(54, 673);
            this.receiver.Multiline = true;
            this.receiver.Name = "receiver";
            this.receiver.Size = new System.Drawing.Size(886, 317);
            this.receiver.TabIndex = 1;
            this.receiver.TextChanged += new System.EventHandler(this.receiver_TextChanged);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(240, 465);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(499, 122);
            this.button.TabIndex = 2;
            this.button.Text = "send";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 1215);
            this.Controls.Add(this.button);
            this.Controls.Add(this.receiver);
            this.Controls.Add(this.sender);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sender;
        private System.Windows.Forms.TextBox receiver;
        private System.Windows.Forms.Button button;
    }
}

