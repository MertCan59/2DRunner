using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    private void OnEnable()
    {
        Collector.OnCoinCollectedUI += UpdateUI;
    }
    private void OnDisable()
    {
        Collector.OnCoinCollectedUI -= UpdateUI;
    }
    private void UpdateUI()
    {
        _text.text = "Score: "+GameManager.instance._score.ToString();
    }
}
