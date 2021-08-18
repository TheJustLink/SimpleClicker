using UnityEngine;

using Animations;

class AnimatedButton : Button
{
    [SerializeField] private RectTransformAnimation _animation;

    private RectTransform _rectTransform;

    private void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    protected override void OnClick()
    {
        _animation.Animate(_rectTransform);
    }
}