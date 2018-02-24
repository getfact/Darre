using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public static int money = 100;

    private int maxHealth;
    private int health;

    void Awake () {

        health = maxHealth;
    }
}
