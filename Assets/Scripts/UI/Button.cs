using UnityEngine;
using UnityEngine.EventSystems;

abstract class Button : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        OnClick();
    }

    protected abstract void OnClick();
}
