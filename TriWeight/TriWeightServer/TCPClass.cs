using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace BachelorWishList
{
    public class TCPClass
    {
        IPAddress address = IPAddress.Parse("192.168.1.83");
        // Set the TcpListener on port 13000.
        int port = 13000;
        List<String> DataBack;

        #region --- splitsUser ---
        String[] splitsUser;
        String splitUserID;
        String splitUserFirstName;
        String splitUserLastName;
        String splitUserPassword;
        String splitUserEMail;
        String splitUserSkin;
        String splitUserPremium;
        String splitUserActive;
        String splitUserMaster;
        #endregion --- splitsUser ---

        public bool TCPConnection()
        {
        TcpListener tcp = new TcpListener(address, port);
            try
            {
                // TcpListener server = new TcpListener(port);
               

                // Start listening for client requests.
                tcp.Start();

                // Buffer for reading data
                Byte[] bytes = new Byte[256];
                String data = null;

                // Enter the listening loop.
                while (true)
                {
                    Console.Write("Waiting for a connection... ");

                    // Perform a blocking call to accept requests.
                    // You could also user server.AcceptSocket() here.
                    TcpClient client = tcp.AcceptTcpClient();
                    Console.WriteLine("Connected!");

                    data = null;

                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();

                    int i;

                    // Loop to receive all the data sent by the client.
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        // Translate data bytes to a ASCII string.
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        Console.WriteLine("Received: {0}", data);

                        // Process the data sent by the client.


                        //byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                        // Send back a response.
                        //stream.Write(msg, 0, msg.Length-1); //-1 bbecause it's 1 too long atm.
                        //Console.WriteLine("Sent: {0}", data);

                        if (data.Contains("GetDataID"))
                        {
                            DataBack = getDataByID(data);
                            Console.WriteLine(DataBack);
                        }
                        data = data.ToUpper();
                        if (DataBack != null) {
                             foreach (String element in DataBack) {
                                 byte[] msg = System.Text.Encoding.ASCII.GetBytes(element);
                                 // Send back a response.
                                 stream.Write(msg, 0, msg.Length);
                                 Console.WriteLine("Sent: {0}", element);
                             }
                         }

                    }

                    // Shutdown and end connection
                    client.Close();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                // Stop listening for new clients.
                tcp.Stop();
            }


            Console.WriteLine("\nHit enter to continue...");
            Console.Read();

            return false;
        }

        //Gets: "GETUSER",ID
        public List<string> getDataByID(String data)
        {
            List<String> s = new List<string>(); ;
            //Remove  getdata part
            string getData = data.Replace("GetData,", "");
            int DataID = System.Convert.ToInt32(getData);
            
            s = DataClass.GetDataByDataIDAsString(DataID);
            return s;
        }
    }
}