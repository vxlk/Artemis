using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public Slider health;
    public PlayerStats player;

    private int _health;

    void Update()
    {
        _health = player.health;
        health.value = _health;
    }
}
