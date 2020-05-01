# arduino-esp8266-espotaLauncher
espota Launcher is a very easy tool that executes espota.py script to program a ESP OTA device from its IP address.<br>
With this tool you can upload sketch and spiffs section even if a password is setted.

## Usage
- First you need to install [python v3](https://www.python.org/downloads/)
- Compile sketch and spiffs section and obtain *.bin* files.<br>
Look at temporary folder used by *Arduino IDE*.<br>
You can use **Arduino IDE** to compile the *sketch* (*Ctrl+Alt+S*) and **ESP8266 Sketch Data Upload** for the *spiffs*.
- Insert correct paths of *python3.exe*, *espota.py* and *.bin* files.<br>
**python3**: *C:\Users\xxx\AppData\Local\Arduino15\packages\esp8266\tools\python3\3.xxx\python3.exe*<br>
**espota.py**: *C:\Users\xxx\AppData\Local\Arduino15\packages\esp8266\hardware\esp8266\2.6.3\tools\espota.py*<br>
- Insert IP address, port number and password<br>
Don't use leading zeros with IP address (e.g. 192.168.*1*.*23*).<br>Default port number is *8266*.
- Press button for the section you want to upload (*sketch* or *spiffs*)
- Wait until the end of process (look at the output textbox)
