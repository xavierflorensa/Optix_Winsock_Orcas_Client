#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.CoreBase;
using FTOptix.Core;
using FTOptix.NetLogic;
using Winsock_Orcas;
using System.Reflection.Emit;
using System.Net.Sockets;
using System.Net.Security;
using System.Net.Http;
#endregion

public class RuntimeNetLogic1 : BaseNetLogic
{
    Winsock winsock_Ear = new Winsock(); //opens a new socket
    
    [ExportMethod]
    
    public void Send(NodeId textboxNodeId)
    {
        var text_to_send = InformationModel.Get<TextBox>(textboxNodeId);
        winsock_Ear.Send(text_to_send.Text);
    }

     [ExportMethod]
    
    public void Connect()
    {
        var remoteIP = Project.Current.GetVariable("Model/RemoteIP");
        winsock_Ear.Connect(remoteIP.Value, 2000);
    }

    public override void Start()
    {
       winsock_Ear.LegacySupport=true;
        //winsock_Ear.Listen(2000);//This is to make the PC act as host
        //winsock_Ear.Connect("127.0.0.1", 2000); //This is to make the PC act as client
        // Assign a callback to be excuted when the client is connected
        //Winsock_Ear.Connected += winsock_Ear_Connected;
        // Assign a callback to be executed when a message is received from the server
        winsock_Ear.ConnectionRequest += winsock_Ear_ConnectionRequest;
        // Assign a callback to be executed when data is available from server
        winsock_Ear.DataArrival += winsock_Ear_DataArrival;
        Log.Info("LocalIP: "+winsock_Ear.LocalIP[0]);
        Log.Info("protocol: "+winsock_Ear.Protocol.ToString());
        Log.Info("Legacy support: "+winsock_Ear.LegacySupport.ToString());
        Log.Info("LocalPort: "+winsock_Ear.LocalPort.ToString());
        Log.Info("Remote Host: "+winsock_Ear.RemoteHost.ToString());
        Log.Info("Remote Port: "+winsock_Ear.RemotePort.ToString());
        Log.Info("State: "+winsock_Ear.State.ToString());
        Log.Info("Hello World");
        string text_to_send = "Hello World";
        winsock_Ear.Send(text_to_send);
    }   
        
    public override void Stop()
    //public override void Stop()
    {
         Log.Info("Stopping");
    }
    //this is the callback function that will execute when a client is connected
    private void winsock_Ear_Connected(object sender, Winsock_Orcas.WinsockConnectedEventArgs e)
        {
            Log.Info("¡¡Conectado!!");
        }
    //this is the callback function that will execute after the first connection request
    private void winsock_Ear_ConnectionRequest(object sender, Winsock_Orcas.WinsockConnectionRequestEventArgs e)
        {
            winsock_Ear.Close();
            winsock_Ear.Accept(e.Client);
        }
    private void winsock_Ear_DataArrival(object sender, Winsock_Orcas.WinsockDataArrivalEventArgs e)
        {
            string abRecibidos = winsock_Ear.Get<string>();
            var missatge = Project.Current.GetVariable("Model/Message");
            missatge.Value=abRecibidos;

           Log.Info("recibido: "+ abRecibidos);
        }
    private Winsock Winsock_Ear;
 }  

