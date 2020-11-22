using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    public float speed;
    public float maxSpeed;

    public bool movingUp;

    public GameObject upTarget;
    public GameObject bottomTarget;
    public GameObject leftTentacle;
    public GameObject rightTentacle;
    public GameObject flower;
    public GameObject helmet;

    public ParticleSystem flowerParticle_1;
    public ParticleSystem flowerParticle_2;
    public ParticleSystem helmetExplosion;

    public Animator animator;

    HelmetScript helmetScript;
    //public GameObject root;

    public int countToChangeHelmetSprite;
    public int counter;
    
    //Boss Health

    public float bossHealth;
    public float maxBossHealth;
    //public Slider bossHealthBar;

    //public ParticleSystem playerParticalSystem; 

    // Start is called before the first frame update
    void Start()
    {
        movingUp = true;       
        maxBossHealth = bossHealth;
        flowerParticle_1.gameObject.SetActive(false);
        flowerParticle_2.gameObject.SetActive(false);
        helmetExplosion.gameObject.SetActive(false);
        helmetScript = GetComponentInChildren<HelmetScript>();
        animator = GetComponent<Animator>();
        countToChangeHelmetSprite = (int)(bossHealth * 0.14f);
    }

    // Update is called once per frame
    void Update()
    {
        if (movingUp)
        {
            GoUp();
            if (transform.position == upTarget.transform.position)
            {
                movingUp = !movingUp; 
            }
        }
        else
        {
            GoDown();
            if (transform.position == bottomTarget.transform.position)
            {
                movingUp = !movingUp;
            }
        }

        //bossHealthBar.value = bossHealth;

        if (bossHealth <= maxBossHealth * 0.7 && bossHealth > maxBossHealth * 0.3)
        {
            animator.SetTrigger("phase_2");
        }

        if (bossHealth <= maxBossHealth * 0.3f && bossHealth > 0)
        {
            speed = maxSpeed;
        }

        if (bossHealth <= 0)
        {
            //bigExpl.gameObject.SetActive(true);
            animator.SetTrigger("death");
            speed = 0;
            //this.gameObject.SetActive(false);
        } 
        
        if (counter == countToChangeHelmetSprite && bossHealth > maxBossHealth * 0.3)
        {
            helmetScript.ChangeHelmetSprite();
            counter = 0;
        }

        if (bossHealth == maxBossHealth * 0.3)
        {
            
            helmetExplosion.gameObject.SetActive(true);
            helmet.gameObject.SetActive(false);
            animator.SetTrigger("phase_3");

        }


    }
     
    private void GoUp()
    {        
        transform.position = Vector2.MoveTowards(transform.position, upTarget.transform.position, speed * Time.deltaTime);
    }

    private void GoDown()
    {
        transform.position = Vector2.MoveTowards(transform.position, bottomTarget.transform.position, speed * Time.deltaTime);
    }

    /*private void OnParticleCollision(GameObject other)
    {
        
        bossHealth -= 1;
        counter++;
        animator.SetTrigger("hit");

    }

   */


}
