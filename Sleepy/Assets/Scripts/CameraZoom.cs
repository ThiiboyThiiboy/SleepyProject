using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public Transform cameraPos;
    public Transform phonePos;

    [Range(0f, 10f)]
    public float zoom;

    // Start is called before the first frame update
    void Start()
    {

	}

    // Update is called once per frame
    void Update()
    {
        Vector3 v3 = new Vector3(phonePos.position.x, phonePos.position.y, zoom);
		cameraPos.TransformDirection(v3);
        cameraPos.rotation = phonePos.rotation;
    }
}
