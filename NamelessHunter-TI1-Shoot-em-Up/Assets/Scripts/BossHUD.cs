using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHUD : MonoBehaviour
{
    public Text Bossname;
    public Slider BossLife;
    
    public string triggerTag;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(triggerTag))
        {
            Bossname.gameObject.SetActive(true);
            BossLife.gameObject.SetActive(true);
        }

    }
}