# GDIM32 In Class Activities
## Week 1
### Activity 1
Advice for Acing the Class: 

- LA tech support, office hours
- Be nice to LAs 
- Start assignments early
- Playtesting (CHECK YOUR itch.io LINK WORKS)
- Check resources, Unity documentation, forums, lecture slides

### Activity 2
1. x = 10
2. x = 2
3. Every frame prints "hello world" to the debug log.
4. MonoBehaviour
5. PrintMessage(10) is calling a function called PrintMessage and is passing in the integer 10. The method prints "x = 10".
6. (10) passes in an integer 10 to the function (argument), then the function adds the passed in integer into a string for the Debug.Log (parameter).
7. In the translate function, it's using the object class Transform.
8. It should be changed to _playerTransform.

### Activity 3
[MG1 Breakdown Doc](https://docs.google.com/document/d/11NYqSVvzWFbjYSesEhZULsuZtHzjsLqqcApzmbzIQNQ/edit?usp=sharing)

## Week 2
### Activity 1 
<img width="4308" height="2731" alt="image" src="https://github.com/user-attachments/assets/6d45bd0b-b40c-47ad-b844-bd9a3797517c" />

### Activity 2
[MG2 Commit](https://github.com/UCI-GDIM32-W25/mg2-oop-review-zomffin/commit/fbfda7c5933d5127c9618e15f4bb2cc51843a52d)

I worked on getting the player jump to work right. I ended up doing a physics based jump since I made the ground a rigidbody for the player to sit on. I also had to remember the difference between OnTriggerEnter2D and OnCollisionEnter2D. I've been making a habit of using CompareTag on trigger checks but that doesn't work for the collision check. 

## Week 3 
### Activity 1 & 2
buddies: Zoya and Kristin

### Activity 3
<img width="4284" height="3457" alt="image" src="https://github.com/user-attachments/assets/b94b8720-5eec-4582-b9a2-30539f47629e" />

## Week 4
buddies: Zoya and Kristin again hehe
### Activity 1 
I added multiple GameObjects with the Locater script on them. I noticed when I ran the game, that the extra GameObjects stayed but when inspected, the Locater component was gone. The last one in the Hierarchy is the only one that kept the Locater component. 

### Activity 2 
<img width="3744" height="3503" alt="image" src="https://github.com/user-attachments/assets/b88c5aed-4b40-419d-bab0-5261f9df0831" />

- MDV pattern will be useful in this project because we can decouple code between the player, game controller, and visual/audio controller.
- Events can be used everytime the player scores a point, OR hits a pipe and ends the run.
- We can use a singleton locater (gamecontroller) so objects can subscribe to the events the player will send. 

### Activity 3 
[MG4 Commit](https://github.com/zomffin/HW4/commit/579861eb66886f3a88c0c819fbde81a44f467a52)

I set up the project and started importing sprites. I also started adding GameObjects and creating scripts I think I'll need, as well as setting up what will eventually become the obstacle prefab.

## Week 5 
### Activity 1
I think the design of the interfaces and classes are fine, and it makes sense that they're an interface/abstract respectively. One thing I like to do is actually implement the methods in abstract classes so that there's a "default" implementation available. For example I feel like Break() is something that could be generalized (like it activates a particle effect and then destroys the game object). The abstract method makes sense for something like the Item's Use() because that would be fairly unique to the item. 

### Activity 2
I think the Controller is represented by the Player script because it allows the player to interact with the game. The View is the DialogueBubble, Enemy and InventoryUI scripts. The Model are the EnemyStats and Item scriptable objects. 

### Activity 3
**Scenario 1:**

The beat system could use inheritance and polymorphism- so there's a basic abst+
ract beat, which other beats inherit from. There's different types of beats that need a click, hold, or a swipe in a direction. Then you can use a scriptable object to code the data it needs into it- The desired button press, the timing during the song, and the 

**Scenario 2:**

The controrller would be the script that handles player movement and actions (shooting, skills, etc.). The view would be handled by the animations responding to player action, either the player moving their own character around or how they may react to damage when getting shot at (flinching or something), as well as UI for displaying health, the map, etc. The model is all the info under the hood, the player healths, damage, character skills, etc. 

**Scenario 3:**

The player would need a state machine to direct the animations depending on what the player is doing (walking, running, planting, chopping down a tree, etc). 

## Week 6
### GDW Talks
**Talk: Cory Lanham, Narrative**
- 3 Categories of game dev jobs: Freelance, Contract/Project, and In-House
- Freelance tends to do specific deliverables, while In-House have more work across the production timeline.

  Pre-Pro:
- High-Level Summaries, working with concept arts to develop world, setting, & characters.
- Deciding Narrative Delivery Methods: *How* will story be told? *Can* (and how will) the player interact with it?

  Pro:
- Cinematic + Mission Scripts, working with level design, implement and iterate
- Systemic Dialogue (Barks, Ambient dialogue, Specialized dialogue)
- UI/UX text (Item/Location Descriptions, Tool Tips)
  Post-Pro to Ship:
- Marketing, Nondialogue text revisions, Localization notes 

Books/Resources Mentioned:
- Into the Woods
- Video Game Storytelling (Skolnick)
- Game Narrative Toolbox (Heussner et al.)
- ...Survive an Industry that Hates You (Richard Danskey)
- Gamejobs.co
- GrackleHQ.com
- MatthewSeiji.Itch.io/TWWDS

**Talk: Stephen Coan, Tech Art**

Tech Art: Making sure technical problems don't get in the way of art.


Types: 
Character Tech Art: Rigging + Skinning, Animation Tools
Tools Tech Art: Asset Management, Smoothing Import/Export for artists and programmers
Run-Time Tech Art: Shaders, Procedural generation/destruction, Optimization 

Getting into tech-art: 
- Shader editing in unity/unreal
- Scripting for 3D modeling tools (Maya/Blender/Houdini)
- Basics of runtime optimization

Learned about the Unity profiler for checking performance, paired with RenderDoc to be able to check (and time) every draw. 

### Activity 1 
Didn't understand how to do the breakpoint demo on my own (or rather, where I was supposed to put one in the scripts?). The other 2 demos though I was able to figure out, and were interesting. 

I started testing gizmos out on my own a little (mainly to draw lines following raycasts). They are really useful to visualize how code is working, particularly when having to deal with the physics engine and seeing where an object is heading. It's also great for being able to see the colliders during runtime. 


In GDIM 31, my final 3D project ended up lagging pretty bad on any weaker laptops so I tried some band aid fixes to make it a little better. I probably could've better identified what in particular made the game laggy with the profiler. I've been kind of interesting in how PCs work and optimization in games recently. Ever since I built my own PC I'm always checking how different games run and watching the taskmanager.

### Activity 2
We were all at GDW... 
I've forked the final project repo ([here](https://github.com/zomffin/GDIM32-Final])) and invited the others as collaborators. 

[Final Project Proposal (Final Draft)](https://docs.google.com/document/d/1feAz1l25pgZegPoBuH0r0d7QIG4UUXJjzvnXaiCcNWw/edit?tab=t.0#heading=h.y4j3q551ojs1)

## Week 7
### Activity 1
- Raycasting is similar to a bow and arrow: Shoots out a line from an origin point in a specific direction, and then returns info on what it hits.
- out hitInfo, the out parameter saves the info into a variable
- hitInfo.point gives you the position
- Spherecast, a different type of raycast (thick raycast)
- Use gizmos to debug vectors because trying to read them is insane

### Activity 2
Attendance: Zoya McDonnell, Kristin Zhang

### Activity 3
![final plan](https://github.com/user-attachments/assets/d87fd7a0-16de-494f-83fe-a1dc65fdefc8)

### Activity 4
[Planning trello](https://trello.com/b/2C5Di1Dz/32-final)

### Activity 5 
[Final Project Commit](https://github.com/zomffin/GDIM32-Final/commit/fe83c8136dd832cbe22accb8457a5079ebce8598)
Added a basic player movement script 

## Week 8
### Activity 1
Post processing is a shader that affects the entire screen. Doesn't affect one specific material/item. Ex. Bloom or color grading 
To add unity stock post processing, it can be added to the main camera 
Make sure it works with the chosen renderring pipeline! + version of unity!!!

### Activity 2 
Zoya McDonnell, Kristin 

### Activity 3
Zoya is playtesting captain :3 

### Activity 4 
Add jumping and start figuring out throwing items 

