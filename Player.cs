using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text TextPoint;
    public Text TextLife;
    Rigidbody2D rb;
    Animator anim;
    int life = 100;
    int point = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump();
            anim.SetInteger("gg", 4);
        }
        else if (transform.position.y < -20) { 
            if (Input.GetAxis("Horizontal") == 0)
            {
                anim.SetInteger("gg", 1);
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                anim.SetInteger("gg", 2);
                //transform.localRotation = Quaternion.Euler(0,0,0); or [Quaternion.Euler(180,0,0);]
            }
            else if (Input.GetAxis("Horizontal") > 0)
            {
                anim.SetInteger("gg", 3);
            }
        }


        if (point == 100)
        {
            //ReloadFuckingLevel();
            SceneManager.LoadScene(2);
        }
        if(life == 0)
        {
            //ReloadFuckingLevel();
            SceneManager.LoadScene(2);
        }
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * 12f, rb.velocity.y);
    }
    void OnCollisionEnter2D(Collision2D shit)
    {
        if(shit.gameObject.tag == "enemy")
        {
            //Invoke("ReloadFuckingLevel", 2);
            //ReloadFuckingLevel();
            SceneManager.LoadScene(2);
        }
    }
    void OnTriggerEnter2D(Collider2D shit)
    {
        if (shit.gameObject.tag == "life")
        {
            point ++;
            TextPoint.text = "Point : " + point;
            Destroy(shit.gameObject);
        }
        if (shit.gameObject.tag == "kill")
        {
            life -= 20;
            TextLife.text = life + " HP";
            Destroy(shit.gameObject);
        }
    }
    void jump()
    {
        rb.AddForce(transform.up * 14f, ForceMode2D.Impulse);
    }
}
