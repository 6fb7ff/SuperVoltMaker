using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour
{
    public bool firstpush = false;
    
    public void SwitchScene()
    {
        if(!firstpush)
        {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);

        firstpush = true;

        }
    }

}