# 4D-Peggle

4D Multiversal TimeTravel Peggle
    Roguelike
     (TimeStop 10s in past checkpoints 1s each, SaveScum, Adding Bumpers&Other items into the run, More Fails, More stops, )
         Energy Bar which increases with each failed run (The More You Die The Less Score You Get)
         [it drains with each timestop or slowed down time or placed bumpers]


OPGV 1. Array 1A
<img width="2555" height="1058" alt="cess" src="https://github.com/user-attachments/assets/4c6e1b38-6606-4c79-8db9-128b355750b9" />


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
RandoPrint.cs…]() ```


OPGV 2. Forces & collisions 1A
https://youtu.be/CHa0KOXeKLk

 ```
C#  void Update()
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
}```
