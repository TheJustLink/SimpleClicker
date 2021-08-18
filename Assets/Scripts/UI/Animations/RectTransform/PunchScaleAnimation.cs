using UnityEngine;
using DG.Tweening;

namespace Animations
{
    [CreateAssetMenu(menuName = "Game/Animations/RectTransform/PunchScale")]
    class PunchScaleAnimation : RectTransformAnimation
    {
        [SerializeField] private float _scale;
        [SerializeField] private float _duration;
        [Space]
        [SerializeField] private int _vibrato = 10;
        [SerializeField] private float _elasticity = 1;

        public override Tween InternalAnimate(RectTransform rectTransform)
        {
            var punch = new Vector2(_scale, _scale);
            return rectTransform.DOPunchScale(punch, _duration, _vibrato, _elasticity);
        }
    }
}