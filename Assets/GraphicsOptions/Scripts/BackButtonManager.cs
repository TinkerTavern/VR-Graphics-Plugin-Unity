using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BackButtonManager : MonoBehaviour
{
        void Update()
    {
        if (Input.GetKeyDown("return"))
        {
            SceneManager.LoadScene (sceneName:"GraphicsOptions");
        }
    }
}
