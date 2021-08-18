using UnityEngine;

using DG.Tweening;

namespace Animations
{
    abstract class RectTransformAnimation : ScriptableObject
    {
        public void Animate(RectTransform rectTransform)
        {
            KillAnimations(rectTransform);
            InternalAnimate(rectTransform);
        }
        public abstract Tween InternalAnimate(RectTransform rectTransform);

        private void KillAnimations(RectTransform rectTransform)
        {
            rectTransform.DOKill(true);
        }
    }
}