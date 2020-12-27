# ProceduralSpace

Name: Andrew McGowan

Student Number: C16470866

Class Group: TU856, Computer Science

# Description of the project

This Unity Application represents going through hyperspace passing planets but also with audio visuals. Its uses particle systems, trail renderers, audio synhronizers, canvases and background rendering images to provide a hyperspace visual with music. For this assignment I really went after using Unitys implemented features such as particle systems and trail renderers.

The initial plan was to create a procedural space environment but as we learned about audio visualizers after, I was compelled to change it up. 

![Full System](https://github.com/AndrewMcg2309/ProceduralSpace/blob/master/images/Full.JPG)

# Instructions for use

The only instruction is to press play. There are no controls for this application.

# How it works

## Particle Systems
### Light Speed
The light speed effect which is coloured as two different shades of blue was contructed from a particle system. The length of the particles were increadsed to create a more lightspeed effect. The start time was also increased to make the particles move faster. These two combined created a hyperspace visual.

![Particle System](https://github.com/AndrewMcg2309/ProceduralSpace/blob/master/images/ParticleSystem.JPG?raw=true)
	
### Beat System
The Beat hyperspace system is coloured orange. This piece reacts to the music playing whenever there is a heavy beat. This was done by implementing an audio sync scale script which allows objects to increase and reduce depending on sound. 

![Beat System](https://github.com/AndrewMcg2309/ProceduralSpace/blob/master/images/ParticleBeat.JPG)
	
### Planets
Th Planets System allows the visual for passing by planets. A sphere objet was created and the material used for the outside of the sphere was used from the asset store "Star Sparrow Modular Spaceship" [1]. This free asset contained images for the planets. The particle system then generated these planets on a specified time-scale, taking away any chance of overlapping with itself. The size of the planets were randomized in a scale of 2-4. The speed is also randomized from 5-15. These randomized settings stop any patterns and creates a unique experience every time.

![Planets](https://github.com/AndrewMcg2309/ProceduralSpace/blob/master/images/Planets.JPG)
	
### Ring
The ring system is a particle system where I have set the particles to generate at a high scale but do not move from the origin. The particles are generaterated at a high rate. The particles also have a range in the origin which allow the particle strands to appear. This system is also using the beat code which makes it move in response to the music.

![Ring](https://github.com/AndrewMcg2309/ProceduralSpace/blob/master/images/Ring.JPG)

### Small Particles
This extra particle system comtains very small white spheres which give the effect that they are falling off the white particle ring. This was an extra effect.


## Canvas
### Glowing Image
This glowing sphere was created and added to a canvas. The glowing sphere reacts to the music as well as gives a nice hyperspace visual at the enter. 

![Glowing Image](https://github.com/AndrewMcg2309/ProceduralSpace/blob/master/images/Canvas.JPG)

## Trail Renderers
### Shooting stars

## Audio Response
### Code 

# References

## Online
People who made the audio sync

## Asset Store
Real Stars Skybox
For background image of stars 

Star Sparrow Modular Spaceship
For the planet images
 

# What I am most proud of in the assignment

I am most proud of my use of Particle Systems. I found myself really enjoying the different ways you can use them. At first they created the foundations for the application but as I used them more and more I realised how many different was I could use them. They were perfect for the theme of my project which is space. 

While using them I found myself getting more and more immersed using them because I kept getting more ideas on how I could implement them. Because of this I am most proud of my Particle Systems.

______________________________________________________________________________________________________________





# Previous Proposal

# ProceduralSpace
For my assignment I have decided to go after a procedural space environment in Unity. My aim is to create an open environment filled with different types of planets being generated into it. 

## Background

### Inspiration

I first thought of this idea when I was looking over procedural oceans and cities. This led to me thinking of an open 
space with random planets of different sizes, colours and shapes bringing generated in a vast open space. This along with stars far off in the distance really give that space feel. 

Then a lot of ideas started coming to my head like shooting stars and comets. Shooting stars would be far away and show in a flash. Comets can be much bigger and in toughing distance but would have no effect on the user. The comets may then come in groups of 2 or 3.

This reminded me of videos like this:
https://www.youtube.com/watch?v=GoW8Tf7hTGA&ab_channel=morn1415
Just looking through the different features of the planets made me think about generating randomly coloured a designed planet.

### Research

#### Planets
For research my first attempt thought was look for procedural planets. I found a great video of custom designed planets through shifting noise 
on the planet’s surface creating very life-like planets and moons. (https://www.youtube.com/watch?v=GoW8Tf7hTGA&ab_channel=morn1415)
The concepts he goes though in unity are also very interesting as well as his approach through creating the planets.
The picture below of random planets is the type of direction i am heading. Where you can then free roam and fly around them. 
The beauty of doing randomly generated planets gives me a chance to try make some crazy looking ones. Adding rings and other elements may also make it stand out.

![Planets](https://3dwarehouse.sketchup.com/warehouse/v1.0/publiccontent/f93a35cd-6d14-41a5-ab59-4c8ae905f951)


#### Stars
Next, I began to think about the stars. My ideal background would be randomly generated stars that you couldn’t reach. 
Each star would then be a of a random size between two low numbers to keep it realistic. Below is an image of my idea for distant stars to look.
![Space](https://sm.mashable.com/t/mashable_in/photo/default/nasa-galaxy_9pu4.960.jpg)

### Music
For a little background music i was hoping to try do some sort of interstellar type music. Music may really help the user to immerse themself into the world.

### Shooting Star
For the shooting star there were a number of online ideas for it. All which could generate quite simply where a point in a random area has a flash that moves in a straight line of a distance not too small or too large with the trail of the flash following like below.

![Shooting Star](https://specials-images.forbesimg.com/imageserve/1134640769/960x0.jpg?cropX1=0&cropX2=3999&cropY1=560&cropY2=2436)

### Comets
The first thought in my head was Transformers 1 where the autobots start coming down to earth in giant objects on fire. Sadly, with space being a vacuum there can’t be any fire so I will need to have the comet spiralling to give it that realistic movement rather than just a fixed object moving. Transformers also inspired me to potentially put in 2 or 3 comets in a group all heading the same direction. This would give off as if somewhere a planet has exploded or collided with another and debris from it is flying off. For the comet I will try make them random colours (groups are the same colour) as well as looking quite moon-like as well as not perfectly spherical.

![Comet](https://www.futurity.org/wp/wp-content/uploads/2019/12/interstellar-comets_1600.jpg)


