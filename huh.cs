﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class huh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D shit)
    {
        if (shit.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }

    }
}
