namespace ChatCliente.Controllers
{
    partial class UserChat
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserChat));
            this.LabelUsername = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.PanelChat = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelUsername
            // 
            this.LabelUsername.BackColor = System.Drawing.Color.Silver;
            this.LabelUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelUsername.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.Location = new System.Drawing.Point(0, 0);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.LabelUsername.Size = new System.Drawing.Size(550, 40);
            this.LabelUsername.TabIndex = 0;
            this.LabelUsername.Text = "Username";
            this.LabelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonSend);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 536);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 64);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(492, 64);
            this.textBox1.TabIndex = 0;
            // 
            // ButtonSend
            // 
            this.ButtonSend.BackColor = System.Drawing.Color.DarkRed;
            this.ButtonSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonSend.FlatAppearance.BorderSize = 0;
            this.ButtonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSend.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSend.Image")));
            this.ButtonSend.Location = new System.Drawing.Point(492, 0);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(58, 64);
            this.ButtonSend.TabIndex = 1;
            this.ButtonSend.UseVisualStyleBackColor = false;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // PanelChat
            // 
            this.PanelChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelChat.Location = new System.Drawing.Point(0, 40);
            this.PanelChat.Name = "PanelChat";
            this.PanelChat.Size = new System.Drawing.Size(550, 496);
            this.PanelChat.TabIndex = 2;
            // 
            // UserChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelChat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabelUsername);
            this.Name = "UserChat";
            this.Size = new System.Drawing.Size(550, 600);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel PanelChat;
    }
}
