# in-class-activities
## Devlogs
### W1


Based on my experiment, the camera stays still on the NewStart postition, and the cat goes away from it as players use wasd to control the movement of the cat. 

In class during the activity, when I tried to edit the position vector of the Camera to the NewStart position after editing the position vector of the Cat GameObject, I found that the same vector components cannot make the Camera and the kitten staying at the same place. LA Allan told me that the position vector of the Camera is the relative position change compared to the whole Cat GameObject, which is presented by the position of kitten. This is because the Camera is a child of the Cat. Thus, based on my tiny knowledge learned during summer through youtube and the guidance by Allan, I believe that the difference is due to the disconnection between the Camera and the Cat.

So originally, the Camera is under the Cat GameObject, so it is a child of the Cat. The "player" script that controls the movement of the kitten controls the whole Cat GameObject, so the Camera is also controled by the player. After the Camera is moved off the Cat GameObject, controlling the Cat GameObject cannot control the Camera once again. That's why the Camera stays still and the kitten moves alone.


### W2

Why are the r, g, and b variables floats instead of ints, bools, or strings?

RGB represents different values of each basic color. As there are million ways of combination of the three basic colors, integer is not enough to show the little bit different between each colors that are really similar. And boolean can only have true or false values, which obviously cannot be used to present small changes. Strings are descriptions/sentences. It might be hard for computers to recognize the descriptions of colors. And strings contain "", so the content between " and " will not be logically recognized by the computer. So float is the best type for r, g, and b.


Why is the _bounce variable an int instead of a float, bool, or string?

_bounce is included in the UI of the game. It shows the number of bounces of the ball. The number of bounces can only be integer. As the variable always changes through time, there will be many changes of value of _bounce. int has the smaller size and is the easier type to present an integer.


The error you got after Step X of Part 2 told you something useful about why that line of code was broken- what was it?

What if I didn't meet any error? Emmm... 
Ah, when I editted the step 8 after I saw some requirements are not met, there were errors showing that there are no brightness vairable that would be mentioned in step 9. So.... Ah... We must announce the variable before operating it in codes.



### W3


## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 