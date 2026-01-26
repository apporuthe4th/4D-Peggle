# 4D-Peggle

## 4D Multiversal TimeTravel Peggle
    Roguelike
   
     (TimeStop 10s in past checkpoints 1s each, SaveScum, Adding Bumpers&Other items    into the run, More Fails, More stops, )
         Energy Bar which increases with each failed run (The More You Die The Less Score You Get)
         
         [it drains with each timestop or slowed down time or placed bumpers]
Gameplaykern;
1. Een ronde bal
2. bewegende zwevende objecten of kannonen die de plaer targetten
3. Je verliest punten met elk object dat je neer zet & verliest ook score als je dood   gaat maar,            je krijgt meer energie om objecten & abilities te gebruiken des te meer je dood gaat 
4. Eenmaal als je alle pickups pakt of als je de finish haalt
5. Als je te lang stil staat ga je dood of als je geraakt wordt door een van de vijanden
6. Je kan in 8 plekken kiezen waar je de bal vandaan wilt schieten
Stijl & Sfeer;
    choatisch
Structuur van het level;
BovenAan [Veld met targets & vijanden]
Midden [Schietplek]
Onderaan [Veld met targets & vijanden]
### LevelSchets
<img width="1920" height="1080" alt="levelschets" src="https://github.com/user-attachments/assets/652d18e1-4ab9-43bd-829c-ab2ac57c2c27" />




OPGV 1. Array 1A
<img width="2555" height="1058" alt="cess" src="https://github.com/user-attachments/assets/4c6e1b38-6606-4c79-8db9-128b355750b9" />

