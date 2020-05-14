using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill : MonoBehaviour
{
    public GameObject Player;
    public GameObject UItoDisable;
    public GameObject UItoAble;
    public GameObject UItoAble_two;

    // Start is called before the first frame update
    void Awake()
    {
      Player = GameObject.FindGameObjectWithTag("Player");
      UItoDisable = GameObject.Find("HUD");
      UItoAble = GameObject.Find("EndMenu");
      UItoAble_two = GameObject.Find("Menu_Background");
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision){
      if (collision.gameObject.tag == "Player"){
        UItoDisable.GetComponent<CanvasGroup>().alpha = 0;
        UItoAble.GetComponent<CanvasGroup>().alpha = 1;
        UItoAble_two.SetActive(true);
      }
    }
}
