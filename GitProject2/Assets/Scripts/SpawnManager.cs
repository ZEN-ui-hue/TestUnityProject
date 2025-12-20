using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    public Button restartButton;
    public TextMeshProUGUI gameOverText;
    public GameObject[] spawners;
    public GameObject[] target;
    private bool isGameActive;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    private void OnEnable()
    {
        ButtonManager.StartClick += GameStart;
    }

    private void OnDisable()
    {
        ButtonManager.StartClick -= GameStart;
    }

    IEnumerator SpawnTargets()
    {
        while (isGameActive)
        {
            int index1 = UnityEngine.Random.Range(0, spawners.Length);
            int index2 = UnityEngine.Random.Range(0, target.Length);

            Instantiate(target[index2], spawners[index1].transform.position, target[index2].transform.rotation);
            yield return new WaitForSeconds(2);
        }
    }
    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }

    public void GameRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameStart()
    {
        isGameActive = true;
        StartCoroutine(SpawnTargets());
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
