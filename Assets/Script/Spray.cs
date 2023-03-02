using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Spray : MonoBehaviour, IInteractable
{
    [FormerlySerializedAs("renderer")]
    public Renderer Renderer;

    float m_Highlighted = 0.0f;
    MaterialPropertyBlock m_Block;
    int m_HighlightActiveID;

    private bool isInteractable = true;

    public HandledSpray LeftHandledSpray;
    public HandledSpray RightHandledSpray;

    public Animator LeftAnimator;
    public Animator RightAnimator;

    public XRController Lcontroller;
    public XRController Rcontroller;

    public void Hover()
    {
        m_Highlighted = 1.0f;

        Renderer.GetPropertyBlock(m_Block);
        m_Block.SetFloat(m_HighlightActiveID, m_Highlighted);
        Renderer.SetPropertyBlock(m_Block);
    }

    public void Interact(Player player, bool isRightController)
    {
        isInteractable = false;
        if (isRightController)
        {
            RightHandledSpray.gameObject.SetActive(true);
            RightAnimator.SetBool("Selected", true);
        }
        else
        {
            LeftHandledSpray.gameObject.SetActive(true);
            LeftAnimator.SetBool("Selected", true);
        }
        gameObject.SetActive(false);
    }

    public void Unhover()
    {
        m_Highlighted = 0.0f;

        Renderer.GetPropertyBlock(m_Block);
        m_Block.SetFloat(m_HighlightActiveID, m_Highlighted);
        Renderer.SetPropertyBlock(m_Block);
    }

    public void VisualInteraction(Player player)
    {
        //throw new System.NotImplementedException();
    }

    bool IInteractable.IsInteractable()
    {
        return isInteractable;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (Renderer == null)
        {
            Renderer = GetComponent<Renderer>();
        }

        m_HighlightActiveID = Shader.PropertyToID("HighlightActive");
        m_Block = new MaterialPropertyBlock();
        m_Block.SetFloat(m_HighlightActiveID, m_Highlighted);
        Renderer.SetPropertyBlock(m_Block);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
