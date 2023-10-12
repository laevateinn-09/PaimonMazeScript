using UnityEngine;
using UnityEngine.SceneManagement;
class Restart : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }
    // Untuk Reset
    public void ResetME()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
        print("It's WORKING!! IT's WORKING");
    }
}
