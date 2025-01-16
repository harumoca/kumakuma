using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    public float speed = 0.05f;
    public GameObject player;
    public bool isMove = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isMove)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed);
        }
    }
}
