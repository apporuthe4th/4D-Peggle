using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class bumperbreak : MonoBehaviour
{
    public UnityEvent MediumHit;
    public static event Action<string> onBumperHit;
    private int HitsToBreak = 5;    
    AudioSource BumperSound;
    public void Start()
    {
        BumperSound = GameObject.Find("mediumbumper_sound").GetComponent<AudioSource>();
        MediumHit.AddListener(GameObject.FindGameObjectWithTag("GameController").GetComponent<Score>().MediumBumperTrigger);

    }
    private void OnCollisionExit2D(Collision2D collision)
    {

        HitsToBreak--;
        BumperSound.Play();
        MediumHit.Invoke();
    }


    void Update()
    {
        if (HitsToBreak==0)
        {
            Destroy(gameObject);
            Debug.Log("broken " + gameObject);
        }
    }
}
