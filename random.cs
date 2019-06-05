using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random : MonoBehaviour
{
    float randX = 0f, randXB = 0f;
    float randY = 0f, randYB = 0f;
    public GameObject Prefab;
    public GameObject PrefabB;
    Rigidbody2D rb;
    float t = 0;
    int l = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        l += (int)t;
        if (l > 60 && t > 1)
        {
            randXB = Random.Range(100, 1400) / 100f;
            randYB = Random.Range(-1300, -1100) / 100f;
            Instantiate(PrefabB, new Vector2(randXB, randYB), transform.rotation);
            randXB = Random.Range(100, 1400) / 100f;
            randYB = Random.Range(-1300, -1100) / 100f;
            Instantiate(PrefabB, new Vector2(randXB, randYB), transform.rotation);
            randXB = Random.Range(100, 1400) / 100f;
            randYB = Random.Range(-1300, -1100) / 100f;
            Instantiate(PrefabB, new Vector2(randXB, randYB), transform.rotation);
            t--;
            randX = Random.Range(10, 140) / 10f;
            randY = Random.Range(-130, -110) / 10f;
            Instantiate(Prefab, new Vector2(randX, randY), transform.rotation);
        }
        else if (l > 20 && t > 1)
        {
            randXB = Random.Range(100, 1400) / 100f;
            randYB = Random.Range(-1300, -1100) / 100f;
            Instantiate(PrefabB, new Vector2(randXB, randYB), transform.rotation);
            randXB = Random.Range(100, 1400) / 100f;
            randYB = Random.Range(-1300, -1100) / 100f;
            Instantiate(PrefabB, new Vector2(randXB, randYB), transform.rotation);
            t--;
            randX = Random.Range(10, 140) / 10f;
            randY = Random.Range(-130, -110) / 10f;
            Instantiate(Prefab, new Vector2(randX, randY), transform.rotation);
        }
        else if (l > 5 && t>1)
        {
            randXB = Random.Range(100, 1400) / 100f;
            randYB = Random.Range(-1300, -1100) / 100f;
            Instantiate(PrefabB, new Vector2(randXB, randYB), transform.rotation);
            t--;
            randX = Random.Range(10, 140) / 10f;
            randY = Random.Range(-130, -110) / 10f;
            Instantiate(Prefab, new Vector2(randX, randY), transform.rotation);
        }
        else if (t>1)
        {
            t--;
            randX = Random.Range(20, 130)/10f;
            randY = Random.Range(-130, -110)/10f;
            Instantiate(Prefab, new Vector2(randX,randY), transform.rotation);
        }
        
    }
}
