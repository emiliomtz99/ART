using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backbtn : MonoBehaviour
{
    // Start is called before the first frame update
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
                FindObjectOfType<AudioManager>().Stop("Super Sayan");
                FindObjectOfType<AudioManager>().Stop("DBZ theme");
                FindObjectOfType<AudioManager>().Stop("DB theme");
                Application.Quit();
        }
        else
        {
            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                    FindObjectOfType<AudioManager>().Stop("Super Sayan");
                    FindObjectOfType<AudioManager>().Stop("DBZ theme");
                    FindObjectOfType<AudioManager>().Stop("DB theme");
                    SceneManager.LoadScene(0);
            }
        }

        }
    }

    // Update is called once per frame
}