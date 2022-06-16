using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Ekilem.Inputs
{
    public class DefaultInput
    {
        private DefaultAction _input;
        public float MoveForward { get; private set; }

        public DefaultInput()
        {
            _input = new DefaultAction();

            _input.Player.MoveForward.performed += context => MoveForward = context.ReadValue<float>();
            _input.Enable();
        }

    }
}

