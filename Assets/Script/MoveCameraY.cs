using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraY : MonoBehaviour
{
    [SerializeField] public Vector3 offset;
    [SerializeField] public Transform player;

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.y = (player.position + offset).y;
        transform.position = position;
    }
}
