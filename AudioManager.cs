using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sounds[] sounds;
    public static AudioManager instance;
    
    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (instance == null)
        {
            instance = this;
        }
            else
            {
                Destroy(gameObject);
                return;
            }
       
        foreach(Sounds s in sounds)
        {   s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.voulume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;        
        }

        
    }

    public void Play(string name)
    {
    
       Sounds s = Array.Find(sounds, sounds => sounds.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound:" + name + "not there!!!");
            return;
        }
        s.source.Play();
    }

    public void Stop(string name)
    {
        Sounds s = Array.Find(sounds, sounds => sounds.name == name);
        s.source.Stop();
    }
}
