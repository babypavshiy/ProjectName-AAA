using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossWave : MonoBehaviour
{
    public GameObject[] bossList;
    public float distance = 3;
    private int counter = 0;
    private bool fl = false;
    public GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (fl && GameObject.FindWithTag("Boss") == null)
        {
            foreach (Transform child in spawner.transform) Destroy(child.gameObject);
            spawner.SetActive(true);
            fl = false;
        }
    }

    public void CreatePrefab()
    {
        if (GameObject.FindWithTag("Boss") == null)
        {
            GameObject prefab = bossList[counter];
            Instantiate(prefab, Random.insideUnitCircle * distance, Quaternion.identity, transform);
            counter++;
            fl = true;
        }
    }
}
