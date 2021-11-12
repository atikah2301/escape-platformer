using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    void Start() {
        offset = transform.position - player.transform.position;
    }

    //Follow player at fixed distance
    void LateUpdate() {
        transform.position = player.transform.position + offset;
    }
}
