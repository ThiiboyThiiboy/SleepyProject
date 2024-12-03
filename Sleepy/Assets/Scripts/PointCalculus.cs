using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PointCalculus : MonoBehaviour
{
	public Camera mainCamera;
	public Camera cameraPhone;
	public TextMeshProUGUI scoreTxt;
	public TextMeshProUGUI stockTxt;
	public TextMeshProUGUI targetTxt;
	[SerializeField] private int score;
	public int stock;
	public Color colorTarget;
	public string ufoTarget;
	public static bool good;


	// Start is called before the first frame update
	void Start()
    {
		scoreTxt.text = "0";
		GenerateTarget();
		targetTxt.text = ufoTarget;
		targetTxt.color = colorTarget;
	}

    // Update is called once per frame
    void Update()
    {
		targetTxt.text = ufoTarget;
		targetTxt.color = colorTarget;
		stockTxt.text = stock.ToString();
		good = false;
		if (stock > 0)
			RayUFO();
	}

	private void RayUFO()
	{

		RaycastHit hit;
		if (Physics.Raycast(cameraPhone.transform.position, cameraPhone.transform.forward, out hit))
		{
			Debug.DrawRay(cameraPhone.transform.position, cameraPhone.transform.forward * 100.0f, Color.yellow);
			Collider colliderHit = hit.collider;
			if ((hit.collider.tag == "UFO" || hit.collider.tag == "rightUFO") && colliderHit.GetComponent<Renderer>().material.color == colorTarget && LayerMask.LayerToName(colliderHit.gameObject.layer) == ufoTarget)
			{
				CameraShake.Shake(0.2f, 0.2f);
				score += 100;
				scoreTxt.text = score.ToString();
				Destroy(hit.collider.gameObject);
				Debug.Log(colliderHit.GetComponent<Renderer>().material.color + " $ " + LayerMask.LayerToName(colliderHit.gameObject.layer));
				GenerateTarget();
				good = true;
			}
			else if ((hit.collider.tag == "UFO" || hit.collider.tag == "rightUFO"))
			{
				stock--;
				CameraShake.Shake(0.2f, 0.2f);
				Destroy(hit.collider.gameObject);
			}
		}
	}

	void GenerateTarget()
	{
		colorTarget = Spawner.colorList[Random.Range(0, Spawner.colorList.Count)];
		ufoTarget = LayerMask.LayerToName(Spawner.listUFOs[Random.Range(0, Spawner.listUFOs.Count)].layer);
	}
}
