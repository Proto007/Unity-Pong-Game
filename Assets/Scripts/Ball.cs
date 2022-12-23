using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 200.0f;
    public Text startMessage;

    private bool roundStarted = false;
    private Rigidbody2D _rigidbody;

    private void Awake(){
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start(){
        ResetPosition();
    }

    private void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            toggleRoundStart();
            startMessage.text = "";
        }   
        if(roundStarted){
            toggleRoundStart();
            AddStartingForce();
        }
    }

    public void AddStartingForce(){
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);
        
        // direction times the speed
        _rigidbody.AddForce(new Vector2(x, y) * this.speed);
    }

    public void AddForce(Vector2 force){
        _rigidbody.AddForce(force);
    }

    public void ResetPosition(){
        _rigidbody.position = Vector2.zero;
        _rigidbody.velocity = Vector2.zero;
    }

    public void toggleRoundStart(){
        roundStarted = !roundStarted;
    }
}
