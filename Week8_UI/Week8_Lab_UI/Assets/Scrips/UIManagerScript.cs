using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManagerScript : MonoBehaviour
{
    public void StartGame() 
    {
        SceneManager.LoadScene("Game");
    }

    public void Credits() 
    {
        SceneManager.LoadScene("Credits");
    }
}
