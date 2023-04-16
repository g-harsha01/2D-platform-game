using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollision : MonoBehaviour
{
    
    

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag =="scoring"){
            FindObjectOfType<gamemanager>().IncreaseScore();
        }else if(other.gameObject.tag =="spikes"){
            FindObjectOfType<gamemanager>().Endgame();
        }
    }
}
