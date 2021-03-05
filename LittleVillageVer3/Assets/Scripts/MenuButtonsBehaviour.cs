using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonsBehaviour : MonoBehaviour
{

    public void Continue()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        this.gameObject.SetActive(false);
    }
    public void Quit()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
