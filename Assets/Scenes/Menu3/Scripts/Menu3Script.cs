using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Menu3Script : MonoBehaviour
{
    public void ButtonMenu1()
    {
        SceneManager.LoadScene("Menu1Scene");
    }

    public void ButtonMenu2()
    {
        SceneManager.LoadScene("Menu2Scene");
    }

    public void TestButtonPressed()
    {
        SceneManager.LoadScene("TestScene");
    }
}
