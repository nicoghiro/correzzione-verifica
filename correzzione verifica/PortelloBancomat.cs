using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace correzzione_verifica
{
    public class PortelloBancomat
    {
        int i = 0;
        string id;
        string banca;
        string indirizzo;
        bool stato;
        CartaBancomat cartaBancomat;
        CartaBancomat[] bloccate;
        CartaBancomat[] ritirate = new CartaBancomat[100];
        public PortelloBancomat(string id, string banca, string indirizzo, CartaBancomat[] bloccate)
        {
            this.id = id;
            this.banca = banca;
            this.indirizzo = indirizzo;
            cartaBancomat = null;
            stato = true;
            this.bloccate = bloccate;
        }
        public string getId()
        {
            return id;
        }
        public string getBanca()
        {
            return banca;
        }
        public string getIndirizzo()
        {
            return indirizzo;
        }
        public void inserisci(CartaBancomat carta)
        {
            if (stato == true)
            {
                if (ricercaLineare(bloccate, carta) != -1)
                {
                    stato = false;
                    cartaBancomat = carta;
                }
                else
                {
                    ritirate[i] = carta;
                    i++;
                    throw new Exception("carta ritirata");
                }
            }
            else
            {
                throw new Exception("Lo sportello è al momento occupato");
            }
        }
        public void rimuovi()
        {
            if (stato == false)
            {
                cartaBancomat = null;
                stato = true;
            }
            else
            {
                throw new Exception("lo sportello è al momento libero");
            }
        }
        public static int ricercaLineare(CartaBancomat[] arr, CartaBancomat chiave)
        {
            for (int i = 0; i < arr.Length; i++) { 
                if (arr[i] == chiave)
                    return i;}
            return -1;
        }
    }
}
