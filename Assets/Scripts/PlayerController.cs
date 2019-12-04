using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontallnput;
    public float speed = 10.0f;

    // Start is called before the first frame update void Start()
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    horizontallnput = Input.GetAxis("Horizontal");
    }
}


