using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locater : MonoBehaviour
{
    public static Locater Instance { get; private set; }
    public W4Pigeon Pigeon { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }

        Instance = this;

        GameObject pigeon = GameObject.FindWithTag("Player");
        Pigeon = pigeon.GetComponent<W4Pigeon>();

    }
}
