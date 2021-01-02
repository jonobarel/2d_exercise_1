
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : BaseMovement
{
    public Vector2 leftThruster;
    public Vector2 rightThruster;


    private void FixedUpdate()
    {
        Vector2 force = Vector2.zero;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            force += leftThruster;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            force += rightThruster;
        }

        Move(force);
    }

    private void OnCollisionEnter2D(Collision2D other){
        Debug.Log("Collided with object: "+ other.gameObject.name);
        if (other.gameObject.CompareTag("Good")) {
            Debug.Log("hit a good object");
            Destroy(other.gameObject);

        }
        else if(other.gameObject.CompareTag("Bad")) {
            Debug.Log("Hit a bad object!");
            SceneManager.LoadScene(0);
        }

    }
}
