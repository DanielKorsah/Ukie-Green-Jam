 using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuScene : MonoBehaviour {

 void Update() 
{

    if(Input.anyKey)
    {
        SceneManager.LoadScene("Menu");
    }

    for (int i = 0;i < 20; i++) {
             if(Input.GetKeyDown("joystick 1 button "+i)){
                 SceneManager.LoadScene("Alfie");
             }
         }

}
}
