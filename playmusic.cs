using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class playmusic : MonoBehaviour
{
    public int op;
    public string sonido1 = "Super Sayan";
    public string sonido2 = "DBZ theme";
    public string sonido3 = "DB theme";
    public void Musicaa()
    {
        FindObjectOfType<AudioManager>().Play(sonido1);

        op = Random.Range(1, 3);

        switch (op)
        {
            case 1:
                FindObjectOfType<AudioManager>().Play(sonido2);
                break;

            case 2:
                FindObjectOfType<AudioManager>().Play(sonido3);
                break;           
        }
    }

    // Update is called once per frame
    public void QuitMusica()
    {
        FindObjectOfType<AudioManager>().Stop("Super Sayan");
        FindObjectOfType<AudioManager>().Stop("DBZ theme");
        FindObjectOfType<AudioManager>().Stop("DB theme");
    }
}
