using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Utility.SmoothLayout
{
    [CustomEditor(typeof(SmoothLayoutElement))]
    public class SmoothLayoutElementEditor : UnityEditor.UI.LayoutElementEditor
    {
        private SerializedProperty m_AnimationType;
        private SerializedProperty m_AnimTime;

        protected override void OnEnable()
        {
            base.OnEnable();

            // or any other private field
            m_AnimationType = serializedObject.FindProperty("AnimationType");
            m_AnimationType = serializedObject.FindProperty("AnimationTime");
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            EditorGUILayout.PropertyField(m_AnimationType);
            EditorGUILayout.PropertyField(m_AnimTime);

            serializedObject.ApplyModifiedProperties();
        }
    }
}
