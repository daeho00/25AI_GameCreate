using UnityEngine;
using UnityEngine.UIElements;

public class SpikeAction : MonoBehaviour
{
    float start_point;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
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
