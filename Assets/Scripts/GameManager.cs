using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public List<string> items;
    public List<GameObject> itemObjects;
    public List<GameObject> beetPrefabs;
    public List<GameObject> pumpkinPrefabs;
    public Transform depositBoxTransform;

    public int coins = 0;
    public int coinsPerFruit = 5;
    public TMP_Text coinsText;

    void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        
    }

    void Update()
    {
        coinsText.text = coins.ToString();
    }
}
