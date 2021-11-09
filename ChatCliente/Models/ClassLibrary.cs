using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatCliente.Models
{
    public delegate void ShowUserChat(int user_id);

    public delegate void SendMessage(int user_id, string username);
}
