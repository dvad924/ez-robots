=========================================================================================
=                               ______ ______      ____                                 =
=                              |  ____|___  /     |  _ \                                =
=                              | |__     / /______| |_) |                               =
=                              |  __|   / /|______|  _ <                                =
=                              | |____ / /__      | |_) |                               =
=                              |______/_____|     |____/                                = 
=                                                                                       =
=========================================================================================
=                                  www.ez-robot.com                                     =
=========================================================================================
                              
Welcome to EZ-B!


Documentation
=============

1) If you load an example tutorial solution into Visual Studio, you may get an error 
   about not being able to find the EZ_B.DLL file. You will need to manually add the DLL
   file as a reference to each project.

   Right Click on Project -> Add Reference -> Browse -> Select EZ_B.DLL from DLL folder


2) Projects must be compiled as x86 (not 64 bit). Configure your project to generate x86 (32 bit) binaries.
   Right click on project, select Build and change the CPU to x86


3) Projects must be configured for .Net 4.5 runtime


4) All files from the DLL folder must be included in your application's compiled executable folder.
   For example, all files from the DLL folder must be in your Application's BIN\Debug or BIN\Release folder
   You can either manually copy the executable files into the executable folder, or you can
   specify the files to be included in your project as Content and Copy to the folder during compile.