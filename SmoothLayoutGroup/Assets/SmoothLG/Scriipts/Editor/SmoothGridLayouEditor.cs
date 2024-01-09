using UnityEditor;

namespace Utility.SmoothLayout
{
    [CustomEditor(typeof(SmoothGridLayoutGroup))]
    public class SmoothGridLayouEditor : UnityEditor.UI.GridLayoutGroupEditor
    {
        private SerializedProperty m_MoveDuration;
        private SerializedProperty m_AnimationType;

        protected override void OnEnable()
        {
            base.OnEnable();

            // or any other private field
            m_AnimationType = serializedObject.FindProperty("AnimationType");
            m_MoveDuration = serializedObject.FindProperty("MoveDuration");
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            EditorGUILayout.PropertyField(m_AnimationType);
            EditorGUILayout.PropertyField(m_MoveDuration);

            serializedObject.ApplyModifiedProperties();
        }
    }
}
