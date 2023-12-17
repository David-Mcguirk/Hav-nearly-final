using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScenes : MonoBehaviour
{
    // This function is called when the button is clicked
    public void SelectLevel(string sceneDiffculty)
    {
        SceneManager.LoadScene(sceneDiffculty);
    }
}
