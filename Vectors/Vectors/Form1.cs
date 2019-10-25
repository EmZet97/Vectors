using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectors
{
    public partial class Form1 : Form
    {
        private List<Vector3D> vector3Ds = new List<Vector3D>();
        private List<Vector2D> vector2Ds = new List<Vector2D>();
        Repository rep;

        public Form1()
        {
            InitializeComponent();
            rep = new Repository();
            XMLParser parser = new XMLParser(@"../../Vectors.xml");
            parser.Parse(out rep);
            foreach(IVector vec in rep.GetVectors())
            {
                if(vec.GetType() == VectorType.Vector2D)
                {
                    VectorsComboBox.Items.Add( "Vector2D( " + ((Vector2D)vec).GetX() + " | " + ((Vector2D)vec).GetY() + " )");
                    vector2Ds.Add(((Vector2D)vec));
                }
                else
                {
                    VectorsComboBox.Items.Add("Vector3D( " + ((Vector3D)vec).GetX() + " | " + ((Vector3D)vec).GetY() + " | " + ((Vector3D)vec).GetZ() + " )");
                    vector3Ds.Add(((Vector3D)vec));
                }
                
            }
            VectorsComboBox.SelectedIndex = 0;

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SetData();
        }

        private void SetData()
        {            
                Vector2ComboBox.Items.Clear();
                foreach (IVector vec in rep.GetVectors())
                {
                if (rep.GetVector(VectorsComboBox.SelectedIndex).GetType() == vec.GetType())
                {
                    if (rep.GetVector(VectorsComboBox.SelectedIndex).GetType() == VectorType.Vector2D)
                    {
                        Vector2ComboBox.Items.Add("Vector2D( " + ((Vector2D)vec).GetX() + " | " + ((Vector2D)vec).GetY() + " )");
                        VectorProductButton.Enabled = false;                        
                    }
                    else
                    {
                        Vector2ComboBox.Items.Add("Vector3D( " + ((Vector3D)vec).GetX() + " | " + ((Vector3D)vec).GetY() + " | " + ((Vector3D)vec).GetZ() + " )");
                        VectorProductButton.Enabled = true;
                    }
                }
                }
                Vector2ComboBox.SelectedIndex = 0;

        }

        private void ScalarProductButton_Click(object sender, EventArgs e)
        {
            if(rep.GetVector(VectorsComboBox.SelectedIndex).GetType() == VectorType.Vector2D)
            {
                float value = Vector2D.ScalarProduct((Vector2D)rep.GetVector(VectorsComboBox.SelectedIndex), vector2Ds[Vector2ComboBox.SelectedIndex]);
                textBox.Text = value.ToString();
            }
            else
            {
                float value = Vector3D.ScalarProduct((Vector3D)rep.GetVector(VectorsComboBox.SelectedIndex), vector3Ds[Vector2ComboBox.SelectedIndex]);
                textBox.Text = value.ToString();
            }
            
        }

        private void VectorProductButton_Click(object sender, EventArgs e)
        {
            Vector3D value = Vector3D.VectorProduct((Vector3D)rep.GetVector(VectorsComboBox.SelectedIndex), vector3Ds[Vector2ComboBox.SelectedIndex]);
            textBox.Text = "( " + value.GetX() + " | " + value.GetY() + " | " + value.GetZ() + " )";
        }
    }
}
