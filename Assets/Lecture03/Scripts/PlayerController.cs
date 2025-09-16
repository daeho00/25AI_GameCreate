using NUnit.Framework;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class NewMonoBehaviourScript : MonoBehaviour
{
    Rigidbody2D rb;
    bool isJumping = true;
    public float JumpPower = 10.0f;

    public GameObject text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping = true;
        text.SetActive(false);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isJumping = false;
        }
        if (collision.gameObject.CompareTag("Spike"))
        {
            Destroy(gameObject);
            text.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

        {
            Debug.Log("space");
            

            if (Keyboard.current.spaceKey.wasPressedThisFrame && !isJumping)
            {
                Debug.Log("Player : 점프(Space Bar Pressed)");
                 rb.linearVelocity = new Vector2(0, JumpPower);
                 isJumping = true;
             }
            
            
        }
    }
}
