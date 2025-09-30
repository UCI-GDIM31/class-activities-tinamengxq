# in-class-activities
## Devlogs
### W1
Week 1 in-class activity
Prompt:
In the Hierarchy, move the Camera off of the Cat GameObject, so that it’s no longer a child of the Cat. What happens when you run the game now, and why?
Devlog:
Based on my experiment, the camera stays still on the NewStart postition, and the cat goes away from it as players use wasd to control the movement of the cat. 

In class during the activity, when I tried to edit the position vector of the Camera to the NewStart position after editing the position vector of the Cat GameObject, I found that the same vector components cannot make the Camera and the kitten staying at the same place. LA Allan told me that the position vector of the Camera is the relative position change compared to the whole Cat GameObject, which is presented by the position of kitten. This is because the Camera is a child of the Cat. Thus, based on my tiny knowledge learned during summer through youtube and the guidance by Allan, I believe that the difference is due to the disconnection between the Camera and the Cat.

So originally, the Camera is under the Cat GameObject, so it is a child of the Cat. The "player" script that controls the movement of the kitten controls the whole Cat GameObject, so the Camera is also controled by the player. After the Camera is moved off the Cat GameObject, controlling the Cat GameObject cannot control the Camera once again. That's why the Camera stays still and the kitten moves alone.


### W2
Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 