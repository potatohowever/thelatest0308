using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage_3_door2_to_door1 : MonoBehaviour
{

    public GameObject me;


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
        me.transform.position = new Vector3(-19.47f, 7.74f, -22.00f);
    }
}
