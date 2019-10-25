using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class Repository
    {
        private List<IVector> vectors;

        public Repository()
        {
            vectors = new List<IVector>();
        }

        public List<IVector> GetVectors()
        {
            return vectors;
        }

        public IVector GetVector(int index)
        {
            return vectors[index];
        }

        public void AddVector(IVector vector)
        {
            vectors.Add(vector);
        }
        public void RemoveVector(IVector vector)
        {
            vectors.Remove(vector);
        }
    }
}
