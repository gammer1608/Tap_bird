using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomePage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game starts");
    }

    // Update is called once per frame
    void Update()
    {
        
    
    }

    public void GotoGame()
    {
        SceneManager.LoadScene(SceanData.gameview);
    }
}
