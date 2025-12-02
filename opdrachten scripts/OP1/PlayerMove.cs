using UnityEngine;

public class NewMonoBehaviourScript1 : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 XSLOWposSPEED = new Vector3(0.2f, 0, 0);
    public Vector3 XSLOWnegSPEED = new Vector3(-0.2f, 0, 0);
    public float MoveSpeed = 500f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            rb.AddForce(XSLOWposSPEED * MoveSpeed * Time.deltaTime, ForceMode.VelocityChange); // X axis positive


        }
        if (Input.GetKey(KeyCode.Q))
        {
            rb.AddForce(XSLOWnegSPEED * MoveSpeed * Time.deltaTime, ForceMode.VelocityChange); // X axis negative
        }

    }
}