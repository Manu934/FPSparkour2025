using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mercancia : MonoBehaviour
{
    public float cost;
    public MoneyManager moneyManager;

    void Start()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
    }

    public void onInteract()
    {
        moneyManager.UpdateMoney(-cost);
        Destroy(gameObject);
    }
}
