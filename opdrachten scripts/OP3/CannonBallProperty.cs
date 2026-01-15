using UnityEngine;

public class CannonBallProperty : MonoBehaviour

{
   public Rigidbody2D rbBall;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        rbBall = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
