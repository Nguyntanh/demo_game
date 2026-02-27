using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int defaultHealthPoint;
    private int helthPoint;
    private void start() => helthPoint = defaultHealthPoint;
    public void TakeDamage(int damage)
    {
        if (helthPoint <= 0) return;

        helthPoint -= damage;
        if (helthPoint <= 0) Die();
    }
    public void OnTriggerEnter2D(Collider2D collision) => Die();

    protected virtual void Die()
    {
        var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(explosion, 1f);
        Destroy(gameObject);
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
