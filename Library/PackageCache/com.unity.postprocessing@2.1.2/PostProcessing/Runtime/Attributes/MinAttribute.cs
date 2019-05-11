using System;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace UnityEditor.Rendering.PostProcessing
{
    /// <summary>
    /// Small wrapper on top of <see cref="Editor"/> to ease the access of the underlying component
    /// and its serialized fields.
    /// </summary>
    /// <typeparam name="T">The type of the target component to make an editor for</typeparam>
    /// <example>
    /// <code>
    /// public class MyMonoBehaviour : MonoBehaviour
    /// {
    ///     public float myProperty = 1.0f;
    /// }
    /// 
    /// [CustomEditor(typeof(MyMonoBehaviour))]
    /// public sealed class MyMonoBehaviourEditor : BaseEditor&lt;MyMonoBehaviour&gt;
    