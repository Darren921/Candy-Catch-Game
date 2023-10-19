using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Candy : MonoBehaviour
{
    Collectables candy1;
    Collectables candy2;
    Collectables candy3;
    Collectables candy4;
    Collectables candy5;
    Collectables candy6;


    private void Awake()
    {
        candy1 = new Collectables("Candy (1)", 1);
       


    }
    [SerializeField] private Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        
        _rb.velocity = new Vector2(0, (float) -1.25);
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        
        if (collision.gameObject.name == "Monster")
        {
          Destroy(gameObject);
            candy1.UpdateScore();

        }
        //but continues y the axis 
        if (collision.gameObject.name == "Ground")
        {
            Destroy(gameObject);


        }
    }
}
