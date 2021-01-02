using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{

    public ButtonTarget target;
    

       private void OnCollisionEnter2D(Collision2D other) {
           if (other.gameObject.CompareTag("Player")) {
               Debug.Log("player hit the button");
                target.Activate();
           }
       }
  
}
