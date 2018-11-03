using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRUN : PlayerFSMState
{

    public Transform marker;
    public float moveSpeed = 3.0f;
    void Start()
    {
        marker = GameObject.FindGameObjectWithTag("Marker").transform;
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(
        transform.position,
        marker.position,
        moveSpeed * Time.deltaTime);
    }
}


