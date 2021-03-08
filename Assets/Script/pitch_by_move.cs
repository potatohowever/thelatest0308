using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pitch_by_move : MonoBehaviour
{
    AudioSource audio;
    const float value = 0.01f;
    public Transform other;
    float _distance = 0;
    float firstdis = 0;
    // Start is called before the first frame update
    void Start()
    {
        firstdis = Vector3.Distance(other.position, transform.position);
        print(firstdis);
        audio = GetComponent<AudioSource>();
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        _distance = Vector3.Distance(other.position, transform.position);
        print(_distance);
        float sa = firstdis - _distance;
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (sa > 0)
            {
                audio.pitch += value;
                firstdis = _distance;
                Debug.Log("agtta");
            }
            else if (sa < 0)
            {
                audio.pitch -= value;
                Debug.Log("sagatta");
            }
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            if (sa > 0)
            {
                audio.pitch += value;
                firstdis = _distance;
                Debug.Log("agtta");
            }
            else if (sa < 0)
            {
                audio.pitch -= value;
                Debug.Log("sagatta");
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (sa > 0)
            {
                audio.pitch += value;
                firstdis = _distance;
                Debug.Log("agtta");
            }
            else if (sa < 0)
            {
                audio.pitch -= value;
                Debug.Log("sagatta");
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (sa > 0)
            {
                audio.pitch += value;
                firstdis = _distance;
                Debug.Log("agtta");
            }
            else if (sa < 0)
            {
                audio.pitch -= value;
                Debug.Log("sagatta");
            }
        }
    }
}
