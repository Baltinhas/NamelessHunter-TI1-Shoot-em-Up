using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneManager : MonoBehaviour
{
   public string scene; 
   public void OnButtonLoadScene()
   {
        SceneManager.LoadScene(scene);
   }

}
