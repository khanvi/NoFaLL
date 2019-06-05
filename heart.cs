using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class heart : MonoBehaviour
{
    private Sprite spr, spr1, spr2, spr3;
    public GameObject img;

    void Start()
    {
        spr = img.GetComponent<Image>().sprite;
        //img.GetComponent<Image>().sprite = Resources.Load<Sprite>("4.png");
    }


}
