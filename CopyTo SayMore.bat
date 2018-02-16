set sayMoreDir=..\SayMore
copy /Y output\debug\SIL.Core.dll %sayMoreDir%\lib\dotnet
copy /Y output\debug\SIL.Core.xml %sayMoreDir%\lib\dotnet
copy /Y output\debug\SIL.Core.pdb %sayMoreDir%\lib\dotnet
copy /Y output\debug\SIL.Core.dll.config %sayMoreDir%\lib\dotnet
copy /Y output\debug\SIL.Archiving.dll %sayMoreDir%\lib\dotnet
copy /Y output\debug\SIL.Archiving.xml %sayMoreDir%\lib\dotnet
copy /Y output\debug\SIL.Archiving.pdb %sayMoreDir%\lib\dotnet
copy /Y output\debug\SIL.Archiving.dll.config %sayMoreDir%\lib\dotnet
copy /Y output\debug\SIL.Media.dll %sayMoreDir%\lib\dotnet
copy /Y output\debug\SIL.Media.xml %sayMoreDir%\lib\dotnet
copy /Y output\debug\SIL.Media.pdb %sayMoreDir%\lib\dotnet
copy /Y output\debug\SIL.Media.dll.config %sayMoreDir%\lib\dotnet
copy /Y output\debug\SIL.Windows.Forms.dll %sayMoreDir%\lib\dotnet
copy /Y output\debug\SIL.Windows.Forms.xml %sayMoreDir%\lib\dotnet
copy /Y output\debug\SIL.Windows.Forms.pdb %sayMoreDir%\lib\dotnet
copy /Y output\debug\SIL.Windows.Forms.dll.config %sayMoreDir%\lib\dotnet
copy /Y output\debug\SIL.Windows.Forms.WritingSystems.dll %sayMoreDir%\lib\dotnet
copy /Y output\debug\SIL.Windows.Forms.WritingSystems.xml %sayMoreDir%\lib\dotnet
copy /Y output\debug\SIL.Windows.Forms.WritingSystems.pdb %sayMoreDir%\lib\dotnet
copy /Y output\debug\SIL.WritingSystems.dll %sayMoreDir%\lib\dotnet
copy /Y output\debug\SIL.WritingSystems.xml %sayMoreDir%\lib\dotnet
copy /Y output\debug\SIL.WritingSystems.pdb %sayMoreDir%\lib\dotnet
copy /Y output\debug\SIL.BuildTasks.dll %sayMoreDir%\build
copy /Y output\debug\SIL.BuildTasks.pdb %sayMoreDir%\build

copy /Y %sayMoreDir%\lib\dotnet\SIL*.* %sayMoreDir%\output\debug

pause