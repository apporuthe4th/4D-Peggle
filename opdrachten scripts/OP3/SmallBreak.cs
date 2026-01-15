using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class smallbumperbreak : MonoBehaviour

{
    private int HitsToBreak = 3;
    private AudioSource BumperSound;
    public UnityEvent SmallHit;
    public void Start()
    {
        BumperSound = GameObject.Find("smallbumper_sound").GetComponent<AudioSource>();
        SmallHit.AddListener(GameObject.FindGameObjectWithTag("GameController").GetComponent<Score>().SmallBumperTrigger);

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        HitsToBreak--;
        Debug.Log(HitsToBreak);
        BumperSound.Play();
        SmallHit.Invoke();
    }


    void Update()
    {
        if (HitsToBreak==0)
        {
            Destroy(gameObject);
            Debug.Log("small broken " + gameObject);
        }
    }
}
