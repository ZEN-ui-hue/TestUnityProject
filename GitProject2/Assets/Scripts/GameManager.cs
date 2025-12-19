using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] spawners;
    public GameObject[] target;
    public Button startButton;
    private bool isGameActive;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    IEnumerator SpawnTargets()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(2);
            int index1 = Random.Range(0, spawners.Length);
            int index2 = Random.Range(0, target.Length);

            Instantiate(target[index2], spawners[index1].transform.position, target[index2].transform.rotation);
        }
    }

    public void GameStart()
    {
        isGameActive = true;
        StartCoroutine(SpawnTargets());
        startButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
