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

<https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server.git>

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



```
Let’s try the client application with those callbacks

You will find this on other repository
<https://github.com/xavierflorensa/Optix_Winsock_Orcas_Client.git>
