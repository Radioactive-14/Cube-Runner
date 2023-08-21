using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Reference to Rigidbody component
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    private bool hasFallen = false;

    // Update is called once per frame
    // Using "FixedUpdate" because we are using physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -.2f)
        {
            if (hasFallen == false)
            {
                hasFallen = true;
                FindObjectOfType<AudioManager>().Play("PlayerFalling");
            }

            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
