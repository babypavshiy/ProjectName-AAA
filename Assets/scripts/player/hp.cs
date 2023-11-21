using UnityEngine;
using UnityEngine.UI;

public class hp : MonoBehaviour
{
    public Image healthBar;
    public InfoPlayer player;

    void Start()
    {
        healthBar = GetComponent<Image>();
        player = FindObjectOfType<InfoPlayer>();
    }


    void Update()
    {
        healthBar.fillAmount = player.hp / player.maxHP;
    }
}