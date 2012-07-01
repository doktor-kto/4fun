using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;

namespace PosterServer
{
    class Program
    {   
        public static void Main() {
            try {

                IPAddress ipAd = IPAddress.Parse("178.162.93.60");
                 
                TcpListener myList = new TcpListener(ipAd,8001);

                myList.Start();
                
                Console.WriteLine("The server is running at port 8001...");    
                Console.WriteLine("The local End point is  :" + 
                                  myList.LocalEndpoint );
                Console.WriteLine("Waiting for a connection.....");
                
                Socket s = myList.AcceptSocket();
                Console.WriteLine("Connection accepted from " + s.RemoteEndPoint);
                
                byte[] b = new byte[100];
                int k = s.Receive(b);
                Console.WriteLine("Recieved...");

                for (int i = 0; i < k; i++)
                    Console.Write(Convert.ToChar(b[i]));

                ASCIIEncoding asen=new ASCIIEncoding();
                s.Send(asen.GetBytes("The string was recieved by the server."));
                Console.WriteLine("\nSent Acknowledgement");
        
                s.Close();
                myList.Stop();
                    
            }
            catch (Exception e) {
                Console.WriteLine("Error..... " + e.StackTrace);
                Console.WriteLine("Error..... " + e.Message);
            }    
        }
    }
}

