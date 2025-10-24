Project Progression - Group 10
Video Report: https://www.youtube.com/watch?v=D1aur_q1O9s


*****PLAYABLE DEMO BUILD*********
**********ON ITHC.IO*************

https://stylesq1.itch.io/cheese-escape



Overview 

*NOTE* If you want a in depth analysis with images of our project watch the video report. 

Diffuse

What is this?
Soft lighting that scatters evenly to a wide area to prevent harsh shadows and glare.
How does it work? Show shader graph or code
Diffuse lighting works by calculating how much light each surface point reflects between the angle of the surface’s normal and the direction of the light
Why did we choose to use it? 
Wanted to create darker shadows in areas where there is less light like in the corners of the room 

Metallic Specular 

What is this?
Metallic surface combined with a bright highlight to simulate a metallic surface
How does it work? Show shader graph or code
Applies a metallic sheen by separating the logic for metallic and non metallic surfaces. Creates highlights by simulating the reflective properties of surfaces.
Why did we choose to use it? 
We chose to use this lighting because it worked well with some of the objects in our scene. It also allowed to further experiment with alternative diffuse lighting setups.

Diffuse + Ambient

What is this?
Combination of diffuse reflections and ambient light
How does it work? Show shader graph or code
Creates brighter shadows by calculating the reflection of the diffuse based on the angle of the light  
Why did we choose to use it?
Use it in for our main structures to create a more misty and ambient environment, we adjusted to colours to match our scenes feel we are looking for

Simple Specular

What is this?
Identifies the bright specular highlights that occur when light hits an object surface and reflects back toward the camera
How does it work? Show shader graph or code
Simulates shine by adding a bright highlight to the surface of the mesh based on the direction of the light and camera
Why did we choose to use it?
Used on materials to create bright natural highlights on the surface of the mesh

Toon Ramp

What is this?
A technique used to create a stylized cartoon effect by using a texture ramp to map values to colors
How does it work? Show shader graph or code
Creates a cel-shaded look by using a texture ramp to define how light affects the surface of the mesh
Why did we choose to use it? What's it doing for us
We chose to use shader to make our rat look more cartoony. 

Colour Correction and LUTS

Colour correction is a way of creating unique filters for your game 
By taking a screenshot of the game, and adjusting the colours of the image, than applying them to the neutral colour LUT 
Then applying that LUT to our Colour Look up
Created a total of 6 different color correction shaders

Rim Lighting Shader

What is this?
 Rim lighting creates lighting around a models edges to help highlight its shape and form. 
How does it work? Show shader graph or code
Uses Normal vector and view directions to calculate angle between them. 
Illuminates edges of a mesh/model
Why did we choose to use it?
Creates visually interesting models
More interactive lighting 
Create specific rim lighting effect

Hologram Shader

What is this?
Creates and silhouette and transparent centre to a model to create a see-through and hologram effect
How does it work? Show shader graph or code
By using a Fresnel effect 
Applying to our base colour and alpha 
Enabling transparent surface type 
Why did we choose to use it?
Wanted to create spooky ghosts that haunt our game
Help make it feel like you can walk through them


Flat Shader

What is this?
A type of shader that applies a flat face to each polygon based on the lighting calculations
How does it work? Show shader graph or code
Creates a low-poly appearance by ensuring the mesh uses uniform normal vectors. 
Why did we choose to use it?
We chose to use this shader because it gave a low poly look to our barrel objects, making it fit better with the rest of the scene.

Outline Shader

What is this?
Creates a silhouette/model around the model akin to line art and helps create a unique cartoon look
How does it work? Show shader graph or code
Expands Model size based on the object's position
Normal vector + position
Clamp to create fade 
Why did we choose to use it? 
Creates cartoon effect
Unique visual and coherent style across all models





