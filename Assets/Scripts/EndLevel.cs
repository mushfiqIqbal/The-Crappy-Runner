using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public GameManager gameManager;


    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();

    }
}
