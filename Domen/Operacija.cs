using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public enum Operacija
    {
        Login,
        GetOnlineUsers,
        SendToAll,
        PristiglaPoruka,
        DiskonektujKorisnika
    }
}
