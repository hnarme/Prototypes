using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;

public class UDPPortControllerYELLOW : MonoBehaviour
{
    Thread receiveThread;

    UdpClient udpClient;

    public int portNum = 3003; // port number from python script for yellow

    public bool startReceiving = true;

    public bool printToConsole = false;

    public string message;

    private void Start()
    {
        receiveThread = new Thread(new ThreadStart(ReceiveData));
        receiveThread.IsBackground = true;
        receiveThread.Start();
    }

    private void ReceiveData()
    {
        udpClient = new UdpClient(portNum);

        while (startReceiving)
        {
            try
            {
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
                byte[] data = udpClient.Receive(ref remoteEP);
                //message = Encoding.ASCII.GetString(data);
                message = Encoding.UTF8.GetString(data);

                if (printToConsole)
                {
                    print(message);
                }
            }
            catch(Exception err)
            {
                print(err.ToString());
            }
        }
    }
}
