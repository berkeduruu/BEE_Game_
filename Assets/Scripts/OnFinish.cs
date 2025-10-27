using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OnFinish : MonoBehaviour
{
    public GameManager manager;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player")){
            manager.finishLevel();
        }
        
    }
}
