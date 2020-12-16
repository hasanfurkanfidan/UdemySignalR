using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemySignalR.Server.Hubs
{
    public class MyHub:Hub
    {
        public static List<string> Names { get; set; } = new List<string>();
        //static olması lazım çünkü her istekte listin boşalmaması önemli
        public async Task SendName(string name)
        {
           Names.Add(name);
           await Clients.All.SendAsync("ReceiveName",name);
        }
        public async Task GetNames()
        {
            await Clients.All.SendAsync("RecieveNames", Names);
            
        }

    }
}
