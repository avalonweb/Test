using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu2Script : MonoBehaviour
{
    public void ButtonMenu1()
    {
        SceneManager.LoadScene("Menu1Scene");
    }



    public void ButtonMenu3()
    {
        SceneManager.LoadScene("Menu3Scene");
    }

    public void TestButtonPressed()
    {
        SceneManager.LoadScene("TestScene");
    }

}
