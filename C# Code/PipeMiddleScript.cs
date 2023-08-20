using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    public AudioSource audio;
    public string test;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Test: " + test);
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        Debug.Log("Logic: " + GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("COLLIDE");
        if (collision.gameObject.layer == 3)
        {
            Debug.Log("ADD SCORE CALL");
            Debug.Log(logic);
            logic.addScore();
            audio.Play();
        }
    }
}