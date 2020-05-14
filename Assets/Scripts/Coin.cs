using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    private CoinCounter coinCounter;
    Text label_score;

    // Start is called before the first frame update
    void Awake()
    {
        coinCounter = GameObject.Find("CoinCounter").GetComponent<CoinCounter>();
        label_score = GameObject.Find("coinText").GetComponent<Text>();
        label_score.text = "Score: " + coinCounter.count;
    }

    private void OnTriggerEnter2D(Collider2D collision){
      Debug.Log(coinCounter.count);
      if (collision.gameObject.tag == "Player"){
        GetComponent<AudioManager>().PlayCoin();
        coinCounter.count += 1;
        label_score.text = "Score: " + coinCounter.count;
        gameObject.SetActive(false);
      }
    }
}
