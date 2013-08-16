MKDIR Builds
MKDIR Builds\EpicEdit
COPY Builds\Debug\EpicEdit.exe Builds\EpicEdit\EpicEdit.exe
COPY Builds\Debug\EpicEdit.exe.config Builds\EpicEdit\
COPY Builds\Debug\*.dll Builds\EpicEdit\
MKDIR Builds\EpicEdit\Data
COPY GobosData\Shaders\defaultAmbient.fx Builds\EpicEdit\Data\
COPY GobosData\testguiskin.adf Builds\EpicEdit\Data\
COPY GobosData\Textures\noTexture.png Builds\EpicEdit\Data\
COPY GobosData\Textures\gui*.* Builds\EpicEdit\Data\
COPY GobosData\Textures\modelEditor\*.* Builds\EpicEdit\Data\
COPY GobosData\UI\modelEditor\*.* Builds\EpicEdit\Data\
