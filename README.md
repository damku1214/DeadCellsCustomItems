# DeadCellsCustomItems
This is a mod that adds 4 new items to the game, all from the game Dead Cells!
All the context is written in the README file inside the CustomItems folder.

## Manual Installation (The one and only way to do so)
BE AWARE that this installation method is ripped off directly from [MrBacanudo's SkulHardModeMods](https://github.com/MrBacanudo/SkulHardModeMods/tree/main),
and this is the only way to access the mod. Sorry Thunderstore users!

1. Download the external dependencies
    * BepInEx (Windows x64): https://github.com/BepInEx/BepInEx/releases/download/v5.4.21/BepInEx_x64_5.4.21.0.zip
    * Unstripped Core Libraries: https://unity.bepinex.dev/corlibs/2020.3.34.zip
    * Unstripped Unity Libraries: https://unity.bepinex.dev/libraries/2020.3.34.zip
2. Extract all files into the Skul folder
    * Default is `C:\Program Files (x86)\Steam\steamapps\common\Skul` or `C:\Program Files\Steam\steamapps\common\Skul`
      * You can find this by right clicking Skul on Steam -> Properties -> Local Files -> Browse
    * BepInEx must be extracted to the game's root folder (i.e. you must see `winhttp.dll` and `doorstop_config.ini` in that folder)
    * The other two must be extracted inside the `2020.3.34` folder (the same folder!)
3. Edit the new `doorstop_config.ini` file inside the game folder:
    * Change the last line from `dllSearchPathOverride=` to `dllSearchPathOverride=2020.3.34`
4. Download the mods! Latest one here: https://github.com/MrBacanudo/SkulHardModeMods/releases/latest
5. Put the mods you want into the `BepInEx/plugins` folder inside your game folder
    * You're allowed to mix or just use what you want!

Please keep in mind, the mod doesn't gurantee that your game will be 100% totally fine.
Use this at your own risk. Here be dragons!
