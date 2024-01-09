using UnityEngine;
using UnityEngine.UI;
namespace Utility.SmoothLayout
{
    [AddComponentMenu("Smooth Layout/Smooth Vertical Layout Group", 151)]
    /// <summary>
    /// Layout child layout elements below each other.
    /// </summary>
    public class SmoothVerticalLayoutGroup : SmoothHorizontalOrVerticalLayoutGroup
    {
        protected SmoothVerticalLayoutGroup()
        { }

        /// <summary>
        /// Called by the layout system. Also see ILayoutElement
        /// </summary>
        public override void CalculateLayoutInputHorizontal()
        {
            base.CalculateLayoutInputHorizontal();
            CalcAlongAxis(0, true);
        }

        /// <summary>
        /// Called by the layout system. Also see ILayoutElement
        /// </summary>
        public override void CalculateLayoutInputVertical()
        {
            CalcAlongAxis(1, true);
        }

        /// <summary>
        /// Called by the layout system. Also see ILayoutElement
        /// </summary>
        public override void SetLayoutHorizontal()
        {
            SetChildrenAlongAxis(0, true);
        }

        /// <summary>
        /// Called by the layout system. Also see ILayoutElement
        /// </summary>
        public override void SetLayoutVertical()
        {
            SetChildrenAlongAxis(1, true);
        }
    }
}
