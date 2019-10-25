using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    public enum VectorType
    {
        Vector3D, Vector2D
    }
    interface IVector
    {

        float ScalarProduct(IVector vector1, IVector vector2);
        VectorType GetType();

        float GetLength();

    }
}
