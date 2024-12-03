using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        SceneTracker.score = player.position.z;
        scoreText.text = ((SceneTracker.score + 1) / 5).ToString("0");
    }
}
