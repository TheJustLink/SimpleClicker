using UnityEngine;

using DG.Tweening;

namespace Animations
{
    [CreateAssetMenu(menuName = "Game/Animations/RectTransform/AnchorPosY")]
    class AnchorPosYAnimation : RectTransformAnimation
    {
        [SerializeField] private float _endPosition;
        [SerializeField] private float _duration;

        public override Tween InternalAnimate(RectTransform rectTransform)
        {
            return rectTransform.DOAnchorPosY(_endPosition, _duration);
        }
    }
}