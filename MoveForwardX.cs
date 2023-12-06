using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward

public float speed = 20;

// Update is called once per frame
void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

