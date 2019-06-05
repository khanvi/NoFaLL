using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class knight : MonoBehaviour
{
    public Text TextPoint;
    Rigidbody2D rb;
    Animator anim;
    int life = 10;
    int point = 0;
    public Transform l1, l2, l3, l4, l5;
    public AudioSource AudioS;
    public AudioSource AudioE;
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
        }
        if (Input.GetAxis("Horizontal") == 0)
        {
            anim.SetInteger("lol", 1);
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            anim.SetInteger("lol", 2);
        }
        else
        {
            anim.SetInteger("lol", 2);
            transform.localRotation = Quaternion.Euler(0,180,0);
        }


        if (point == 100)
        {
            SceneManager.LoadScene(0);
        }
        if (life == 0)
        {
            PlayerPrefs.SetInt("savescore", point);
            PlayerPrefs.Save();
            SceneManager.LoadScene(2);
        }
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * 10f, rb.velocity.y);
    }
    void OnCollisionEnter2D(Collision2D shit)
    {
        if (shit.gameObject.tag == "enemy")
        {
            //Invoke("ReloadFuckingLevel", 2);
            PlayerPrefs.SetInt("savescore", point);
            PlayerPrefs.Save();
            AudioE.Play();
            SceneManager.LoadScene(2);
        }
    }
    void OnTriggerEnter2D(Collider2D shit)
    {
        if (shit.gameObject.tag == "life")
        {
            point++;
            AudioS.Play();
            TextPoint.text = "score " + point;
            Destroy(shit.gameObject);
        }
        if (shit.gameObject.tag == "kill")
        {
            AudioE.Play();
            life --;
            Destroy(shit.gameObject);
            if (life == 4)
            {
                l2.position = new Vector3(l1.position.x, l1.position.y, l1.position.z);
                l1.position = new Vector3(0, l3.position.y, 0);
            }
            if (life == 3)
            {
                l3.position = new Vector3(l2.position.x, l2.position.y, l2.position.z);
                l2.position = new Vector3(0, l1.position.y, 0);
            }
            if (life == 2)
            {
                l4.position = new Vector3(l3.position.x, l3.position.y, l3.position.z);
                l3.position = new Vector3(0, l1.position.y, 0);
            }
            if (life == 1)
            {
                l5.position = new Vector3(l4.position.x, l4.position.y, l4.position.z);
                l4.position = new Vector3(0, l1.position.y, 0);
            }
        }
    }
    void jump()
    {
        rb.AddForce(transform.up * 3f, ForceMode2D.Impulse);
    }
}
