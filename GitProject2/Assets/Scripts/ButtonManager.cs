using UnityEngine;
using UnityEngine.UI;
using System;

public class ButtonManager : MonoBehaviour
{
    public static event Action StartClick;

    private Button startButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        startButton = GetComponent<Button>();
    }

    private void OnEnable()
    {
        startButton.onClick.AddListener(Click);
    }

    private void OnDisable()
    {
        startButton.onClick.RemoveListener(Click);
    }

    private void Click()
    {
        StartClick?.Invoke();

        startButton.gameObject.SetActive(false);
    }
}
