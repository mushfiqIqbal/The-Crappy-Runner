using UnityEngine;

public class player_movement : MonoBehaviour
{
    public Rigidbody RD;
    public float forcePowerAxis = 1500f;
    public float forcePowerAxis2 = 1500f;
    public float forcePowerAxisjump = 1500f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            RD.AddForce(0, 0, forcePowerAxis * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            RD.AddForce(0, 0, -forcePowerAxis * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            RD.AddForce(-forcePowerAxis2 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("d"))
        {
            RD.AddForce(forcePowerAxis2 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("space"))
        {
            RD.AddForce(0, forcePowerAxisjump * Time.deltaTime, 0);
        }

    }
}
