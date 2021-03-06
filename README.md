# ChocoEdit
A Chocobo World (Final Fantasy VIII minigame) savegame editor for PSX and PC (CHOCORPG file)

Works with "PSXGameEdit single save" (*.mcs) savegames, CHOCORPG and CHOCORPG.ff8 savefiles. I recommend MemcardRex 1.8 by Shendo to handle all PSX save file formats: http://shendosoft.blogspot.com.es/2014/01/memcardrex-18-released.html

Check out this amazing guide (in spanish though):
https://baseavalancha.com/2020/03/25/guia-chocobo-world-final-fantasy-viii-by-ortew-lant/

Editing Features:
- Associate Chocobo World savegame to a different Final Fantasy VIII savefile (*).
- Edit current level.
- Edit current weapon.
- Edit # of PowerUps.
- Edit ID, rank and maximum HP (please remember that these three are related between them, so check the table embedded in the program for legit combinations).
- Edit collected item quantity.
- Edit some in-game flags/settings. (**)

* To succesfully associate a Chocobo World save file to another Final Fantasy VIII save file, Boko needs to be away (in the Pocket Station) in both savegames, so make sure your Final Fantasy VIII savegame has sent Boko for a walk.
** Flag 0 and 1 are somewhat unknown. Flag 0 is always set, and flag 1 seems to be the flag for Boko being away (Pocket Station) or home (Final Fantasy VIII). These two are readonly for safety.

Note: the game has two savegames (current save and backup save), the program loads and modifies the most recent one.

::::::::::
Changelog:
::::::::::

0.2b 14 March 2021
- Reworked lzs.exe calling which failed when path had spaces on it.
- Adjusted max HP and current HP max and min values to allow range 6-99 for max HP and 1-99 for current HP (even though leveling up resets to maximum 41).


0.2a 16 July 2016
- Small bug prevented loading ID from FF8 PSX savegame.
- Disable "load from FF8" button when there's no save and for PC saves.

0.2 12 July 2016
- Added PC savegame support using Ficedula's FFLZS v1.20 for (de)compression. The exe file is embedded for convenience.

::::::
Thanks
::::::
Ortew Lant for his awesome Chocobo World guide and help with some offsets back in 2013.
Ficedula for his LZS (de)compressor.

----------------------------------
suloku 2016