using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleStartScreen(GameObject ConnectedState, GameObject DisconnectedState)
    {
        ConnectedState.SetActive(true);
        DisconnectedState.SetActive(false);
    }
}
