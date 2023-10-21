using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(string Scene_01)
    {
        SceneManager.LoadScene(Scene_01);
    }
}
