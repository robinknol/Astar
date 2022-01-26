using System;
using UnityEngine;

namespace RageTest
{
    public class One : MonoBehaviour
    {
        private void Start()
        {
            var two = new Two();
            two.Test = 5;
            Debug.Log(two.Test);
        }
    }

    public class Two
    {
        private int _test;

        public int Test
        {
            get
            {
                return _test;
            }
            set
            {
                _test = value;
            }
        }
    }
}