using UnityEngine;

public class ReplaceItem : MonoBehaviour
{
    [SerializeField] public GameObject pickup;
    internal bool isGone = false;

    void Start()
    {
        if (pickup == null)
        {
            pickup = GameObject.FindWithTag("item");
            if (pickup == null)
                Debug.LogWarning("ReplaceItem: No GameObject with tag 'item' found and no pickup assigned in Inspector.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        isGone = true;
        Debug.Log($"trigger hit; {other.gameObject.tag}");
        if (other.gameObject.tag == "Player")
        pickup.SetActive(false);
        
        else { Debug.Log("setactive not triggered"); }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (pickup == null)
            {
                Debug.LogWarning("null in replace item");
                return;
            }

            pickup.SetActive(!pickup.activeInHierarchy);
            Debug.Log("toggle");
        }
    }
}
