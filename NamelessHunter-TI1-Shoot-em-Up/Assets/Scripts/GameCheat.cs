using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCheat : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            ChangeToScene("Fase1_Planeta");
        }
        else if (Input.GetKeyDown(KeyCode.F2))
        {
            ChangeToScene("Fase2_Espaço");
        }
        else if (Input.GetKeyDown(KeyCode.F3))
        {
            ChangeToScene("Fase3_BossFight1");
        }
        else if (Input.GetKeyDown(KeyCode.F4))
        {
            ChangeToScene("Fase4_BossFight2");
        }
    }

    public void ChangeToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}