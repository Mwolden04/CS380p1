using UnityEngine;
using UnityEngine.SceneManagement; // For scene management
using UnityEngine.UI; // For accessing UI elements

public class buttonpress : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadSceneAsync(1);
    }

}
