Plagueworld
===========
Skybox by Justin Fisher 


This Skybox comes from "Gunmetal" by Mad Genius Software, and has been converted 
for Quake III Arena. Textures copyright 1998, Justin Fisher. 

You may include these textures with your levels, provided that they are credited to 
Justin Fisher (the textures, not the levels :). However, the textures may not be 
used in commercial products or for commercial purposes without permission. You may 
distribute these textures as level building assets, but must include this file
(though the Q3A-specific material may be removed or replaced if not relevant)


ABOUT:
Another of my favorites - a world overcome by an alien nano-virus. 
The landscape features a string of giant radio dishes claimed and rebuilt by the virus, and other weird stuff. 

BUGS: 
On my machine at least, the gamma difference between Q3A and the desktop means that otherwise invisible jpeg compression artifacts become painfully obvious huge blocks in the sky.
Pulling back the level of compression doesn't seem to help. 
I might have to re-release this one with targa rather than jpeg files. That would probably add 4meg to your finished level filesize.
I think the Masters of the Arena are telling me my gamma is too high... :)

TO USE: (for Quake III Arena)
For those familiar with this stuff, the textures are in the .pk3, and the shaders 
are in this file.
For those less familiar;

1)  Put the .pk3 file (this contains the skybox textures) in your Quake baseq3 
    directory.
2)  Create a textures/harlequin_sky directory off your baseq3 directory.
3)  Create a text file "harlequin_sky.shader" in this directory (unless you have 
    done so already for another of my skies, in which case you use the existing file).
4)  Cut and paste the shader scripts (below) into this file. (Note - it must be a 
    plain text file, not rich text or anything like that).
5)  Add "harlequin_sky.shader" to the "shaderlist.txt" in the baseq3/scripts 
    directory.

Now you have the Harlequin textures available in Q3Radient. Using them in your map 
should produce the sky correctly in Q3A.

To distribute your level with the sky, you can either distribute it with the .pk3 
file, or put the contents of the .pk3 into your map's .pk3 (a cleaner solution). If 
you don't know how to do this, well, go find out. :-)
Remember to use the naming conventions for your final .pk3 file (more on this at the 
bottom of this file).

You will see below that two shaders are included. Both show the same skybox, but 
one has the Surfacelight parameter removed (NO-GLOW). Skies have two lightsources - 
the direct rays of the sun, and indirect ambient light that fills in the 
shadows a bit. The ambient light is created by making the sky texture glow in 
addition to the sun. This gets the best results, but can take a very long time when 
compiling your maps. Hence, use the noglow texture for areas where the glow is not 
needed. You can also use noglow as a temporary texture while you work on the map, 
and switch to the normal one when finishing.


THE SHADER SCRIPTS:

//   ---cut here---

//   Plagueworld
//   ===========

textures/harlequin_sky/jf-plague_sky
{
	qer_editorimage textures/harlequin_sky/plague_qer1.tga
	surfaceparm sky
	surfaceparm noimpact
	surfaceparm nolightmap
	surfaceparm nomarks
	q3map_surfacelight 33
// note: Change the surfacelight value if you want more ambient light from the sky.
	q3map_sun 1 .9 .8 33 0 90
// note: Change the fourth value (33) if you want a brighter or dimmer sun
	skyparms textures/harlequin_sky/env/kell - -
}

//   Plagueworld without Surfacelight (ie NO-GLOW)
//   =============================================

textures/harlequin_sky/jf-plague_sky_noglow
{
	qer_editorimage textures/harlequin_sky/plague_qer2.tga
	surfaceparm sky
	surfaceparm noimpact
	surfaceparm nolightmap
	surfaceparm nomarks
	q3map_sun 1 .9 .8 33 0 90
// note: Change the fourth value (33) if you want a brighter or dimmer sun
	skyparms textures/harlequin_sky/env/kell - -
}

//   ---stop cutting here---

Enjoy your new world.
 - Justin


E-mail: JAF60@student.canterbury.ac.nz
Homepage: http://www.geocities.com/soho/lofts/1121

Skyboxes: http://quake.stuff.gen.nz



   ---



Quake III Arena file naming convention:

If you plan on distributing other resources separately, we [id Software] strongly 
recommend the following naming conventions:

md3-xxx.pk3 User Model with original associated skin files and sound files
bot-xxx.pk3 User bot files. May contain additional model or skin and texture files
skin-xxx.pk3 User skin with associated skin and texture files
map-xxx.pk3 User created map(s) and supporting files (arena, texture, sound, music)
tex-xxx.pk3 User texture and shader files
snd-xxx.pk3 Sounds only
mus-xxx.pk3 Music only
pfb-xxx.pk3 Map prefabs

(special thanks to Rogue13 of http://www.polycount.com for this naming convention)
