using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject projectile;
    public Transform bulletSpawn;
    private bool isReadyToFire;
    public AudioSource sniperShotSound;

    // Start is called before the first frame update
    void Start()
    {
        isReadyToFire = true;

        sniperShotSound = GetComponent<AudioSource>();

        if (sniperShotSound == null)
        {
            Debug.LogError("No AudioSource Found");
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (isReadyToFire == true && Input.GetButtonDown("Fire1"))
        {
            Fire();
            StartCoroutine(WaitForFire());
        }
    }

    public void Fire()
    {
        GameObject bullet = Instantiate(projectile);

        Physics.IgnoreCollision(bullet.GetComponent<Collider>(),
            bulletSpawn.parent.GetComponent<Collider>());

        bullet.transform.position = bulletSpawn.position;

        Vector3 rotation = bullet.transform.rotation.eulerAngles;

        bullet.transform.rotation = Quaternion.Euler(rotation.x, transform.eulerAngles.y, rotation.z);

        bullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.forward * 100.0f, ForceMode.Impulse);

        sniperShotSound.Play();
    }

    IEnumerator WaitForFire()
    {
        isReadyToFire = false;
        yield return new WaitForSeconds(2);
        isReadyToFire = true;
    }
}
