using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformerController : PhysicsObject
{
    public float maxSpeed = 9;
    public float jumpTakeOffSpeed = 9;
    public Animator animator;
    bool facingRight = true;

    // Start is called before the first frame update
    void Start(){
      if (!facingRight){
        Flipfacing();
      }
    }

    // Update is called once per frame
    // void Update(){
    //   if (Event.current.Equals(Event.KeyboardEvent(KeyCode.LeftArrow.ToString()))){
    //     Flipfacing();
    //   }
    // }

    protected override void ComputeVelocity(){
      Vector2 move = Vector2.zero;
      move.x = Input.GetAxis("Horizontal");
      if ((move.x < 0) && grounded && facingRight){
        Flipfacing();
      }
      if ((move.x > 0) && grounded && !facingRight){
        Flipfacing();
      }
      if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(1) && grounded){
        GetComponent<AudioManager>().PlayJump();
        velocity.y = jumpTakeOffSpeed;
      } else if (Input.GetButtonUp("Jump") || Input.GetMouseButtonDown(1)){
        GetComponent<AudioManager>().PlayJump();
        if (velocity.y > 0){
          velocity.y = velocity.y * 1.7f;
        }
      }
      if (Input.GetKeyDown(KeyCode.M)){
        AudioManager.MuteAllSound();
      }
      targetVelocity = move * maxSpeed;
      animator.SetFloat("Speedx", Mathf.Abs(targetVelocity.x));
      animator.SetBool("Grounded", grounded);
    }

    void Flipfacing(){
      facingRight = !facingRight;
      Vector3 charScale = transform.localScale;
      if (!facingRight){
        charScale.x = -0.8f;
      } else {
        charScale.x = 0.8f;
      }
      transform.localScale = charScale;
    }
}
