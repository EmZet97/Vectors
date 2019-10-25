using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class Vector3D : IVector
    {
        float x, y, z;
        public Vector3D(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public static float ScalarProduct(Vector3D vector1, Vector3D vector2)
        {
            float sp = vector1.GetX() * vector2.GetX() + vector1.GetY() * vector2.GetY() + vector1.GetZ() * vector2.GetZ();
            return sp;
        }
        VectorType IVector.GetType()
        {
            return VectorType.Vector3D;
        }

        float IVector.ScalarProduct(IVector vector1, IVector vector2)
        {
            return ScalarProduct((Vector3D)vector1, (Vector3D)vector2);
        }

        public static Vector3D VectorProduct(Vector3D vector1, Vector3D vector2)
        {
            float x1 = vector1.GetX(), y1 = vector1.GetY(), z1 = vector1.GetZ();
            float x2 = vector2.GetX(), y2 = vector2.GetY(), z2 = vector2.GetZ();
            Vector3D newVec = new Vector3D(y1 * z2 - z1 * y2, z1 * x2 - x1 * z2, x1 * y2 - y1 * x2);
            return newVec;
        }
        public float GetX() => x;
        public float GetY() => y;
        public float GetZ() => z;

        public float GetLength()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }
    }
}
