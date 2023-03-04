using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    public void Hover();
    public void Unhover();
    public void Interact(Player player, bool isRightController);
    public void VisualInteraction(Player player);

    public bool IsInteractable();
}
