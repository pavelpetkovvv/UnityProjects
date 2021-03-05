using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseClick : MonoBehaviour
{
    public string InformationSceneName;
    public string QuestionSceneName;

    public GameObject InformationBook;
    public GameObject QuestionBook;

    public GameObject Menu;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit, 10.0f))
            {
                if(hit.transform != null)
                {
                    Debug.Log(hit.transform.gameObject.name);
                    if (hit.transform.gameObject == InformationBook)
                    {
                        SceneManager.LoadScene(InformationSceneName);
                    }
                    if (hit.transform.gameObject == QuestionBook)
                    {
                        SceneManager.LoadScene(QuestionSceneName);
                    }
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Menu.SetActive(true);
        }
    }
}
