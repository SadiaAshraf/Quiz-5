using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    private float speed = 5.0f;
    private Rigidbody ballRB;
    int range = 40;
    private Transform direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = GameObject.Find("direction").GetComponent<Transform>();
        ballRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        ballRB.AddForce(direction.position * speed * Time.deltaTime, ForceMode.Impulse);
        // transform.Translate(Vector3.forward * Time.deltaTime * speed );
        OutofRange();
    }

    private void OutofRange()
    {
        if (transform.position.x > range || transform.position.x < -range)
        {
            Destroy(gameObject);
        }
        if (transform.position.z > range || transform.position.z < -range)
        {
            Destroy(gameObject);
        }
    }
}
