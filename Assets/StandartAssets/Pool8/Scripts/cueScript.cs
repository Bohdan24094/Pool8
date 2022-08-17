using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cueScript : MonoBehaviour
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
        if (Input.GetKey(KeyCode.W))
        {
            _rigidbody.AddForce(15 , 0f, 0f);
        }
    }

}
