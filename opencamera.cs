using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class opencamera : MonoBehaviour
{

    public GameObject loading;
    public void Start()
    {
        loading.SetActive(false);
    }
    public void OpenARCAM()
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex +1));
        loading.SetActive(true);
    }
}
