using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class invent : MonoBehaviour
{
    public Image[] img;
    public bool[] isFull;
    public List<WeaponDataClass> obj;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetImg(int num)
    {
        for (int i = 0; i < isFull.Length; i++)
        {
            if (isFull[i] == false)
            {
                img[i].sprite = obj[num].img;
                isFull[i] = true;
                break;
            }
        }
    }
}
