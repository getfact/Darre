using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed = 400;
    public int maxHealth = 10;

    public int money = 0;
    public int health;

    private Rigidbody myRigidbody;
    private Vector3 moveInput;
    private Vector3 moveVelocity;

    void Awake () {

        myRigidbody = GetComponent<Rigidbody>();
        health = maxHealth;
    }

    void Update () {

        CheckInput();
        Move();

        if (health <= 0)
            Die();
    }

    private void CheckInput () {

        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");

        moveInput = new Vector3(horizontal, 0, vertical).normalized;
        moveVelocity = moveInput * moveSpeed;
    }

    private void Move () {

        myRigidbody.velocity = moveVelocity * Time.deltaTime;
    }

    private void TakeDamage (int amount) {

        health -= amount;
    }

    private void Die () {

        Debug.Log("Dead yo");
    }
}
