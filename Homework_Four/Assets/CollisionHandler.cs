using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    new Rigidbody rigidbody;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other) {
        switch(other.gameObject.tag){
            case "Friendly":
            Debug.Log("The collision is friendly");
            break;
            case "Finish":
            Debug.Log("The game is finished");
            break;
            default:
            // Debug.Log("This is default");
            ReloadLevel();
            break;
        }

    }

    private void ReloadLevel(){
        Scene scene = SceneManager.GetActiveScene();
        int currentIndex = scene.buildIndex;
        SceneManager.LoadScene(currentIndex);
    }
}
