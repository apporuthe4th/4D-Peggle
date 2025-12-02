using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class followCursor : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cursorFollow();
        
    }
    void cursorFollow()
    {
        Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
    }

}
