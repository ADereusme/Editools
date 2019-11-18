using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEditor;

namespace EditoolsUnity
{
    class HandlesEdit
    {
        public static Color ColorEdit(Color _color) => Handles.color = _color;
        public static Color ResetColor() => Handles.color = Color.white;
        public static void DrawWireCube(Vector3 _center, Vector3 _size) => Handles.DrawWireCube(_center, _size);
        public static void DrawWireArc(Vector3 _center, Vector3 _normal, Vector3 _from, float _angle, float _radius) => Handles.DrawWireArc(_center, _normal, _from, _angle, _radius);
    }
}
