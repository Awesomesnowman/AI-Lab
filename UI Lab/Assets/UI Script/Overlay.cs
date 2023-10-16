using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Overlay : MonoBehaviour
{
    public Text score;
    public Text time;
    public GameObject player;
    public int point;
    public float seconds;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Score").GetComponent<Text>();
        time = GameObject.Find("Time").GetComponent<Text>();
        player = GameObject.Find("Capsule");
    }

    // Update is called once per frame
    void Update()
    {
        point = player.GetComponent<PlayerController>().score;
        score.text = ("Score: " + point);

        seconds = Time.timeSinceLevelLoad;
        int second = ((int)seconds % 60);
        int minutes = ((int)seconds / 60);
        time.text = string.Format("{0:00}:{1:00}", minutes, second);
    }
}
