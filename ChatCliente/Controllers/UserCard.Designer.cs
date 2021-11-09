namespace ChatCliente.Controllers
{
    partial class UserCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCard));
            this.PictureUser = new System.Windows.Forms.PictureBox();
            this.LabelUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureUser
            // 
            this.PictureUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.PictureUser.Image = ((System.Drawing.Image)(resources.GetObject("PictureUser.Image")));
            this.PictureUser.Location = new System.Drawing.Point(0, 0);
            this.PictureUser.Name = "PictureUser";
            this.PictureUser.Size = new System.Drawing.Size(49, 50);
            this.PictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureUser.TabIndex = 0;
            this.PictureUser.TabStop = false;
            this.PictureUser.Click += new System.EventHandler(this.PictureUser_Click);
            // 
            // LabelUsername
            // 
            this.LabelUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.Location = new System.Drawing.Point(49, 0);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(151, 50);
            this.LabelUsername.TabIndex = 1;
            this.LabelUsername.Text = "Username";
            this.LabelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelUsername.Click += new System.EventHandler(this.LabelUsername_Click);
            // 
            // UserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.PictureUser);
            this.Name = "UserCard";
            this.Size = new System.Drawing.Size(200, 50);
            ((System.ComponentModel.ISupportInitialize)(this.PictureUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureUser;
        private System.Windows.Forms.Label LabelUsername;
    }
}
