using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPageButtonScript : MonoBehaviour
{
    public GameObject NextPage;


    public void SwitchToNextScene()
    {
        NextPage.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
