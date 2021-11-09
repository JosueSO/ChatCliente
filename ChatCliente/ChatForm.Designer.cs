namespace ChatCliente
{
    partial class ChatForm
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
            this.SplitContainerChat = new System.Windows.Forms.SplitContainer();
            this.LabelActiveUsers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerChat)).BeginInit();
            this.SplitContainerChat.Panel1.SuspendLayout();
            this.SplitContainerChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainerChat
            // 
            this.SplitContainerChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerChat.IsSplitterFixed = true;
            this.SplitContainerChat.Location = new System.Drawing.Point(0, 0);
            this.SplitContainerChat.Name = "SplitContainerChat";
            // 
            // SplitContainerChat.Panel1
            // 
            this.SplitContainerChat.Panel1.BackColor = System.Drawing.Color.Black;
            this.SplitContainerChat.Panel1.Controls.Add(this.LabelActiveUsers);
            this.SplitContainerChat.Size = new System.Drawing.Size(800, 601);
            this.SplitContainerChat.SplitterDistance = 250;
            this.SplitContainerChat.TabIndex = 0;
            // 
            // LabelActiveUsers
            // 
            this.LabelActiveUsers.BackColor = System.Drawing.Color.White;
            this.LabelActiveUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelActiveUsers.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelActiveUsers.ForeColor = System.Drawing.Color.DarkRed;
            this.LabelActiveUsers.Location = new System.Drawing.Point(0, 0);
            this.LabelActiveUsers.Name = "LabelActiveUsers";
            this.LabelActiveUsers.Size = new System.Drawing.Size(250, 40);
            this.LabelActiveUsers.TabIndex = 0;
            this.LabelActiveUsers.Text = "Usuarios Activos";
            this.LabelActiveUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.SplitContainerChat);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChatForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.SplitContainerChat.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerChat)).EndInit();
            this.SplitContainerChat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitContainerChat;
        private System.Windows.Forms.Label LabelActiveUsers;
    }
}