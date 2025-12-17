using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject target;
    private Button button;
    private bool gameIsActive;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button = GetComponent<Button>();
    }

    IEnumerator SpawnMobs()
    {
        while (gameIsActive)
        {
            yield return new WaitForSeconds(1);
            Instantiate(target, spawnPoints[Random.Range(0, 3)].transform.position, target.transform.rotation);
        }
    }

    public void GameStart()
    {
        gameIsActive = true;

        StartCoroutine(SpawnMobs());
    }

    // Update is called once per frame
    void Update()
    {
    }  
}
