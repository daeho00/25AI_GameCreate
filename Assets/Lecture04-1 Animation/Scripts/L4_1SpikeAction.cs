using UnityEngine;
using UnityEngine.UIElements;

public class L4_1SpikeAction : MonoBehaviour
{
    float speed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 100;
    }

    // Update is called once per frame
    void Update()
    {
        float moveVectorX = Time.deltaTime + speed;
        transform.position = new Vector3(transform.position.x - 0.01f, transform.position.y, transform.position.z);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("SpikeDestroyer"))
        {
            Destroy(gameObject);
            Debug.Log("Spike : 소멸");
        }
    }
}
