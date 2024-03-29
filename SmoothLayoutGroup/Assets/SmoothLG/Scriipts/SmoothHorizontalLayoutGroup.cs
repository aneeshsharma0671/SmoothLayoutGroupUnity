using UnityEngine;
using UnityEngine.UI;
namespace Utility.SmoothLayout
{
    [AddComponentMenu("Smooth Layout/Smooth Horizontal Layout Group", 150)]
    /// <summary>
    /// Layout class for arranging child elements side by side.
    /// </summary>
    public class HorizontalLayoutGroup : SmoothHorizontalOrVerticalLayoutGroup
    {
        protected HorizontalLayoutGroup()
        { }

        /// <summary>
        /// Called by the layout system. Also see ILayoutElement
        /// </summary>
        public override void CalculateLayoutInputHorizontal()
        {
            base.CalculateLayoutInputHorizontal();
            CalcAlongAxis(0, false);
        }

        /// <summary>
        /// Called by the layout system. Also see ILayoutElement
        /// </summary>
        public override void CalculateLayoutInputVertical()
        {
            CalcAlongAxis(1, false);
        }

        /// <summary>
        /// Called by the layout system. Also see ILayoutElement
        /// </summary>
        public override void SetLayoutHorizontal()
        {
            SetChildrenAlongAxis(0, false);
        }

        /// <summary>
        /// Called by the layout system. Also see ILayoutElement
        /// </summary>
        public override void SetLayoutVertical()
        {
            SetChildrenAlongAxis(1, false);
        }
    }
}
