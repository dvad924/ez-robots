#! /bin/bash

mcs -reference:EZ_B.dll -reference:NanoJPEG.dll -reference:ZeroMQ.dll -pkg:dotnet CamTest.cs
