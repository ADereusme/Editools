using System;
using System.Collections.Generic;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace EditoolsUnity
{
    public static class ButtonEdit
    {

        public static void Button(string _buttonTitle, Action _callBack, bool _showCondition = true)
        {
            if (!_showCondition) return;
            bool _action = GUILayout.Button(_buttonTitle);
            if (_action) _callBack?.Invoke();
        }

        public static void Button(string _buttonTitle, Action _callBack, Color _color, bool _showCondition = true)
        {
            if (!_showCondition) return;
            GUI.color = _color;
            bool _action = GUILayout.Button(_buttonTitle);
            if (_action) _callBack?.Invoke();
            GUI.color = Color.white;
        }

        public static void Button<T>(string _buttonTitle, Action<T> _callBack, Color _color, T _arg0, bool _showCondition = true)
        {
            if (!_showCondition) return;
            GUI.color = _color;
            bool _action = GUILayout.Button(_buttonTitle);
            if (_action) _callBack?.Invoke(_arg0);
            GUI.color = Color.white;
        }

        public static void Button<T1, T2>(string _buttonTitle, Action<T1, T2> _callBack, Color _color, T1 _arg0, T2 _arg1, bool _showCondition = true)
        {
            if (!_showCondition) return;
            GUI.color = _color;
            bool _action = GUILayout.Button(_buttonTitle);
            if (_action) _callBack?.Invoke(_arg0, _arg1);
            GUI.color = Color.white;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_buttonTitle">button title</param>
        /// <param name="_callBack">action callback</param>
        /// <param name="_color">color text</param>
        /// <param name="_title">title</param>
        /// <param name="_message"></param>
        /// <param name="_acceptButton"></param>
        /// <param name="_cancelButton"></param>
        /// <param name="_showCondition"></param>
        public static void ButtonConfirmation(string _buttonTitle, Action _callBack, Color _color, string _title, string _message, string _acceptButton, string _cancelButton, bool _showCondition = true)
        {
            if (!_showCondition) return;
            GUI.color = _color;
            bool _action = GUILayout.Button(_buttonTitle);
            if (_action)
            {
                bool _confirm = EditorUtility.DisplayDialog(_title, _message, _acceptButton, _cancelButton);
                if (_confirm) _callBack?.Invoke();
            }
            GUI.color = Color.white;
        }

        public static void ButtonConfirmation<T>(string _buttonTitle, Action<T> _callBack, Color _color, T _arg0, string _title, string _message, string _acceptButton, string _cancelButton, bool _showCondition = true)
        {
            if (!_showCondition) return;
            GUI.color = _color;
            bool _action = GUILayout.Button(_buttonTitle);
            if (_action)
            {
                bool _confirm = EditorUtility.DisplayDialog(_title, _message, _acceptButton, _cancelButton);
                if (_confirm) _callBack?.Invoke(_arg0);
            }
            GUI.color = Color.white;
        }
    }
}
