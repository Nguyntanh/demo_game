using UnityEngine;

public class PlayerHealth : Health
{
    protected override void Die()
    {
        base.Die();
        Debug.Log("Player đie");
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
