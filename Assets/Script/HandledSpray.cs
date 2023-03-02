using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandledSpray : MonoBehaviour
{
    public bool isRight;
    public HandController controller;
    public GameObject colliderPoint;
    public LayerMask m_LayerMask;

    public GameObject hand;

    public ParticleSystem particle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isTriggerPressed(isRight))
        {
            particle.Play();
            Collider[] hitColliders = Physics.OverlapBox(colliderPoint.gameObject.transform.position, new Vector3(0.1f, 0.1f, 0.65f), hand.gameObject.transform.rotation, m_LayerMask);
            if (hitColliders.Length > 0)
            {
                Debug.Log(hitColliders[0]);
            }
        }
        else
        {
            particle.Stop();
        }
    }
    void OnDrawGizmos()
    {
        Matrix4x4 rotationMatrix = transform.localToWorldMatrix;
        //Gizmos.matrix = rotationMatrix;
        Gizmos.DrawWireCube(colliderPoint.gameObject.transform.position, new Vector3(0.1f,0.1f,0.65f));
        //Gizmos.DrawLine(transform.position, colliderPoint.gameObject.transform.position);
    }
}
