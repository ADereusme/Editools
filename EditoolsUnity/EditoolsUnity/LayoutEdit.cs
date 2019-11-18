using System;
using System.Collections.Generic;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace EditoolsUnity
{
    public static class LayoutEdit
    {
        public static void Space(int _total = 1)
        {
            for (int i = 0; i < _total; i++)
            {
                EditorGUILayout.Space();
            }
        }

        public static void Horizontal(bool _open)
        {
            if (_open) EditorGUILayout.BeginHorizontal();
            else EditorGUILayout.EndHorizontal(); ;
        }

        public static void Vertical(bool _open)
        {
            if (_open) EditorGUILayout.BeginVertical();
            else EditorGUILayout.EndVertical(); ;
        }

        public static void Fold(ref bool _value, string _title, bool _isWide = false) => _value = EditorGUILayout.Foldout(_value, _title, _isWide);
        public static void HelpBox() => EditorGUILayout.HelpBox(string.Empty, MessageType.None);
        public static void HelpBox(string _message) => EditorGUILayout.HelpBox(_message, MessageType.None);
        public static void HelpBoxInfo(string _message) => EditorGUILayout.HelpBox(_message, MessageType.Info);
        public static void HelpBoxWarning(string _message) => EditorGUILayout.HelpBox(_message, MessageType.Warning);
        public static void HelpBoxError(string _message) => EditorGUILayout.HelpBox(_message, MessageType.Error);

        public static Enum EnumPopup(string _title, Enum _enum) => EditorGUILayout.EnumPopup(_title, _enum);
        public static Vector3 Vector3Field(string _title, Vector3 _value) => EditorGUILayout.Vector3Field(_title, _value);
        public static UnityEngine.Object ObjectField(UnityEngine.Object _object, Type _type, bool _open) => EditorGUILayout.ObjectField(_object, _type, _open);
        public static int IntSlider(string _title, int _value, int _minValue, int _maxValue) => EditorGUILayout.IntSlider(_title, _value, _minValue, _maxValue);
        public static float Slider(string _title, int _value, int _minValue, int _maxValue) => EditorGUILayout.Slider(_title, _value, _minValue, _maxValue);
    }


    public class EditorCustom<T> : Editor where T : MonoBehaviour
    {
        protected T eTarget = default(T);

        protected virtual void OnEnable()
        {
            eTarget = (T)target;
            eTarget.name = $"[{typeof(T).Name}]";
        }
    }
}

