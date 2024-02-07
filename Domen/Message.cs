using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Message
    {
        public object RequestObject { get; set; }
        public string MessageText { get; set; }
        public string FromWho { get; set; }
        public string ToWho { get; set; }
        public object ResponseObject { get; set; }
        public Operacija Operacija { get; set; }
        public Message(Operacija operacija, object requestObject = null)
        {
            Operacija= operacija;
            RequestObject= requestObject;
        }
        public Message()
        {

        }
    }
}
