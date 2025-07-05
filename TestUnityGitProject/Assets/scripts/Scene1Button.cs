using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene1Button : MonoBehaviour
{
    
    public Button button;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button.onClick.AddListener(LoadMasterScene);
    }

    void LoadMasterScene()
    {
        SceneManager.LoadScene("MasterScene");
    }


}
