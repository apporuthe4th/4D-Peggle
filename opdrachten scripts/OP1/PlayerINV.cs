using UnityEngine;

public class PlayerINV : MonoBehaviour
{
    
    internal int itemCount;
    private bool gone;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ReplaceItem burber = new ReplaceItem 
        {};
        gone = burber.isGone;
    }

    // Update is called once per frame
    void Update()
    {
        if (gone == true)
        {
            itemCount++;
            Debug.Log($"item gotten" + itemCount);
        }


        if (Input.GetKeyDown(KeyCode.R))
        {
            itemCount = 0;
        }
    }
}
