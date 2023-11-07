using System.Collections;
using System.Collections.Generic;
using Palmmedia.ReportGenerator.Core.Reporting.Builders;
using UnityEngine;

public class sonarExplosion : MonoBehaviour
{
    public GameObject Sonar;

    public void detonate()
    {
        Instantiate(Sonar, gameObject.transform.position, Sonar.GetComponent<Transform>().rotation);
    }
}
