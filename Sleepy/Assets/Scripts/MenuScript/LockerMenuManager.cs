using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LockerMenuManager : MonoBehaviour
{
    public GameObject hatGrid;
    public GameObject shirtGrid;
    public GameObject cameraGrid;

    public void BackButton()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void HatButton()
    {
        shirtGrid.gameObject.SetActive(false);
        cameraGrid.gameObject.SetActive(false);
        hatGrid.gameObject.SetActive(true);
    }

    public void ShirtButton()
    {
        shirtGrid.gameObject.SetActive(true);
        cameraGrid.gameObject.SetActive(false);
        hatGrid.gameObject.SetActive(false);
    }

    public void CameraButton()
    {
        shirtGrid.gameObject.SetActive(false);
        cameraGrid.gameObject.SetActive(true);
        hatGrid.gameObject.SetActive(false);
    }
}
