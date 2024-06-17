using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Continue : MonoBehaviour
{    
    public GameObject Panel;
    public GameObject ContinueButton;
    public GameObject GoToMenuButton;

    public void Update()
    {
        Time.timeScale = 1f;
        Panel.SetActive(false);
        ContinueButton.SetActive(false);
        GoToMenuButton.SetActive(false);
        this.GameObject().SetActive(false);
    }
}
