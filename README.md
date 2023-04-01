# VRCSongWiz
Simple App to display customizable song information for the **Spotify Desktop App** in the VRChat Chatbox.

1. Download the app [here](https://github.com/VRCWizard/VRCSongWiz/releases/download/v1.0.1/VRCSongWiz-v1.0.1-x64.zip)
    1. Extract it
    1. Run the .exe



2. It may ask you to install the missing framework for .Net upon running the .exe file
    - If the popup does not appear and the application does not start use this direct download: [runtime-desktop-6.0.15-windows-x64-installer](https://download.visualstudio.microsoft.com/download/pr/513d13b7-b456-45af-828b-b7b7981ff462/edf44a743b78f8b54a2cec97ce888346/windowsdesktop-runtime-6.0.15-win-x64.exe)
    
 3. Sending OSC to VRChat Chatbox: https://github.com/VRCWizard/TTS-Voice-Wizard/wiki/OSC-Troubleshooting
 
 4. Customize Song Text
 ```
 {title}
 {artist}
 {progressMinutes}
 {durationMinutes}
 ```
 Example: ```▶ {title} - {artist} 『{progressMinutes}/{durationMinutes}』```
 
 Notes: 
 - When using progress and duration you probably want the **Only AppearOn Song Change** setting disabled
 - You may have to pause and play the song if you start VRCSongWiz with Spotify already open. (or it will not connect right away)
 - **If you want additional functiionaility download [TTS Voice Wizard](https://github.com/VRCWizard/TTS-Voice-Wizard) it containts all this apps features and more.**
     - TTS Voice Wizard has additional customization text variables
     - TTS Voice Wizard Works with songs from other apps, and other media such as Youtube videos, and other browser media
     - And much much more
 
 ![image](https://user-images.githubusercontent.com/101527472/229314497-9de9d9b5-7c40-44e6-abe3-ed5798d24ea6.png)

 
 ![image](https://user-images.githubusercontent.com/101527472/229314401-45c87536-f473-499b-9f8b-3afa15e616b8.png)

