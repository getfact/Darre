using UnityEngine;

public class Gun : MonoBehaviour {

    public GameObject bulletPrefab;
    public Transform firePoint;

    public float fireRate;
    private float nextFire;

    void Update () {

        CheckInput();
    }

    private void CheckInput () {

        if (Input.GetButton("Fire1") && Time.time > nextFire) {

            Shoot();
        }
    }

    private void Shoot () {

        nextFire = Time.time + fireRate;
        GameObject newBullet = (GameObject)Instantiate(bulletPrefab,
                                                       firePoint.position,
                                                       firePoint.rotation);
        Destroy(newBullet, 2);
    }
}
