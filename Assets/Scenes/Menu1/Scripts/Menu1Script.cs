using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Menu1Script : MonoBehaviour
{
    public void ButtonMenu2()
    {
        SceneManager.LoadScene("Menu2Scene");
    }

    public void ButtonMenu3()
    {
        SceneManager.LoadScene("Menu3Scene");
    }

    public void GrabberButtonPressed()
    {
        SceneManager.LoadScene("TestScene");
    }
}
