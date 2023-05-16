using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button Start1;
    public Button Exit;

    void Start()
    {
        Start1.onClick.AddListener(toGame);
        Exit.onClick.AddListener(toExit);
    }

    void toGame()
    {
        SceneManager.LoadScene("1");
    }

    void toExit()
    {
        Application.Quit();

    }    
}
