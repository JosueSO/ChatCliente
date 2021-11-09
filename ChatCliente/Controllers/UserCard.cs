using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatLibrary;

namespace ChatCliente.Controllers
{
    public partial class UserCard : UserControl
    {
        private UserInfo UserInfo { get; set; }

        public UserCard(UserInfo user)
        {
            InitializeComponent();
        }

        private void LabelUsername_Click(object sender, EventArgs e)
        {
            //Usar delegado para mostrar el chat
        }

        private void PictureUser_Click(object sender, EventArgs e)
        {
            //Usar delegado para mostrar el chat
        }
    }
}
