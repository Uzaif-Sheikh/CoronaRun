using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoronaVirus : MonoBehaviour
{

    private float velocity = 6;
    private Rigidbody2D body;
    private float timer = 0;
    private int lastValue = -1;

    // Start is called before the first frame update
    void Start()
    {
        
        body = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
        move();
        score();
        increaseSpawning();

    }

    void increaseSpawning(){

        int currentScore = Score.score;

        if(currentScore != 0 && currentScore != lastValue && currentScore%10 == 0){
            float vel = Vaccine.velocity;
            vel += 0.6f;
            Vaccine.velocity = vel;
            People.velocity = vel;
        }

        lastValue = currentScore;

    }


    void score(){

        if(timer > 2f){
            Score.score++;
            timer = 0;
        }

        timer += Time.deltaTime;

    }


    void move(){

        float moveY = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(0f,moveY,0f) * Time.deltaTime * velocity;

    }

}
