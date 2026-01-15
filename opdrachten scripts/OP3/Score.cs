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