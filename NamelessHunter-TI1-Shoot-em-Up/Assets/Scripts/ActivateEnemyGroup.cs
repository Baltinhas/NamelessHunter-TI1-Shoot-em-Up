using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateEnemyGroup : MonoBehaviour
{
    public GameObject group;
    public string triggerTag;
     void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag(triggerTag))
       {
            group.SetActive(true);
       }
        
    }
}
