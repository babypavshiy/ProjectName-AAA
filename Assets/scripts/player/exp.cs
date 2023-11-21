using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exp : MonoBehaviour
{
    public Image expBar;
    public InfoPlayer player;
    public Text lvl;
    public lvlup add;


    // Start is called before the first frame update
    void Start()
    {
        expBar = GetComponent<Image>();
        player = FindObjectOfType<InfoPlayer>();
        add = FindObjectOfType<lvlup>();
    }


    void Update()
    {
        expBar.fillAmount = player.curExp / player.maxExp;
    }

    public void newLvl(int level)
    {
        lvl.text = level.ToString();
        add.nextLvl(level);
    }
}
