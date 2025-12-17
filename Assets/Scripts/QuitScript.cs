using Unity.VisualScripting;
using UnityEngine;

public class QuitScript : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Quit Game");
            Application.Quit();
        }
    }

    


}
