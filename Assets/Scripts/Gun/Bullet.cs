using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 20f;
    public int damage = 10;

    void Update () {

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision col) {

        Destroy(gameObject);

        if (col.gameObject.tag == "Enemy") {

            Damage(col.transform);
        }
    }

    private void Damage (Transform enemy) {

        EnemyController e = enemy.GetComponent<EnemyController>();

        if (e != null) {

            e.TakeDamage(damage);
        }
    }
}
