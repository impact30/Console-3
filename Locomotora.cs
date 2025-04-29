using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Locomotora
    {
        Vagon Primero { get; set; }
        Vagon Ultimo { get; set; }

        public void AgregaPrimero(int valor)
        {
            Vagon nuevo = new Vagon(valor);
            if (this.Primero == null)//caso 1
            {
                this.Primero = nuevo;
            }
            else //caso 2
            {
                Vagon primVag = this.Primero;

                nuevo.Sig = primVag;

                this.Primero = nuevo;

            }

        }


        public void AgregaFinal(int valor)
        {
            Vagon nuevo = new Vagon(valor);
            if (this.Primero == null)//caso 1
            {
                this.Primero = nuevo;
            }
            else //caso 2
            {
                Vagon tmp = this.Primero;
                while (tmp.Sig != null)
                {
                    tmp = tmp.Sig;
                }
                tmp.Sig = nuevo;
            }
        }
        public string VerVagones()
        {
            string listaVag = "";
            Vagon tmp = this.Primero;
            while (tmp != null)
            {
                listaVag += tmp.Dato + ", ";
                tmp = tmp.Sig;
            }
            return listaVag;
        }

        public void EliminarUltimo()

        {
            if (this.Primero == null) //CUANDO SOLO ESTA LA LOCOMOTORA

            {
                Console.WriteLine("No hay vagones para eliminar.");
                return;
            }
            if (this.Primero.Sig == null) // CUANDO HAY UN VAGON 

            {

                this.Primero = null;

                return;

            }
            Vagon tmp = this.Primero;

            while (tmp.Sig != null && tmp.Sig.Sig != null) //CUANDO HAY 2 O MAS VAGONES

            {

                tmp = tmp.Sig;

            }
            tmp.Sig = null;
        }
        public bool ExisteValor(int valor)
        {
            string listaVag = "";
            Vagon tmp = this.Primero;
            while (tmp != null)
            {
                if (tmp.Dato == valor)
                {
                    return true;
                }
                tmp = tmp.Sig;
            }
            return false;
        }

        public int GetValor(int pos)
        {
            return 0;
        }
        public void AgregaLEFinal(Locomotora otro)
        {
            Vagon tmpOtro = otro.Primero;

            while (tmpOtro != null)
            {
                this.AgregaFinal(tmpOtro.Dato);
                tmpOtro = tmpOtro.Sig;
            }
        }
    }
}
