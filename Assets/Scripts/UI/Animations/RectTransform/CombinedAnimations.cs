using System.Collections.Generic;

using UnityEngine;

using DG.Tweening;

namespace Animations
{
    [CreateAssetMenu(menuName = "Game/Animations/RectTransform/Combined")]
    class CombinedAnimations : RectTransformAnimation
    {
        [SerializeField] private List<RectTransformAnimation> _animations;

        public override Tween InternalAnimate(RectTransform rectTransform)
        {
            var sequence = DOTween.Sequence(rectTransform);

            foreach (var animation in _animations)
                sequence.Append(animation.InternalAnimate(rectTransform));

            return sequence.Play();
        }
    }
}