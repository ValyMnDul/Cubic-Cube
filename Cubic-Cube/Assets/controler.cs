using UnityEngine;
using UnityEngine.SceneManagement;
public class controler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }






    /////////////////////MAIN//////////////////////////////

    public void Press_Start()
    {
        SceneManager.LoadScene("Level_Selector");
    }

    public void Press_Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void Press_Quit()
    {
        Application.Quit();
    }

    /////////////////////LEVEL_SELECTOR//////////////////////////////
    

    public void Press_Back_Button()
    {
        SceneManager.LoadScene("menu");
    }

    public void Press_Level_1()
    {
        SceneManager.LoadScene("Level_1");
        Time.timeScale = 1f;
    }
    public void Press_Level_2()
    {
        SceneManager.LoadScene("Level_2");
        Time.timeScale = 1f;
    }
    public void Press_Level_3()
    {
        SceneManager.LoadScene("Level_3");
        Time.timeScale = 1f;
    }
    ////////////////////////////LEVEL/////////////////////////////////

    public GameObject MenuBar;
    public GameObject Menu;
    public void Press_Mini_Menu()
    {
        Menu.SetActive(true);
        MenuBar.SetActive(false);
        Time.timeScale = 0f;
    }

    public void Press_MiniMenu_Home()
    {
        SceneManager.LoadScene("Level_Selector");
        Time.timeScale = 1f;
    }
    public void Press_MiniMenu_Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void Press_Minimap_Continue()
    {
        Menu.SetActive(false);
        MenuBar.SetActive(true);
        Time.timeScale = 1f;
    }

    public void Steam()
    {
        Application.OpenURL("https://steamcommunity.com/id/valymnd/");
    }
    public void Google()
    {
        Application.OpenURL("https://www.google.com/");
    }
}
