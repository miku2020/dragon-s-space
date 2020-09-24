using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouteFollow : MonoBehaviour
{

    [SerializeField]
    private Transform[] routes;

    private int routeToGo;

    private float tparam;
    private Vector2 EnemyPos;
    public float speedModifier;
    private bool coroutineAllowed;


    // Start is called before the first frame update
    void Start()
    {
        routeToGo = 0;
        tparam = 0f;
        coroutineAllowed = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (coroutineAllowed)
        {
            StartCoroutine(GoByTheRoute(routeToGo));
        }
    }

    private IEnumerator GoByTheRoute(int routeNumber)
    {
        coroutineAllowed = false;

        Vector2 p0 = routes[routeNumber].GetChild(0).position;
        Vector2 p1 = routes[routeNumber].GetChild(1).position;
        Vector2 p2 = routes[routeNumber].GetChild(2).position;
        Vector2 p3 = routes[routeNumber].GetChild(3).position;

        while (tparam < 1)
        {
            tparam += Time.deltaTime * speedModifier;

            EnemyPos = Mathf.Pow(1 - tparam, 3) * p0 +
                3 * Mathf.Pow(1 - tparam, 2) * tparam * p1 +
                3 * (1 - tparam) * Mathf.Pow(tparam, 2) * p2 +
                Mathf.Pow(tparam, 3) * p3;

            transform.position = EnemyPos;
            yield return new WaitForFixedUpdate();
        }

        tparam = 0f;

        routeToGo+=1;

        if (routeToGo > routes.Length - 1)
        {
            routeToGo = 0;
        }

        coroutineAllowed = true;

    }

}
//Mikael Huhtakangas 