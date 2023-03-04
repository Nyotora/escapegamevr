using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmellCode : MonoBehaviour
{

    public GameObject message;
    public GameObject barre;

    private float hp;
    
    // Start is called before the first frame update
    void Start()
    {
        hp = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void receiveSpray()
    {
        if (hp > 0)
        {
            hp = Mathf.Clamp(hp - Time.deltaTime,0,2);
        } else
        {
            message.SetActive(true);
            barre.SetActive(true);
            disappear();
        }
    }

    private void disappear()
    {
        gameObject.SetActive(false);
    }
}
