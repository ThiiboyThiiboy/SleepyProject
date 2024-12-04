using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChronoBehavior : MonoBehaviour
{
	public float targetTime = 30.0f;
	public TextMeshProUGUI timerTxt;

	void Update()
	{
		if (targetTime <= 0)
			timerTxt.text = 0.ToString() + " s";
		else if (PointCalculus.good)
			targetTime = 30.0f; 
		else
		{
			targetTime -= Time.deltaTime;
			timerTxt.text = Math.Round(targetTime, 0).ToString() + " s";
		}
	}
}
