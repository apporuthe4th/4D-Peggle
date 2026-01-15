using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.XR;

public class SummonFire : MonoBehaviour
{
    [SerializeField] GameObject Ball;
    [SerializeField] Transform FirePoint;
    [SerializeField] float Velocity;
    [SerializeField] private float LineSpeed;
    private LineRenderer _line;
    private bool _lineActive = false;
    private float _pressTimer;
    private int maximumHoldTime = 8;
    private float ShootSpeed;
    private float lastSpeed;



    void Start()
    {
        _line = GetComponent<LineRenderer>();
        _line.SetPosition(1,Vector3.zero);
    }

    private void FireCannon(float ShootSpeed)
    {
        GameObject InstanceBall = Instantiate(Ball, FirePoint.position, FirePoint.rotation);
        Rigidbody2D rbBall = InstanceBall.GetComponent<Rigidbody2D>();
        rbBall.AddForce(FirePoint.up * ShootSpeed, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    private void HandleShot()
    {

        if (Input.GetMouseButtonDown(0))
        {
           _pressTimer = 0f;
            _lineActive = true;
            

        }
        if (Input.GetMouseButtonUp(0))
        {
            _lineActive = false;
            _line.SetPosition(1, Vector3.zero);
            
        }
        if (_lineActive)
        {
            _line.SetPosition(1, Vector3.up * _pressTimer * LineSpeed);
            lastSpeed = _pressTimer;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("donml;l");
    }


    void Update()
    {

        HandleShot();
        ShootSpeed = Velocity * lastSpeed;
        if (Input.GetMouseButtonUp(0))
            FireCannon(ShootSpeed);

        if (_pressTimer < maximumHoldTime)
        {
            _pressTimer += Time.deltaTime;
        }




    }

}
