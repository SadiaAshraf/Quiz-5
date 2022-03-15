using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisiobDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.tag.Equals(collision.gameObject.tag) && gameObject.GetComponent<CollisiobDetector>().enabled)
        {
            collision.gameObject.GetComponent<CollisiobDetector>().enabled = true;
            Destroy(gameObject);
        }
    }
}
