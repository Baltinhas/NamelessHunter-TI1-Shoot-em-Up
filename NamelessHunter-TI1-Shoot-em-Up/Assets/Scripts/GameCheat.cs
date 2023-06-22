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
    }

    public void ChangeToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}