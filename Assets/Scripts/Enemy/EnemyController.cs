using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour {

    public float maxHealth = 10;
    public int money = 10;

    public Image healthBar;

    private float health;
    private bool isDead = false;

    void Awake () {

        health = maxHealth;
    }

    public void TakeDamage (float amount) {

        health -= amount;

        healthBar.fillAmount = health / maxHealth;

        if (health <= 0 && !isDead) {

            Die();
        }
    }

    private void Die () {

        isDead = true;
        Destroy(gameObject);
    }
}
