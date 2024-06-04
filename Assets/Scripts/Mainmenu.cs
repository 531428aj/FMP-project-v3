
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined; 
        Audiomanager.instance.MenuSoundStart();
        
    }

    public void LoadScene(string sceneName) 
    {
        SceneManager.LoadScene(sceneName);
    }

}
