using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class lvlup : MonoBehaviour
{
    public GameObject panel;
    public TMP_Text lvlText;
    public InfoPlayer flag;
    public List<WeaponDataClass> obj;

    public Image firstImg;
    public Image secondImg;

    public TMP_Text firstName;
    public TMP_Text secondName;

    public TMP_Text firstOption;
    public TMP_Text secondOption;

    public GameObject scrp;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        flag = FindObjectOfType<InfoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextLvl(int lvl)
    {
        panel.SetActive(true);
        lvlText.text = "Вы получили " + lvl.ToString() + " уровень!";
        Time.timeScale = 0;
        flag.fl = false;
        GetList();
    }

    public void GetList()
    {
        firstImg.sprite = obj[0].img;
        secondImg.sprite = obj[1].img;
        firstName.text = obj[0].name;
        secondName.text = obj[1].name;
        firstOption.text = obj[0].options;
        secondOption.text = obj[1].options;
    }

    public void GetPrefab(int num)
    {
        Instantiate(obj[num].weaponPrefab, new Vector2(0, 0), Quaternion.identity);
        scrp.GetComponent<invent>().GetImg(num);

    }

    public void OffPause()
    {
        Time.timeScale = 1;
        flag.fl = true;
        panel.SetActive(false);
    }
}
