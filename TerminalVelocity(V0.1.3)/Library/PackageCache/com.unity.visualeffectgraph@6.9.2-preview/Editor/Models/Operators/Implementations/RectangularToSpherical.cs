using System;
using System.Linq;
using UnityEngine;

namespace UnityEditor.VFX.Operator
{
    [VFXInfo(category = "Math/Coordinates")]
    class RectangularToSpherical : VFXOperator
    {
        public class InputProperties
        {
            [Tooltip("The 3D coordinate to be converted into Spherical space.")]
            public Vector3 coordinate = Vector3.zero;
        }
        public class OutputProperties
        {
            [Angle, Tooltip("The angular coordinate (Polar angle).")]
            public float theta = Mathf.PI / 2;
            [Angle, Tooltip("The pitch coordinate (Azimuth angle).")]
            public float phi = Mathf.PI / 2;
            [Tooltip("The radial coordinate (Radius).")]
            public float distance = 1.0f;
        }
        override public string name { get { return "Rectangular to Spherical"; } }

        protected override sealed VFXExpression[] BuildExpression(VFXExpression[] inputExpression)
        {
            return VFXOperatorUtility.RectangularToSpherical(inputExpression[0]);
        }
    }
}
