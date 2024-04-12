using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_ : MonoBehaviour
{
    private Text scoretext;
    public static int scorecount;

    // Start is called before the first frame update
    void Start()
    {
        scoretext = GetComponent<Text>();
        scorecount = 0;

    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = "Score:" + scorecount;
    }
}
