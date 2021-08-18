using DG.Tweening;

using UnityEngine;

namespace Animations
{
    [CreateAssetMenu(menuName = "Game/Animations/RectTransform/ShakeScale")]
    class ShakeScaleAnimaiton : RectTransformAnimation
    {
        [SerializeField] private float _duration;
        [SerializeField] private float _strenght = 1;
        [Space]
        [SerializeField] private int _vibrato = 10;
        [SerializeField] private float _randomness = 90;
        [SerializeField] private bool _fadeOut = true;

        public override Tween InternalAnimate(RectTransform rectTransform)
        {
            return rectTransform.DOShakeScale(_duration, _strenght, _vibrato, _randomness, _fadeOut);
        }
    }
}