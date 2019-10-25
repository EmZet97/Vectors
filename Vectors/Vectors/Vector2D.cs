using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class Vector2D : IVector
    {
        float x, y;
        public Vector2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public static float ScalarProduct(Vector2D vector1, Vector2D vector2)
        {
            float sp = vector1.GetX() * vector2.GetX() + vector1.GetY() * vector2.GetY();
            return sp;
        }

        VectorType IVector.GetType()
        {
            return VectorType.Vector2D;
        }
        public float GetLength()
        {
            return (float)Math.Sqrt(x * x + y * y);
        }

        float IVector.ScalarProduct(IVector vector1, IVector vector2)
        {
            return ScalarProduct((Vector2D)vector1, (Vector2D)vector2);
        }

        public float GetX() => x;
        public float GetY() => y;

    }
}
