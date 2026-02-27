using UnityEngine;

public class PlayerShooting1 : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shootingInterval;
    public Vector3 bulletOffset;
    private float lastBulletTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            updateFiring();
        }
    }

    private void updateFiring()
    {
        if (Time.time - lastBulletTime >= shootingInterval)
        {
            ShootBullet();
            lastBulletTime = Time.time;
        }
    }

    private void ShootBullet()
    {
        Instantiate(bulletPrefab, transform.position + bulletOffset, transform.rotation);
    }
}
