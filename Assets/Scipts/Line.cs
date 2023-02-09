using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public float movespeed = 10.0f;
    private float xDirection;

    private Transform _transform;
    
    // Start is called before the first frame update
    void Start()
    {
        _transform = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxisRaw("Horizontal");

        if ((_transform.position.x <= -7 && xDirection < 0 )|| (_transform.position.x >= 7 && xDirection > 0))
        {
            return;
        }
        _transform.position = new Vector3(transform.position.x + xDirection * movespeed * Time.deltaTime, _transform.position.y,0);
    }
}
