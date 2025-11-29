# 4D-Peggle

4D Multiversal TimeTravel Peggle
    Roguelike
     (TimeStop 10s in past checkpoints 1s each, SaveScum, Adding Bumpers&Other items into the run, More Fails, More stops, )
         Energy Bar which increases with each failed run (The More You Die The Less Score You Get)
         [it drains with each timestop or slowed down time or placed bumpers]


OPGV 1. Array 1A
```C#
[Uploading using NUnit.Framework.Internal;
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
RandoPrint.cs…]()```
