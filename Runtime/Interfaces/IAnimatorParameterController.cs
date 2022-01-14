using UnityEngine;
using UnityPatterns;

/// <summary>
/// Unity animator parameter controller namespace
/// </summary>
namespace UnityAnimatorParameterController
{
    /// <summary>
    /// An interface that represents an animator parameter controller
    /// </summary>
    public interface IAnimatorParameterController : IController
    {
        /// <summary>
        /// Parameter name
        /// </summary>
        string ParameterName { get; set; }

        /// <summary>
        /// Parameter animator
        /// </summary>
        Animator ParameterAnimator { get; set; }

        /// <summary>
        /// Parameter name hash
        /// </summary>
        int ParameterNameHash { get; }

        /// <summary>
        /// Sets a boolean for the animator parameter
        /// </summary>
        /// <param name="value">Value</param>
        void SetBoolean(bool value);

        /// <summary>
        /// Sets an integer for the animator parameter
        /// </summary>
        /// <param name="value">Value</param>
        void SetInteger(int value);

        /// <summary>
        /// Sets a floating point number for the animator parameter
        /// </summary>
        /// <param name="value">Value</param>
        void SetFloat(float value);

        /// <summary>
        /// Sets a trigger for the animator parameter
        /// </summary>
        /// <param name="value">Value</param>
        void SetTrigger();
    }
}
