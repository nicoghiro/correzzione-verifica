using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace correzzione_verifica
{
    public class CartaBancomat
    {
        string id;
        string pin;
        ContoCorrente conto;
        public CartaBancomat(string id, string pin, ContoCorrente conto)
        {
            this.id = id;
            this.pin = pin;
            this.conto = conto;
        }   
        public string getID()
        {
            return id;  
        }
        public void deposita(float value,string Pin)
        {
            if (pin == Pin)
            {
               conto.Deposito(value);
            }
            else
            {
                throw new Exception("pin sbagliato");
            }
        }
        public void preleva(float value, string Pin)
        {
            if (pin == Pin)
            {
                conto.Prelievo(value);
            }
            else
            {
                throw new Exception("pin sbagliato");
            }
        }
        public float getSaldo()
        {
            return conto.getSaldo();
        }
    }
}
