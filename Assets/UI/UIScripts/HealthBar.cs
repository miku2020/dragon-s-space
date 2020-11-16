using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public RectTransform meterBarTransform;
    Vector3 minPos;
    Vector3 maxPos;
    public float maxHealth;
    public float minX;//Meterbarin paikkaa joutuu valitettavasti manuaalisesti säätelemään
    public GameObject player;
    public GameObject healthBar;//Canvaksen pois ja päälle kytkemiseen

    private void Start()
    {
        //Debug.Log("Bar position " + meterBarTransform.anchoredPosition.x);
        maxHealth = player.GetComponent<HP_Logic>().Health;
        maxPos = meterBarTransform.anchoredPosition;   //Paikka maksimiterveydellä
        minPos = new Vector3(minX, maxPos.y, maxPos.z);//Paikka nollaterveydellä
        healthBar.SetActive(true);
        SetToMaxPosition();
    }

    private void Update()
    {
        if (player.GetComponent<HP_Logic>().Health <= 0f)
        {
            SetToMinPosition();        //Ei karata nollasijaintia kauemmas
            healthBar.SetActive(false);//Estää healthbarin näkymisen Game Over -ikkunasa
        }
        else if (player.GetComponent<HP_Logic>().Health >= maxHealth)
        {
            SetToMaxPosition(); //Ei karata maksimisijaintia kauemmas
        }
        else
        {
            UpdateBar(player.GetComponent<HP_Logic>().Health, maxHealth);
        }
    }

    public void SetToMaxPosition()
    {
        meterBarTransform.anchoredPosition = maxPos;
    }

    public void SetToMinPosition()
    {
        meterBarTransform.anchoredPosition = minPos;
    }

    public void UpdateBar(float health, float maxHealth)
    {
        float sliderMultiplier = health / maxHealth;
        float amountToMove = sliderMultiplier * (maxPos.x - minPos.x);
        meterBarTransform.anchoredPosition = new Vector3(minPos.x + amountToMove, minPos.y, minPos.z);
    }
}
