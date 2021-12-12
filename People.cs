using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People : MonoBehaviour
{

    public static float velocity = 4f;
    private float vel;

    // Start is called before the first frame update
    void Start()
    {
        vel = velocity;
    }

    // Update is called once per frame
    void Update()
    {
        
        moveLeft();
        vel = velocity;

    }

    void moveLeft(){
        transform.position += Vector3.left * Time.deltaTime * vel;
    }


    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Corona")){
            Destroy(gameObject);
        }
    }

}
