using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestOpen : MonoBehaviour
{
  public Animator animator;
  Text code;

  void Awake(){
    code = GameObject.Find("CodeText").GetComponent<Text>();
    // code.text = "";
  }

  private void OnTriggerEnter2D(Collider2D collision){
    if (collision.gameObject.tag == "Player"){
      animator.SetBool("Open", true);
      code.text = "This is the code";
    }
  }

}
