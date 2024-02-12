using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emery : MonoBehaviour
{
    public float moveSpees;
    Rigidbody2D rb;
    GameController m_gc;
    public AudioClip hit;
    AudioSource aus;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        m_gc=FindObjectOfType<GameController>();
        aus =FindObjectOfType<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity=Vector2.down*moveSpees;   
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("zone")){
            m_gc.SetGameoverState(true);
            
            Debug.Log("no");
        }
    }
}
