
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
            this.checker = new System.Windows.Forms.Button();
            this.puller = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pusher = new System.Windows.Forms.Button();
            this.push = new System.Windows.Forms.Label();
            this.pusherText = new System.Windows.Forms.TextBox();
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
            this.receiver.Location = new System.Drawing.Point(54, 694);
            this.receiver.Multiline = true;
            this.receiver.Name = "receiver";
            this.receiver.Size = new System.Drawing.Size(886, 84);
            this.receiver.TabIndex = 1;
            this.receiver.TextChanged += new System.EventHandler(this.receiver_TextChanged);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(67, 438);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(263, 122);
            this.button.TabIndex = 2;
            this.button.Text = "Send";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // checker
            // 
            this.checker.Location = new System.Drawing.Point(370, 438);
            this.checker.Name = "checker";
            this.checker.Size = new System.Drawing.Size(267, 121);
            this.checker.TabIndex = 3;
            this.checker.Text = "Pull";
            this.checker.UseVisualStyleBackColor = true;
            this.checker.Click += new System.EventHandler(this.button1_Click);
            // 
            // puller
            // 
            this.puller.Location = new System.Drawing.Point(54, 907);
            this.puller.Multiline = true;
            this.puller.Name = "puller";
            this.puller.Size = new System.Drawing.Size(886, 73);
            this.puller.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 636);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Update Detecter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 849);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pull";
            // 
            // pusher
            // 
            this.pusher.Location = new System.Drawing.Point(673, 438);
            this.pusher.Name = "pusher";
            this.pusher.Size = new System.Drawing.Size(267, 121);
            this.pusher.TabIndex = 7;
            this.pusher.Text = "Push";
            this.pusher.UseVisualStyleBackColor = true;
            this.pusher.Click += new System.EventHandler(this.pusher_Click);
            // 
            // push
            // 
            this.push.AutoSize = true;
            this.push.Location = new System.Drawing.Point(54, 1037);
            this.push.Name = "push";
            this.push.Size = new System.Drawing.Size(80, 32);
            this.push.TabIndex = 9;
            this.push.Text = "Push";
            // 
            // pusherText
            // 
            this.pusherText.Location = new System.Drawing.Point(54, 1095);
            this.pusherText.Multiline = true;
            this.pusherText.Name = "pusherText";
            this.pusherText.Size = new System.Drawing.Size(886, 73);
            this.pusherText.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 1215);
            this.Controls.Add(this.push);
            this.Controls.Add(this.pusherText);
            this.Controls.Add(this.pusher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.puller);
            this.Controls.Add(this.checker);
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
        private System.Windows.Forms.Button checker;
        private System.Windows.Forms.TextBox puller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button pusher;
        private System.Windows.Forms.Label push;
        private System.Windows.Forms.TextBox pusherText;
    }
}

