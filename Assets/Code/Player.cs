using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public float moveSpeed;
    public Transform shootingPoint;
    public GameObject projectile;
    GameController m_gc;
    public AudioClip shooting;
    public AudioSource aus;
    // Start is called before the first frame update
    void Start()
    {
        m_gc=FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        // cho player di chuyen bang Horizontal
        float ht = Input.GetAxisRaw("Horizontal");

        //cho player di chuyen
        transform.position += Vector3.right*moveSpeed*ht*Time.deltaTime;
        //goi chu nang ban sung
        if(Input.GetKeyDown(KeyCode.Space)){
            Shoot();
        }
    }
    //chu nang ban sung
    public void Shoot(){
        if(projectile &&shootingPoint)
        {
            if(aus&& shooting)
            {
                aus.PlayOneShot(shooting);
            }
        }
        if(projectile && shootingPoint){
            Instantiate(projectile,shootingPoint.position,Quaternion.identity);
        }
    }
    //enery cham vao player thi player chet
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("emery")){
            m_gc.SetGameoverState(true);
            Destroy(gameObject);
            Debug.Log("game over");
        }
        
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("emery")){
            m_gc.SetGameoverState(true);
            Destroy(gameObject);
            Debug.Log("game over");
        }
    }
}
