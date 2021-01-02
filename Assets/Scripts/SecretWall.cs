using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretWall : ButtonTarget
{
    private bool isActive = false;
    public float wallMoveTime = 5.0f;
    
    public void Update(){
        if (isActive) {
            Vector2 scale = transform.localScale;
            scale.y = 0;

            transform.localScale = Vector2.Lerp(transform.localScale, scale, wallMoveTime * Time.deltaTime) ;
            
        }
    }
    public override void Activate(){
        
        isActive = true;
        Debug.Log("Wall activating!");
    }
}
