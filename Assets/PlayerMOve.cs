using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using Cinemachine;

public class PlayerMOve : MonoBehaviour
{
    public float speed = 0.1f;
    public CinemachineVirtualCameraBase vcam1;
    public CinemachineVirtualCameraBase vcam2;
    public float maxTime = 2;
    float time = 0;
    bool isTime = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if (isTime)
        {
            time += Time.deltaTime;
            if(time >= maxTime)
            {
                vcam1.Priority = 1;
                vcam2.Priority = 0;
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward*speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speed;
        }
        

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "change")
        {
            vcam1.Priority = 0;
            vcam2.Priority = 1;
            isTime = true;
        }
    }
}
