<a name="_toc155458070"></a><a name="_toc156766291"></a>Third party libraries (dll) Socket Server application with FactoryTalk Optix
# Contents
[1.	Introduction](#_toc157019700)

[2.	Installing third party DLL’s into FactoryTalk Optix](#_toc157019701)

[2.1.	Installing external references (dll libraries) into the project with Visual Studio Code](#_toc157019702)

[3.	Building the Client](#_toc157019703)




# <a name="_toc157019700"></a>1 Introduction
You can see the result here

<https://youtu.be/6E4xt02Ohzw>

You can download the code from here

<https://github.com/xavierflorensa/Optix_Winsock_Orcas_Client.git>

You can use third party libraries.

For instance Winsock\_Orcas.dll

Even thought this library was created for Visual Basic, since it is compiled, it can be also used with C#

<https://www.codeproject.com/Articles/21443/Winsock-Revamped>

Let’s start this application from zero
# <a name="_toc157019701"></a>1. Installing third party DLL’s into FactoryTalk Optix.
The easiest way to install external references to a project is using Visual Studio 2002, since it will do all the work for you. Then if you prefer you can continue with Visual Studio Code since it is much faster to open and close.

Start a new project in FT Optix Studio

Add a new NetLogic code

![Picture1](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/04889cfb-db99-4f1e-a3d6-3911b3262e80)

Save the project

Insert this dll on the root directory of the project

Winsock\_Orcas.dll

![Picture2](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/5ab6daad-06b0-4fbe-9461-49d5750f6b62)

Select editor to Visual Studio 2022

Close and open FT Optix to have this change updated.

Click on the code

![Picture3](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/73655b1c-7b5e-4311-a0b4-41b17fd44da8)

Visual Studio 2022 will open

![Picture4](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/3178a529-b0a8-4112-b929-d8c070045d29)

![Picture5](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/3ed5bcae-84f2-469e-b4ac-10c784df3e74)

Go to Project / Add Project Reference

![Picture6](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/11c4437a-2795-41c0-9965-eb9c253daddf)

Click on Browse

![Picture7](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/6997d637-2978-40cf-93a9-c8e57d87dfe8)

Select the dll

![Picture8](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/400df88e-a36f-44c4-8338-c692d97059b2)

Verify that this is the right path

![Picture9](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/1a00bdc6-d49f-42e7-adbf-1acfe351dc10)
Click Ok

Unfold assemblies

![Picture10](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/ac6c027a-ab86-4733-babf-db708c88b7df)

You have it installed

![Picture11](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/4937b7c3-f20c-4bb6-8b5a-e9d3ae54ba97)

Build the application (Do not build solution)

![Aspose Words ba282580-5f3d-413f-93f5-cedb57be876b 011](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/5bd6085a-24aa-420f-9b1b-a85f0a20688f)

You can close Visual Studio 2022

Change the code editor to Visual Studio Code in FT Optix Studio

Save close and open it again

Open Netlogic

![Aspose Words ba282580-5f3d-413f-93f5-cedb57be876b 012](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/69af0bbd-05c5-4920-ad70-ab50af9b8469)

Open references file \*.csproj

VS 2022 has done the dll installation for you without editing this \*.csproj file

![Aspose Words ba282580-5f3d-413f-93f5-cedb57be876b 013](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/d80b8218-5c81-479b-8007-87d9ee02e384)

## <a name="_toc156766294"></a><a name="_toc157019702"></a>2 Installing external references (dll libraries) into the project with Visual Studio code
Pending to test this way

How you add a reference depends on the project type for the code you're working on:

- If you see a **Dependencies** node in [**Solution Explorer**](https://learn.microsoft.com/en-us/visualstudio/ide/use-solution-explorer?view=vs-2022), you can use the right-click context menu to select **Add Project Reference**.

  ![Aspose Words ba282580-5f3d-413f-93f5-cedb57be876b 014](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/a2029104-b854-4a95-a009-93bca481d9a0)

- If you see a **References** node in [**Solution Explorer**](https://learn.microsoft.com/en-us/visualstudio/ide/use-solution-explorer?view=vs-2022), you can use the right-click context menu to select **Add Reference**.

  ![Aspose Words ba282580-5f3d-413f-93f5-cedb57be876b 015](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/7ee28544-5def-46d1-955f-4919330461e1)

For more information, see [How to: Add or remove references](https://learn.microsoft.com/en-us/visualstudio/ide/how-to-add-or-remove-references-by-using-the-reference-manager?view=vs-2022).
# <a name="_toc157019703"></a>3. Building the Client


You can see the result here

<https://youtu.be/6E4xt02Ohzw>

You can download the project from here

<https://github.com/xavierflorensa/Optix_Winsock_Orcas_Client.git>

Test the program with a TCP server

First open the server and put it to listen on port 2000

![Aspose Words c171ae06-3fad-45e0-86a4-81bffd2c0ee2 016](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Client/assets/55208134/108b18be-e9b2-4b00-873a-53e2ca2e0e27)

Now the server is listening

![Aspose Words c171ae06-3fad-45e0-86a4-81bffd2c0ee2 017](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Client/assets/55208134/90f913f3-62dc-47ea-a4a5-5308db36a8fe)

Next start the Optix project

![Aspose Words c171ae06-3fad-45e0-86a4-81bffd2c0ee2 017](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Client/assets/55208134/90f913f3-62dc-47ea-a4a5-5308db36a8fe)

This is working.

![Aspose Words c171ae06-3fad-45e0-86a4-81bffd2c0ee2 018](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Client/assets/55208134/1fbd0755-9656-4c88-be49-1d941b9737cb)

But the connection is made and sending one message is done in one step, and then no chances to send more messages.

Pending to improve this.

![Aspose Words c171ae06-3fad-45e0-86a4-81bffd2c0ee2 019](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Client/assets/55208134/9ea19307-9e7b-48bf-8d3c-a02c55385a99)

Managing to use callback functions to have chances to send several messages

![Aspose Words c171ae06-3fad-45e0-86a4-81bffd2c0ee2 020](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Client/assets/55208134/7f725466-7d40-4c51-ade3-b654744fdc67)

Using this code with the callback function

```C#
//this is the callback function that will execute after the first connection request
    private void winsock_Ear_ConnectionRequest(object sender, Winsock_Orcas.WinsockConnectionRequestEventArgs e)
        {
            winsock_Ear.Close();
            winsock_Ear.Accept(e.Client);
        }

```

This is the complete code

```C#
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
    
    public void Send()
    {
        string text_to_send = "Hello World";
        winsock_Ear.Send(text_to_send);
    }

    public override void Start()
    {
       winsock_Ear.LegacySupport=true;
        //winsock_Ear.Listen(2000);//This is to make the PC act as host
        winsock_Ear.Connect("127.0.0.1", 2000); //This is to make the PC act as client
        // Assign a callback to be excuted when the client is connected
        //Winsock_Ear.Connected += winsock_Ear_Connected;
        // Assign a callback to be executed when a message is received from the server
        winsock_Ear.ConnectionRequest += winsock_Ear_ConnectionRequest;
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
    private Winsock Winsock_Ear;
 }  
```

<https://github.com/xavierflorensa/Optix_Winsock_Orcas_Client.git>

You can also see how to build the Server in this repository
<https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server.git>


