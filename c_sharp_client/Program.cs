using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;


namespace c_sharp_client
{
    class Program
    {
        static void Main(string[] args)
        {

            using (WebSocket ws = new WebSocket("ws://simple-websocket-server-echo.glitch.me/"))
                
            { 
                ws.OnMessage += Ws_OnMessage;
                ws.Connect();
                ws.Send("Hello Server");
                Console.ReadKey();
            }
        }
     
          

        private static void Ws_OnMessage(object sender, MessageEventArgs e)
        {
            Console.WriteLine("Recieved from the server: " + e.Data);        
        }
    }
}
