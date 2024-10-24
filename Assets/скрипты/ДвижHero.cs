using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ДвижHero : MonoBehaviour
{
    [SerializeField ] private float speed= 700f;
    [SerializeField] private int lives = 5;//не надо, но пускай будет
    [SerializeField ] private float jumpForce = 15f;

    private Rigidbody2D rb;
    private SpriteRenderer sprite;

    private void Awake()
    {
        rb=GetComponent<Rigidbody2D>();
        sprite=GetComponentInChildren<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetButton("Horizontal"))
            Run();
    }
    private void Run()
    { Vector3 dir = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
    }

    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    
}
