using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace correzzione_verifica
{
    public class ContoCorrente
    {
        string id;
        string cliente;
        string banca;
        float saldo;
        public ContoCorrente(string id, string cliente, string banca)
        {
            this.id = id;
            this.cliente = cliente;
            this.banca = banca;
            saldo = 0;  
        }
        public string getID()
        {
            return id;
        }
        public string getcliente()
        {
            return id;
        }
        public string getBanca()
        {
            return banca;
        }
        public float getSaldo()
        {
            return saldo;
        }
        public void Deposito(float value)
        {
            if (value >= 0)
            {
                saldo = saldo + value;
            }
        }
        public void Prelievo(float value)
        {
           float  temp = saldo - value;
            if (temp >= 0 && value>=0)
            {
                saldo = saldo - value;
            }
        }
        public void Bonifico(ContoCorrente Destinazione,float value)
        {
            float temp = saldo - value;
            if (temp >= 0 && value >= 0)
            {
                saldo = saldo - value;
                Destinazione.Deposito(value);
            }
        }
    }
    }

