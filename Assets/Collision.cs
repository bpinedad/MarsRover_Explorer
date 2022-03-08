using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] Color32 hasSampleColor = new Color32(200, 115, 115, 100);
    [SerializeField] Color32 noSampleColor = new Color32(255, 255, 255, 255);

    [SerializeField] float timeDelay = 0.3f;
    bool hasSample = false;

    //Store sprite renderer
    SpriteRenderer spriteRenderer;

    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = noSampleColor;
    }

    //Get info from object you collided with
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Damn dude la cagas");
    }

    //To know an object enter a collision region - sprite can be turned off to hide it
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Base" && hasSample){
            Debug.Log("Delivered");
            hasSample = false;
            spriteRenderer.color = noSampleColor;
        } else if (other.tag == "Sample" && !hasSample) {
            Debug.Log("Picked Up");
            hasSample = true;
            spriteRenderer.color = hasSampleColor;
            Destroy(other.gameObject, timeDelay);
        } else if (other.tag == "Crater"){    
            transform.localScale = new Vector3 (0.75f,0.75f,1f);
            Debug.Log("Inside of Crater");
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.tag == "Crater"){   
            transform.localScale = new Vector3 (1f,1f,1f);
            Debug.Log("Out of crater");
        }
    }
}
