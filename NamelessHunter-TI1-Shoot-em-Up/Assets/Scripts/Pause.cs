using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public Transform Pausemenu;
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Escape))
       {
            if (Pausemenu.gameObject.activeSelf)
            {
                Pausemenu.gameObject.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                Pausemenu.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
       }
    }

    public void Resume()
    {
        Pausemenu.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
