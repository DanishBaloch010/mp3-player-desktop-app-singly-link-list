# mp3-player-desktop-app-singly-link-list
 Mp3 player using singly link list and winmm.dll
 
Project Name :       Mp3 player using link list.

More on project:   This graphical user interface app is made with windows forms using C#.  In visual studio 2010.

Functionality of App : | Add Audio | Delete Audio | Go forward | Go backward  | Play |  Pause | Count of total audio files | Repeat all Audios.

# How this application works ?
This app is using MCI  string commands to run audio files. First of all when a user adds songs In his playlist. The songs directory address (for example, E:\01.testAudio) is stored using File Dialog system of windows forms. And then the directory address is stored in data of a node in doubly link list. After successful add of audio files user can use the functionality of this application. The audio file is not stored in the node but the location of it is stored in the node. App uses users computer as memory.

# How data structure is working ?
A separate class file is made for doubly link list, all the functions of link list are in it . Such as add, delete, traverse , search etc.. . User interact with the app using buttons and list view present in front of him. Every call to function(in the class file) is connected with the user interaction.

![image](https://user-images.githubusercontent.com/68731898/183962623-2b8ccc97-0a6b-4bb5-80bd-3b35686fc563.png)

![image](https://user-images.githubusercontent.com/68731898/183962644-f4182f6a-5f38-4ffc-8ce8-24569b88b5d8.png)


![image](https://user-images.githubusercontent.com/68731898/183962674-96b08c96-674e-4602-bfa4-788ee52e0c08.png)


![image](https://user-images.githubusercontent.com/68731898/183962709-104e6664-3279-43d0-85d4-691f0063ee10.png)


![image](https://user-images.githubusercontent.com/68731898/183962735-0b76f9de-004a-461b-9b61-3a872f7380e1.png)


