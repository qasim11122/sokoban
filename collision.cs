using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer spriteRenderer;
    [SerializeField] Sprite brBox;
    [SerializeField] Sprite blueBox;
    [SerializeField] TextMeshProUGUI scoreText;
    public GameObject winText;
    bool hasboxcolor;
    
    //bool check=true;
    public  static int  Score = 0;
    public int s = 0;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        scoreText.text = ("Score= ")+Score;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ("Score= ") + Score;
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Score = 0;
            s = Score;
            Time.timeScale = 1;

        }
        //if(s==4)
        //{
            -+
        //    winText.SetActive(true);
        //    Debug.Log("You win");
        //    Time.timeScale = 0;
        //}
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BlueDot" && !hasboxcolor)
        {
           
                Score = Score + 1;
                Debug.Log("Score++");
                s = Score;
                Debug.Log(Score);
                
        }
        if (s == 7)
        {
            winText.SetActive(true);
            Debug.Log("You win");
            
        }

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "BlueDot" && !hasboxcolor)
        {
             Debug.Log(" Color changed ");
            hasboxcolor = true;
           // Destroy(collision.gameObject, 0.5f);
            spriteRenderer.sprite = blueBox;
        }
        if (s == 7)
        {
            
            Time.timeScale = 0;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "BlueDot" && hasboxcolor)
        {

            Debug.Log("Color Changed to Brown");
            hasboxcolor = false;
            // Destroy(collision.gameObject, 0.5f);
            spriteRenderer.sprite = brBox;
            Score = Score - 1;
            s = Score;
            Debug.Log("Score--");
            Debug.Log(Score);
        }
   }
    
}
