using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
public list<GameObject>enemisInScreen
public void DestroyEnmiesInScreen()
{
    public bool isGrounded;
    public Animator anim; 

    GameManager gameManager;

    void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        anim = GetComponentInParent<Animator>();
        
    }
    void Update()
    {
        if(Imput.GetKeyDown(keyCode.R))
        {
            Destroy EnemiesInScreen();
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if(collider.gameobject.tag == "Goombas")
        {
            playerScript.setBol.rBody.Addforce(vector2.up * Script.JumpForce, ForceMode2D.Impulse);
            anime.setBol("isJumping", true); 
            // Destroy( collider.gameObject);
            Enemy Gomba = collider.goombaObject.Getcomponent<Enemy>();
            goomba.GoombaDath(); 
        }
        isGrounded = true; 
        anim.setBool("IsJumping", false)
       

        
        if(other.gameObject.layer == 3)
        {
            isGrounded = true;
        }
        else if(other.gameObject.layer == 6)
        {
            Debug.Log("Goomba muerto");
            
            Enemy goomba = other.gameObject.GetComponent<Enemy>();
            goomba.Die();

        }


        if(other.gameObject.tag == "DeadZone")
        {
            Debug.Log("Estoy muerto");

            gameManager.GameOver();
        }  
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.layer == 3)
        {
            isGrounded = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.layer == 3)
        {
            isGrounded = false;
        }
    }
}
