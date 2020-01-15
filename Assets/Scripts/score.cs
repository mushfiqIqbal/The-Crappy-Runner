using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform Player;
    public Text scoreText;

    void FixedUpdate()
    {
        scoreText.text = Player.position.z.ToString("0");
    }
}