`
```C#
using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandoPrint : MonoBehaviour
{

    public int[] ChoiceList = new int[7];
    

    private void Start()
    {

        for (int i = 0; i < ChoiceList.Length; i++)
        {
            ChoiceList[i] = i + 1;
        }

        PrintAllItems();
        PrintRandomItem();
    }
    private void PrintRandomItem()
    { 
        
        int RandomINT = Random.Range(1, 7);
        int randoquestion = ChoiceList[RandomINT];
        Debug.Log(randoquestion);
    }
    private void PrintAllItems()
    {
        Debug.Log("Printing all items:");
        foreach (int item in ChoiceList)
        {
            Debug.Log(item + " listoo");
        }
    }



    void Update()
    {
            if (Input.GetKeyDown(KeyCode.E)) PrintRandomItem();
            if (Input.GetKeyDown(KeyCode.Q)) PrintAllItems();
    }
}
RandoPrint.cs…]()
```


OPGV 2. Forces & collisions 1A
https://youtu.be/CHa0KOXeKLk
Reflectie – Week 2

    Wat heb je deze week gemaakt.
Een movement systeem voor een game & Herhaling van Arrays

    Hoe heb je dit aangepakt.
Met veel enthuisiasme en frustratie, (procesmatig werken iets zoals dat)

    Waar liep je tegenaan en hoe heb je dat opgelost of wat heb je nodig.
Ik begon eerst op sites zoals de Unity Handbook & SO/Reddit te zoeken, als dat niet werkte vroeg ik voor hulp bij de docent

    Welke theorie of Unity-onderdelen heb je geleerd of toegepast
AddForce, Rigidbody, Collider, OnCollisionEnter
![ABOING](https://github.com/user-attachments/assets/01506616-a51b-456b-8d66-fbda5b6ac916)
&ook OP2 scripts
 ```C#
  void Update()
   {
       double speed = rb.linearVelocity.x;

       //rb.rotation = holycamera.rotation;
       //FreeLook_Camera.transform.rotation = cammyrotation;
       // slow rolls
       if (Input.GetKey(KeyCode.E))
       {
           rb.AddForce(XSLOWposSPEED * MoveSpeed * Time.deltaTime, ForceMode.VelocityChange); // X axis positive


       }
       if (Input.GetKey(KeyCode.Q))
       {
           rb.AddForce(XSLOWnegSPEED * MoveSpeed * Time.deltaTime, ForceMode.VelocityChange); // X axis negative
       }

       // counter velocity with opposite key
       if (speed >= 5)
       {
           if (Input.GetKey(KeyCode.A))
           {
               rb.linearVelocity = Vector3.zero;
               counterEffect.Play();
           }
       }
        if (speed <= -5)
           {
               if (Input.GetKey(KeyCode.D))
               {
                   rb.linearVelocity = Vector3.zero;
                   counterEffect.Play();
               }
           }

           // fast rolls
           if (Input.GetKeyUp(KeyCode.D) && SHORT_cooldown == false)
           {
               rb.AddForce(XposSPEED * MoveSpeed, ForceMode.Impulse); // X axis positive
               dasheffect.Play();
               SHORT_cooldown = true;
               StartCoroutine(ResetSUPERSHORTCooldown());
           }

           if (Input.GetKeyUp(KeyCode.A) && SHORT_cooldown == false)
           {

               rb.AddForce(XnegSPEED * MoveSpeed, ForceMode.Impulse); // X axis negative
               dasheffect.Play();
               SHORT_cooldown = true;
               StartCoroutine(ResetSUPERSHORTCooldown());
           }

           if (Input.GetKeyUp(KeyCode.W) && cooldown == false)
           {
               rb.AddForce(YposSPEED * MoveSpeed, ForceMode.Impulse); // Y axis positive
               upwardseffect.Play();
           cooldown = true;
               StartCoroutine(ResetCooldown());
           }
           if (Input.GetKeyUp(KeyCode.S))
           {
               rb.AddForce(YnegSPEED * MoveSpeed, ForceMode.Impulse); // Y axis negative
               Debug.Log("launaosfaljkfaflnl");
           }
}
 ```








# 2.2 Mikken, Shieten en Line Renderer
![Animation](https://github.com/user-attachments/assets/5962a212-9c9f-4b79-9ddb-e7660c0e899a)

# 3.2: Bumpers en Combo System
![3 2](https://github.com/user-attachments/assets/7f12143e-f83a-40b9-a813-d814327f77fe)




# 3.1 Score & Triggers 
3.2 gif heeft ook score
![3 2](https://github.com/user-attachments/assets/7f12143e-f83a-40b9-a813-d814327f77fe)
``` C# 
using Unity.VisualScripting;
using UnityEngine;

public class Score : MonoBehaviour
{
    public double currentScore;
    public double currentMultiplier;
    private string tag;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tag = gameObject.tag;
    }
    public void MediumBumperTrigger()
    {
       currentMultiplier = currentMultiplier + 0.5;
       currentScore = currentScore + 100 * currentMultiplier;
       Debug.Log("sMALL Score!" + currentScore + "|  Current Multiplier " + currentMultiplier);
    }

    public void SmallBumperTrigger()
    {
       currentMultiplier = currentMultiplier + 0.1;
       currentScore = currentScore + 50 * currentMultiplier;
       Debug.Log("medium Score!" + currentScore + "|  Current Multiplier " + currentMultiplier);
    }

    void Update()
    {
        currentMultiplier = currentMultiplier - 0.01 * Time.deltaTime;
    }
}



// if (bool buttonClicked == true){
//enable the cannon script
// }

```

#4.1: Level design & UI Opdracht
geluidverdiept elke keer als het bumper raakt
![ashshhsa](https://github.com/user-attachments/assets/2145218f-bbb1-41e2-acc4-08a20ebffa92)


#5.2 Peggle Game, Particles, Sounds & Shakes
![americaaaa](https://github.com/user-attachments/assets/f0050371-284f-4a42-afdd-441bba0dca3c)


6.1 Custom featrures&Release
I added placement of blocks
![customfeature2](https://github.com/user-attachments/assets/ac2741c9-025f-4f1e-a22f-2d92a051ceea)



