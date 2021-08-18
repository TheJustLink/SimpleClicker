using UnityEngine;

using Animations;

class Box : Button
{
    [SerializeField] private RectTransformAnimation _clickAnimation;

    private RectTransform _rectTransform;

    private void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    protected override void OnClick()
    {
        _clickAnimation.Animate(_rectTransform);
    }
}