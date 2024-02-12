using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Projectlie : MonoBehaviour
{
    public float speed;
    public float timeToDestroy;
    Rigidbody2D m_rb;
    GameController m_gc;
    public AudioClip hit;
    AudioSource aus;
    // Start is called before the first frame update
    void Start()
    {
        m_rb=GetComponent<Rigidbody2D>();
        m_gc=FindObjectOfType<GameController>();
        aus =FindObjectOfType<AudioSource>();
        Destroy(gameObject,timeToDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        //vetor2.up=0,1
        m_rb.velocity = Vector2.up*speed;
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("emery")){
            m_gc.ScorrIncrement();
            if(aus &&hit){
                aus.PlayOneShot(hit);
            }
            Destroy(gameObject);
            Destroy(col.gameObject);
            Debug.Log("ok");
        }
    }
}
