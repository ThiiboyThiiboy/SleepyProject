using UnityEngine;
using System.Collections;
using DG.Tweening;

public class CameraShake : MonoBehaviour
{
	public static CameraShake instance;

	private void Awake()
	{
		instance = this;
	}

	private void OnShake(float duration, float strength)
	{
		transform.DOShakePosition(duration, strength);
		transform.DOShakePosition(duration, strength);
	}

	public static void Shake(float duration, float strength) => instance.OnShake(duration, strength);
}
