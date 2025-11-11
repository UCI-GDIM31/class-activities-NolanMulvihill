# in-class-activities
## Devlogs
### W1
Pretend I wrote some beautiful metaphor describing Components, GameObjects, and Scenes here.

### W2
R, g, b are all floats because their values fall somewhere between 0-1 as a decimal which can best be represented by floats

_Bounce you can only bounce a whole number of times and it incrmenets by one each time so the best thing to use to represent it is int

Step 4 had the error cant convert double to float and need to inlcude an 'f' to make 1.0 a float

### W3
bool DidPlayerHitBeat(float hit_time){}; 
Assuming that the class contains the expected float for what time as a member variable

Classes are categories and components are the items of that cateogry. For eacample, a class would be food, and components would be hotdog, hambuger, pasta, etc

### W4
Table 2

line 3: Created a private variable that stores a float to represent move speed

line 22: Calculate the transaltion (how the objects moves along the z axis) and stores it in a variable to be used later. calucualtes using where it is on the horizontal axis, how fast the object moves and how much time has passed

line 25: actually moves the object the calculated translation along the z axis

Rigid body on cat and ball because those need to hit things
goal has is trigger because it has something happen to it when something comes in contact with it

### W5
Question about which UPDATE gets called first
Ordering of UPDATE() is random but they will all run in same frame so it doesnt make too big of a difference (very miniscule)

### W6
[link to google doc](https://docs.google.com/document/d/1g257orHX8bQNaC57k1DMqCDIpAd95jDwpQPqJiA4ks8/edit?usp=sharing)
i did other tools

Member variables:
- boolean for chasing
- customizable speed
- vector to track cat position
Methods:
- start for debugging
- update to check for boolean and move accordingly
- setters for chasing

### W7
[link to google doc](https://docs.google.com/document/d/1G_ZSCA2-UVtHll1uaPGUIZ9OZg3-oBIxvR5bJl7Vl6k/edit?tab=t.0)
environment

it moved the position instead of rotating shouldnt have +='d a variable rather call the roatate function

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
