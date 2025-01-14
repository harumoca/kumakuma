using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dance : MonoBehaviour
{
    int count = 0;
    public int maxCount = 2;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            if (count <= maxCount)
            {
                count++;
            }
            else
            {
                count = 0;
            }
            anim.SetInteger("counter", count);
        }
    }
}
