using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public EnemyHealth1 enemyHealth;
    public int damage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var playerHealth = collision.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);
            enemyHealth.TakeDamage(1000);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
