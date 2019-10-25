using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Vectors
{
    class XMLParser : IParser
    {
        string URL;

        public XMLParser(string url)
        {
            this.URL = url;
        }

        public Repository Parse(out Repository repository)
        {
            repository = new Repository();
            foreach (IVector vec in GetVector())
            {
                repository.AddVector(vec);
            }
            
            return repository;
        }

        private IEnumerable<IVector> GetVector()
        {
            using (XmlReader reader = XmlReader.Create(URL))
            {
                float x = 0.0f, y = 0.0f, z = 0.0f;
                int size = 0;
                int vecType = -1;
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name.ToString())
                        {
                            case "Vector2D":
                                vecType = 0;
                                size = 0;
                                break;
                            case "Vector3D":
                                vecType = 1;
                                size = 0;
                                break;
                            case "x":
                                string sx = reader.ReadString();
                                x = float.Parse(sx, System.Globalization.NumberStyles.AllowDecimalPoint);
                                size++;
                                break;
                            case "y":
                                string sy = reader.ReadString();
                                y = float.Parse(sy, System.Globalization.NumberStyles.AllowDecimalPoint);
                                size++;
                                break;
                            case "z":
                                string sz = reader.ReadString();
                                z = float.Parse(sz, System.Globalization.NumberStyles.AllowDecimalPoint);
                                size++;
                                break;
                        }
                        if (size == 2 && vecType == 0)
                        {
                            size = 0;
                            Vector2D new_vec = new Vector2D(x,y);
                            yield return new_vec;
                        }
                        if (size == 3 && vecType == 1)
                        {
                            size = 0;
                            Vector3D new_vec = new Vector3D(x, y, z);
                            yield return new_vec;
                        }
                    }
                }
            }
        }

    }
}