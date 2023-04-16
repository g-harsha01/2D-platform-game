using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{   
    public int scorecard ;
    public Text ScoreText;
    public GameObject gameOver;
    public GameObject play;
    public GameObject spawner;
    public playermovement movement;
    public GameObject playagain;
    public void Endgame(){
        gameOver.SetActive(true);
        //movement.enabled = false;
        //Debug.Log("GAME OVER");
        Time.timeScale = 0f;
        play.SetActive(true);
        //playagain.SetActive(true);
        //spawner.SetActive(false);
        
    }
    
    public void IncreaseScore(){
        scorecard++;
        ScoreText.text=scorecard.ToString();
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void PlayAgain(){
        Invoke("Restart",1f);
    }
    

    public void Play(){
        scorecard = 0;
        ScoreText.text=scorecard.ToString();
        play.SetActive(false);
        spawner.SetActive(true);
        //movement.enabled = true;
        gameOver.SetActive(false);
        Time.timeScale = 1f;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        spikemovement[] spikes = FindObjectsOfType<spikemovement>();

        for (int i = 0; i<spikes.Length;i++){
            Destroy(spikes[i].gameObject);
        }
    }
}
