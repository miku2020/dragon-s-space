using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Map_lerp : MonoBehaviour
{

    /// <summary>
    /// Laita Empty Gameobjektiin joka toimii parenttina kaikelle mitä Kentässä on ja tämä Empty Gameobjektin sisälle.
    /// 
    /// Luo Box Collider Empty Game Objektille joka toimii sitten Kentän loppu pisteenä + kertoo loppu pisteet (ajan perusteella)
    /// </summary>
        


    public float startLerptT;
    [Header("Missä ajassa kuuluu liikkua")]
    public float LerpT;

    [Header("Aloitus Sijainti")]
    public Vector2 startpos;
    [Header("Päättymis sijainti")]
    public Vector2 endpos;

    public bool shouldlerp = false;
    float L_Score;
   // int Score;
     

    private void startLerp()
    {
        startLerptT = Time.time;

        shouldlerp = true;
    }

    void Start()
    {
        
    startLerp();

        //Score = GameObject.FindGameObjectWithTag("Player").GetComponent<Score>();

    }

    void Update() 
    {
        if (shouldlerp) //liikuttaa kenttää ja antaa Score +1 niin kauan kunnes osuu Loppu Triggeriin
        {
            transform.position = Lerp(startpos, endpos, startLerptT, LerpT);

            L_Score++;
        }
        
    }


    public Vector3 Lerp(Vector3 start, Vector3 end, float startLerpT, float LerpT = 1)
    {
        float TsinceStart = Time.time - startLerpT;

        float percentcomplete = TsinceStart / LerpT;

        var result = Vector3.Lerp(start, end, percentcomplete);

        return result;
    }
    private void OnTriggerEnter2D(Collider2D other) //Kun pelaaja törmään triggeriin niin tämä lopettaa liikunnan ja piste laskun
    {
        if (other.tag == "Player")
        {
            shouldlerp = false;
            Debug.Log("Lerp Stop");
            Debug.Log("Lerp Score" + L_Score);
           // Debug.Log("Total Score" + Score);
        }
    }
    }
//Mikael Huhtakangas 