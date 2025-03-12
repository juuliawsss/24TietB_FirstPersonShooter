using UnityEngine;

public class JY_Enemy : MonoBehaviour, IDamageable


{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {}
       public float health = 100.0f;

    public void TakeDamage(float damageAmount) 

    {

        health -= damageAmount;

        Debug.Log("Enemy health is: " + health);

        if (health <= 0)

        {

            Destroy(gameObject);

        }

    }
}



