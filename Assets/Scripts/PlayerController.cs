using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigidbody;

    private float movementSpeed = 5;
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * movementSpeed, rigidbody.linearVelocity.y);
        
    }
}
