using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
{
    public GameObject[] ballPF;
    private GameObject temp;
    MoveScript moveScript;
    CollisiobDetector collisionscript;

  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            int index = Random.Range(0, ballPF.Length);
            Vector3 position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);
            temp = Instantiate(ballPF[index],position, transform.rotation);
            
           moveScript = temp.GetComponent<MoveScript>();
            moveScript.enabled = true;
            collisionscript = temp.GetComponent<CollisiobDetector>();
            collisionscript.enabled = true;
        }
       


    }
}
