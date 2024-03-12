using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   
    public void OnClickArredamento ()

    {

        SceneManager.LoadScene("MainPlacement");

    }

    public void OnClickReTexturing()

    {

        SceneManager.LoadScene("ReTexturing");

    }

    public void OnClickMainMenu()

    {

        SceneManager.LoadScene("MainMenu");

    }

}
