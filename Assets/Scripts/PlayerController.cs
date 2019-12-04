using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontallnput;
    public float speed = 10.0f;

    // Start is called before the first frame update void Start()
    void Start()
    
    { if (transform.position.x <-10)
     transform.position = new Vector3(-10, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
     
    {
      if (transform.position.x >10)
       transform.position = new Vector3(-10, transform.position.y, transform.position.z);
    horizontallnput = Input.GetAxis("Horizontal");
    transform.Translate(Vector3.right * horizontallnput * Time.deltaTime * speed);
    }
}


