﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private GameObject player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start(){
      player = GameObject.FindGameObjectWithTag("Player");
      offset = transform.position;
    }

    // Update is called once per frame
    void Update(){
      offset.x = player.transform.position.x;
      if (offset.x > 0){
        transform.position = offset;
      }
    }
}
