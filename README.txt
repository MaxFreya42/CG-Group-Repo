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


////////// FINAL COURSE PROJECT README SECTION ///////////

Dust:
What is it?
The dust effect is a simple particle system where random particles fall slowly, simulating dust in the air. 
How does it work? 
It utilizes a sphere shape for its particle dispersion, this combined with slow speed setting allows the particles to drift down slowly to simulate dust. 
Why did we choose it? 
We chose to use a dust effect as it would add to the immersion of our dungeon aesthetic. 
Source: https://youtu.be/tPtRCpwSgBg?si=Wi3XRtw-MyogseIN

Water droplets: 
What is it? 
Uses a particle system which only shoots a single droplet in random intervals, this simulates the visual of water dropping slowly from the ceiling. 
How does it work?
By reducing the particle amount to 1 and altering the effect’s speed and gravity, the droplets appear more realistic.
Why did we choose this?
We chose this effect because it aided the immersion of our scene, adding to the old, damp dungeon aesthetic. 

Footprint decals:
What is it? 
Decals are generated back and forth from spawn points on the rat’s back feet. This appears to leave a trail behind the rat. 
How does it work? 
Using two sets of code, one which spawns the prints alternating between the two different feet, and one which raycasts down and returns IsGrounded. If the player is on the ground, footprints can be cast.
Why did we choose it?
We chose to add this footprint effect because it adds a more natural feel to the movement and fits well with the environment of the scene.
Source: https://youtu.be/6-a2oTtm-eg?si=vFIIYaWgk3bpsPHF

Water scrolling effect:
What is this?
A process of UV manipulation that can move an object's texture across the x,y,z coordinates 
How does it work? Show shader graph or code
Combines time and base speed
Vector 2 applied to our offset 
Applied twice and combined with Add to create water variety
Why did we choose to use it?What's it doing for us
Create moving water for our games pixelated cartoon style, and simulate water depth using 2 scrolling textures. 

Water Vertex Displacement:
What is this?
A process that manipulates the vertices of a 3D mesh in real time, and can be used for many different visual applications
How does it work? Show shader graph or code
Applied to out vertex position, 
Why did we choose to use it?What's it doing for us
To create visual movement for our rushing water in our scene, and bring it to life.
Source: https://www.youtube.com/watch?v=2OHUgstFEgQ&list=PLjk4mCUDZyHgpzjhFmgO6-_YPZwVMDLC5&index=2

Water Foam Effect:
What is this?
By using a depth fade interaction we can calculate interactions between 3D objects
How does it work? Show shader graph or code
Uses Depth fade (can be made as a subgraph)
Time and tile and offset applied to gradient noise to create visual variety
Combined at the end with our lerp and scrolling texture
Why did we choose to use it?What's it doing for us
Create interactable water that reacts to its environment

Water Misty Particles:
What is this?
Custom Particle effect using a drawn 2D asset to create a stylized waterfall mist 
How does it work? Show shader graph or code
Particle Effect System
Cone Shape Emission
Noise and Frequency
Why did we choose to use it?What's it doing for us
Add the final cherry on top to the water in our scene.

Torch Fire:
What is this?
A particle effect system using a variety of different settings to create stylized flame effect
How does it work?
Noise to create variety 
Size over lifetime
Rotation
Why did we choose to use it?What's it doing for us
To bring our torches in our scene to life and make them really stand out even more. 

Smoke & Embers Effect:
What is this?
Particle Effect system that emits a custom transparent texture
How does it work? 
Colour over lifetime 
Emission to ensure glow
Noise
Why did we choose to use it?What's it doing for us
To make cartoon fires feel more real and warm, adds a sense of coziness to our game.

Stinky Cheese: 
What is this?
Added cartoon stink lines above the cheese.
How does it work? Show shader graph or code
An altered version of the water shader is covered in class to give it a wobbling effect, and an added transparency so that only the sections of the plain we want to be seen are visible.
Why did we choose to use it?What's it doing for us
This added to the lighthearted and goofy atmosphere inherent to our games design and makes the end goal area feel less static.

Finalized Lighting Effect:
Used Fog to finalize the dewy murky aspect of our dungeon and make it feel more misty from the water

Depth of field to create a sense of scale for the rat, rat vision.

Lighting Lens flares to add even more pretty visual effects to our scene and help our lighting stand out even more. 







