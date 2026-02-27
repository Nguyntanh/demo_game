using UnityEngine;

public class EnemyHealth1 : Health
{

    protected override void Die()
    {
        base.Die();
        Debug.Log("Enemy đie");
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
