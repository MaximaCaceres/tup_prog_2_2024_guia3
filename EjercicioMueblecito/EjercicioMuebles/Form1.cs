using EjercicioMuebles.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioMuebles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList productos = new ArrayList();
        private void btnPrueba_Click(object sender, EventArgs e)
        {
            Producto prod;
            prod = new Mesa("Mesa Comedor",10.1,1,1);
            productos.Add(prod);
            prod = new Silla("Silla Escritorio", 12.2,2);         
            productos.Add(prod);

            foreach (Producto n in productos)
            {
                if (n is Mesa || n is Silla)
                {
                    tbxLista.Text += n.VerDetalle();
                }
            }


            /*for(int i = 0; i < productos.Count; i++)esta es otra forma pero me olvide el + entonces me mostraba uno solo jaja.
            {
                Producto a = (Producto)productos[i];
                if (a is Mesa || a is Silla)
                {

                    tbxLista.Text += a.VerDetalle();
                }
            }*/

            //////////////////////////////////////////////////////
            
            /*foreach(Producto n in productos) 
            {

                if(n is Mesa  || n is Silla)
                {
                    tbxLista.Text += n.VerDetalle();
                }

            }*/
        }
    }
}
