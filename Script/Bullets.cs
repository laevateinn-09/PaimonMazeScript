using UnityEngine;

public class Bullets: MonoBehaviour
{
    public int damage = 10;
    public float destroyDelay = 3f;
    private void Start()
    {
        Destroy(gameObject, destroyDelay);

    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        // Mengecek Collision
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Ground"))
        {
            // Agar Enemy dapat terkena damage
            if (collision.gameObject.CompareTag("Enemy"))
            {
                Enemy enemy = collision.gameObject.GetComponent<Enemy>();

                enemy.Damage(damage);
            }
            Destroy(gameObject);
        }
    }
}