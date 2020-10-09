using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neck : MonoBehaviour
{
    /// <summary>
    /// Tämä koodi seuraa Turrettia. laita tämä Childiksi Gameobjecktin kanssa Turret Logiikille
    /// </summary>



    private Transform target;
    private Vector2 targetPos;
    private Vector2 thisPos;
    private float angle; public float offset;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void LateUpdate()
    {
        targetPos = target.position;
        thisPos = transform.position;
        targetPos.x = targetPos.x - thisPos.x;
        targetPos.y = targetPos.y - thisPos.y;
        angle = Mathf.Atan2(targetPos.y, targetPos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + offset));

    }
}
//Mikael Huhtakangas 