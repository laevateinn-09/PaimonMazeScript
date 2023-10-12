using UnityEngine;
using TMPro;
class Asteroid : MonoBehaviour
{
    //Untuk Text
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI champText;
    int score = 0;

    //OBJ
    private void Start()
    {
        scoreText.text = "Collect At Least 10 Asteroid to Finish the Level!";
        champText.text = "";
    }

    //Pickups WIN condition
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pickups"))
        {
            Destroy(collision.gameObject);
            score++;
            scoreText.text = "Score: " + score;
            if (score >= 10) {
                champText.text = "Gratz!";
            }
        }
    }
}
