# fates-enemy-growth-modifier
![Example screenshot](http://i.imgur.com/FwIsQcf.png)

This tool is really quick and dirty; I hardcoded the offsets for the class entries, so it probably doesn't work for modified GameData.bin files.

To use this tool:
1. Use [FEAT](https://github.com/SciresM/FEAT) to decompress your GameData.bin.lz file.
2. Open the GameData.bin within the tool by using File -> Open GameData.bin.
3. Modify the growth values to your liking.
4. Use File -> Save GameData.bin to save your changes.
5. Use [FEAT](https://github.com/SciresM/FEAT) again to compress the GameData.bin file.
6. Use the modified GameData.bin.lz file with something like [Luma3DS](https://github.com/AuroraWright/Luma3DS) to patch your game.

If you want to experiment with this tool without extracting the GameData.bin from your own game, you can download a copy from [here](https://github.com/RainThunder/fefates-tools/blob/master/GameData.bin)

I also included the ability to increase every growth for every class by a given amount (this was the whole reason I built this in the first place). Use this to make the game universally harder or easier.

To build the source code, just compile the solution within Visual Studio. I used VS Community 2015, but 2017 probably works as well.
