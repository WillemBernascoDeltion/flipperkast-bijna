using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Movement: MonoBehaviour { 

    public Text scoreVeld;
    public int score;
    public Vector3 horizontal;

  
    // Update is called once per frame
    void Update() { 
        if (Input.GetButton("Horizontal"))
        {
            transform.position += horizontal;
        }
    }

    void OnCollisionEnter(Collision collision)
{
    score = score + 10;
    scoreVeld.text = score.ToString();
}
    public void ButtonClicked()
    {
        score = score + 15; 
        scoreVeld.text = score.ToString();
    }
}