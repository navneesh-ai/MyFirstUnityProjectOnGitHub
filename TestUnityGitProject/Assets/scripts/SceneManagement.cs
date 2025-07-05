using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{
    
    public Button button1, button2, button3;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button1.onClick.AddListener(LoadScene1);
        button2.onClick.AddListener(LoadScene2);
        button3.onClick.AddListener(LoadScene3);
    }

    void LoadScene1()
    {
        SceneManager.LoadScene("Scene1");
    }

    void LoadScene2()
    {
        SceneManager.LoadScene("Scene2");
    }

    void LoadScene3()
    {
        SceneManager.LoadScene("Scene3");
    }
    
    
}
