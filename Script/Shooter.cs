using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float projectileSpeed = 11120.0f;
    public float recoilForce = 10.0f;
    public Rigidbody2D Player;

    void Start()
    {
        // Membuat kotak dari child dari Parent(Player) 
        transform.parent = Player.transform;
    }

    void Update()
    {
        // Mengambil Posisi Mouse
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // Agar senjata bisa menghadap mouse
        Vector2 direction = mousePosition - (Vector2)transform.position;
        float angle = Vector2.SignedAngle(transform.right, direction);
        transform.Rotate(0f, 0f, angle, Space.Self);

        // Untuk Menembak
        if (Input.GetMouseButtonDown(0))
        {
            // Posisi Spawn Projectile
            Vector3 spawnPosition = transform.position + transform.right * 0.5f;

            GameObject projectile = Instantiate(projectilePrefab, spawnPosition, transform.rotation);

            // Agar Peluru dapat maju
            projectile.GetComponent<Rigidbody2D>().AddForce(transform.up * projectileSpeed, ForceMode2D.Impulse);

            // Recoil untuk Player
            GetComponent<Rigidbody2D>().AddForce(-transform.right * recoilForce, ForceMode2D.Impulse);

            Player.AddForce(-transform.right * recoilForce);

            
        }
    }
}


