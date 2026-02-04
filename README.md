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
