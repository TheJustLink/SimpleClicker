using UnityEngine;

using DG.Tweening;

namespace Animations
{
    [CreateAssetMenu(menuName = "Game/Animations/RectTransform/AnchorSlide")]
    class AnchorSlideYAnimation : RectTransformAnimation
    {
        [SerializeField] private float _shift;
        [SerializeField] private float _duration;

        public override Tween InternalAnimate(RectTransform rectTransform)
        {
            var sequence = DOTween.Sequence();

            sequence.Append(rectTransform.DOAnchorPosY(_shift, _duration));
            sequence.Append(rectTransform.DOAnchorPosY(-_shift, 0));
            sequence.Append(rectTransform.DOAnchorPosY(0, _duration));

            return sequence.Play();
        }
    }
}
