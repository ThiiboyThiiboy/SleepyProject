using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineTest : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private LineArm line;

    // Start is called before the first frame update
    void Start()
    {
        line.SetUpLine(points);
    }
}