 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whiteBall : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.AddForce(-15, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.AddForce(15, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            _rigidbody.AddForce(0f, 0f, 15);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _rigidbody.AddForce(0f, 0f, -15);
        }
    }
}
