using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnerLeft;
    public GameObject spawnerRight;
    public Material mat;
    public GameObject pfUFO;
    public GameObject pfAlien;
    public static List<Color> colorList;
    [Range(1,1000)] 
    public int maxUFOs;
    public static List<GameObject> listUFOs;
    public static bool isRight;

	private void Awake()
	{
		colorList = new List<Color>() { Color.red, Color.blue, Color.green, Color.yellow, Color.cyan, Color.magenta };
		listUFOs = new List<GameObject>() { pfUFO, pfAlien };
	}
	// Start is called before the first frame update
	void Start()
    {
        isRight = false;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] gowtUFO = GameObject.FindGameObjectsWithTag("UFO");
        GameObject[] gowtRightUFO = GameObject.FindGameObjectsWithTag("rightUFO");

            if (gowtUFO.Length < maxUFOs)
            {
				GameObject newPfUFO = listUFOs[Random.Range(0, listUFOs.Count)];
				GameObject newUFO = Instantiate(newPfUFO, RandomPointInBounds(spawnerLeft.GetComponent<Collider>().bounds), Quaternion.identity);
				newUFO.GetComponent<Renderer>().material.color = colorList[Random.Range(0, colorList.Count)];
                isRight = true;
			}
            if (gowtRightUFO.Length < maxUFOs)
            {
				GameObject newPfUFO = listUFOs[Random.Range(0, listUFOs.Count)];
				GameObject newUFO = Instantiate(newPfUFO, RandomPointInBounds(spawnerRight.GetComponent<Collider>().bounds), Quaternion.identity);
                newUFO.gameObject.tag = "rightUFO";
				newUFO.GetComponent<Renderer>().material.color = colorList[Random.Range(0, colorList.Count)];
				isRight = true;
			}
    }

	public static Vector3 RandomPointInBounds(Bounds bounds)
	{
		return new Vector3(
			Random.Range(bounds.min.x, bounds.max.x),
			Random.Range(bounds.min.y, bounds.max.y),
			Random.Range(bounds.min.z, bounds.max.z)
		);
	}
}
