using NUnit.Framework.Internal;
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
