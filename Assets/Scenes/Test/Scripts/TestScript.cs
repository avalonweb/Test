using UnityEngine;
using UnityEngine.InputSystem;


public class TestScript : MonoBehaviour
{
    public void OnButtonA()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu1Scene");
    }

    public void OnButtonB()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu2Scene");
    }

    public void OnButtonX()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu3Scene");
    }

}
