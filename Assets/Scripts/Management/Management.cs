using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Management : MonoBehaviour
{
    GameObject player;
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");
        Cursor.lockState = CursorLockMode.Locked;
        Synchronise();
    }
    void Synchronise()
    {
        SetSensitivity();
        SetInvertion();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            if (!menuIsOpen)
            {
                OpenMenu();
            }
            else
            {
                CloseMenu();
            }
        }
    }

    //  Pause menu

    bool menuIsOpen = false;
    [SerializeField] GameObject canvas_Pause;
        //Settings
            //Mouse sensitivity
    float slidVal; // slider value
    [SerializeField]Slider mouseSlider;
    [SerializeField]TextMeshProUGUI slidTxt;
            //Mouse sensitivity

            //Mouse invertion
    [SerializeField] Toggle mouseToggle;
    bool mouseVal;
            //Mouse invertion
        //Settings

    public void SetInvertion()
    {
        mouseVal = mouseToggle.isOn;
        player.GetComponent<Player_Movement>().inverted = mouseVal;
    }
    public void SetSensitivity()
    {
        slidVal = mouseSlider.value;
        slidTxt.text = slidVal.ToString("F1");
        player.GetComponent<Player_Movement>().sensitivity = slidVal;
    }
    void OpenMenu()
    {
        Cursor.lockState = CursorLockMode.None;
        canvas_Pause.SetActive(true);
        Time.timeScale = 0f;
    }
    public void CloseMenu()
    {
        canvas_Pause.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
    }

    //  Pause menu
}
