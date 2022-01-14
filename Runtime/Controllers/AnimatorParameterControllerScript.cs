using System;
using UnityEngine;
using UnityPatterns.Controllers;

/// <summary>
/// Unity animator parameter controller controllers namespace
/// </summary>
namespace UnityAnimatorParameterController.Controllers
{
    /// <summary>
    /// A class that describes an animator parameter controller script
    /// </summary>
    public class AnimatorParameterControllerScript : AControllerScript, IAnimatorParameterController
    {
        /// <summary>
        /// Parameter name
        /// </summary>
        [SerializeField]
        private string parameterName = string.Empty;

        /// <summary>
        /// Parameter animator
        /// </summary>
        [SerializeField]
        private Animator parameterAnimator = default;

        /// <summary>
        /// Parameter name hash
        /// </summary>
        private int parameterNameHash = Animator.StringToHash(string.Empty);

        /// <summary>
        /// Last parameter name
        /// </summary>
        private string lastParameterName = string.Empty;

        /// <summary>
        /// Parameter name
        /// </summary>
        public string ParameterName
        {
            get => parameterName ?? string.Empty;
            set => parameterName = value ?? throw new ArgumentNullException();
        }

        /// <summary>
        /// Parameter animator
        /// </summary>
        public Animator ParameterAnimator
        {
            get => parameterAnimator;
            set => parameterAnimator = value;
        }

        /// <summary>
        /// Parameter name hash
        /// </summary>
        public int ParameterNameHash
        {
            get
            {
                string parameter_name = ParameterName;
                if (lastParameterName != parameter_name)
                {
                    parameterNameHash = Animator.StringToHash(parameter_name);
                    lastParameterName = parameter_name;
                }
                return parameterNameHash;
            }
        }

        /// <summary>
        /// Sets a boolean for the animator parameter
        /// </summary>
        /// <param name="value">Value</param>
        public void SetBoolean(bool value)
        {
            if (parameterAnimator)
            {
                parameterAnimator.SetBool(ParameterNameHash, value);
            }
        }

        /// <summary>
        /// Sets an integer for the animator parameter
        /// </summary>
        /// <param name="value">Value</param>
        public void SetInteger(int value)
        {
            if (parameterAnimator)
            {
                parameterAnimator.SetInteger(ParameterNameHash, value);
            }
        }

        /// <summary>
        /// Sets a floating point number for the animator parameter
        /// </summary>
        /// <param name="value">Value</param>
        public void SetFloat(float value)
        {
            if (parameterAnimator)
            {
                parameterAnimator.SetFloat(ParameterNameHash, value);
            }
        }

        /// <summary>
        /// Sets a trigger for the animator parameter
        /// </summary>
        /// <param name="value">Value</param>
        public void SetTrigger()
        {
            if (parameterAnimator)
            {
                parameterAnimator.SetTrigger(ParameterNameHash);
            }
        }
    }
}
