using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{

    //Yang Dibutuhkan
    private bool isDead = false;
    private Rigidbody2D rb;
    public float speed = 6.1f;
    public TextMeshProUGUI champText;
    private void Start()
    {
        //Mengambil Rigid Body
        rb = GetComponent <Rigidbody2D>();
        champText.text = "";
    }


    //Agar Player dapat bergerak sesuai input
    private void Update()
    {
        float YInput = Input.GetAxis("Vertical");
        float XInput = Input.GetAxis("Horizontal");
        Vector2 Movement = new Vector2(XInput, YInput);

        rb.AddForce(Movement * speed);
    }

    //Apabila Tersentuh Enemy maka akan tewas
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            isDead = true;
            Debug.Log("Enemy collided with player!");
            Time.timeScale = 0;
            champText.text = "You Died!";
        }
    }
}
