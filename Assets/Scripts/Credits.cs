using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void Quit()
    {
        FindObjectOfType<AudioManager>().Play("ButtonPress");
        Application.Quit();
    }

    public void PlayAgain()
    {
        FindObjectOfType<AudioManager>().Play("ButtonPress");
        SceneManager.LoadScene("Level01");
    }
}
