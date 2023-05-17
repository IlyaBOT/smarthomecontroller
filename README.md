[![](https://img.shields.io/badge/Version-Release_1.1-brightgreen.svg?style=for-the-badge)](#versions)
[![](https://img.shields.io/badge/IlyaBOT-VK-blue.svg?style=for-the-badge)](https://www.vk.com/ibworkshop)
<!-- [![.NET Core Desktop](https://github.com/IlyaBOT/smarthomecontroller/actions/workflows/dotnet-desktop.yml/badge.svg?branch=main)](https://github.com/IlyaBOT/smarthomecontroller/actions/workflows/dotnet-desktop.yml) -->

# **Smart Home Controller**
A small program for controlling a homemade smart home system using microcontrollers using the UART protocol.

## What the program can currently do
- Brightness control of ~4~ lighting devices using high-frequency 10-bit PWM (Partially not implemented)
- Using the PC Speaker for Announcements (Limited work at the moment)
- Speed control of ~4~ electric motors using PWM (Partially not implemented)
- ~Control of 4 servos~ (Not implemented)
- Using a simple, relatively modern interface using the GUNA 2 UI library (The interface will be improved in the future, and the Guna2Ui library will be replaced with MaterialDesign)
- Saving user settings; enabling/disabling unnecessary components and renaming them.
- Adapting the notification bar icon to the Windows theme (Dark or light).<br>
*P.S. This only works with the icon on the notification bar.*<br>
*P.P.S. The icon will be replaced in the future*
- Minimizing the program to the notification bar
- ~Changing the language and theme on the fly~ (Not implemented)

## About Arduino Uno firmware
- Using fast 10 bit PWM
- Brightness control of ~2~ lighting devices using high-frequency 10-bit PWM (Partially not implemented)
- Using the PC Speaker for Announcements
- Speed control of ~4~ electric motors using PWM (Partially not implemented)<br>
*P.S. Honestly, I don't even remember if it works, sorry...*
- ~Control of 4 servos~ (Not implemented)

## What I would like to add/change in version 2
- [ ] Change GUI library to MaterialDesign.
- [ ] Add a small tutorial.
- [ ] Add support for multiple languages.
- [ ] Add support for multiple (possibly even custom) themes.
- [ ] Increase the number of supported devices for control; Adding sensors for reading readings.
- [ ] Add an emergency power battery and display its charge.
- [ ] Fix bugs.
- [ ] Optimize code.
