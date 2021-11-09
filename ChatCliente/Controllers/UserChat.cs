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
    public partial class UserChat : UserControl
    {
        private UserInfo UserInfo { get; set; }
        private Font ChatFont;

        public UserChat(UserInfo user)
        {
            InitializeComponent();

            ChatFont = new Font("Arial", 12);
        }

        public void ReceiveNewMessage(string message)
        {
            //Agregar mensaje de otro usuario
            Label userMessageFrom = new Label
            {
                Text = message,
                Font = ChatFont,
                BackColor = Color.Gray,
                ForeColor = Color.Black,
                MaximumSize = new Size(PanelChat.Width - 20, 500),
                AutoSize = true
            };
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            //Agregar mensaje del propio usuario
            string message = "";

            Label userMessageTo = new Label
            {
                Text = message,
                Font = ChatFont,
                BackColor = Color.Blue,
                ForeColor = Color.White,
                RightToLeft = RightToLeft.Yes,
                MaximumSize = new Size(PanelChat.Width - 20, 500),
                AutoSize = true
            };

            //Usar delegado para enviar mensaje
        }
    }
}
