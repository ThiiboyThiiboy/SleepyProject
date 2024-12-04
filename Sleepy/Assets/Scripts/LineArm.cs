using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineArm : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private Transform[] points;

    // Start is called before the first frame update
    void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

	public void SetUpLine(Transform[] points)
	{
		lineRenderer.positionCount = points.Length;
        this.points = points;
	}

	// Update is called once per frame
	void Update()
    {
        for (int i = 0; i < points.Length; i++)
        {
            lineRenderer.SetPosition(i, points[i].position);
        }
    }
}
