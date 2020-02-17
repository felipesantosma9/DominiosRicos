using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace NerdStore.Core.DomainObjects
{
    public class Validacoes
    {
        public static void ValidarSeIgual(object object1, object object2, string menssagem)
        {
            if (object1.Equals(object2))
            {
                throw new DomainException(menssagem);
            }
        }

        public static void ValidarSeDiferente(object object1, object object2, string menssagem)
        {
            if (!object1.Equals(object2))
            {
                throw new DomainException(menssagem);
            }
        }

        public static void ValidarCaracteres(string valor, int maximo, string menssagem)
        {
            var length = valor.Trim().Length;
            if (length > maximo)
            {
                throw new DomainException(menssagem);
            }
        }

        public static void ValidarCaracteres(string valor, int minimo, int maximo, string menssagem)
        {
            var length = valor.Trim().Length;
            if (length < minimo || length > maximo)
            {
                throw new DomainException(menssagem);
            }
        }

        public static void ValidarExpression(string pattern, string valor, string menssagem)
        {
            var regex = new Regex(pattern);

            if (!regex.IsMatch(valor))
            {
                throw new DomainException(menssagem);
            }
        }

        public static void ValidarSeVazio(string valor, string menssagem)
        {
            if (valor == null || valor.Trim().Length == 0)
            {
                throw new DomainException(menssagem);
            }
        }

        public static void ValidarSeNullo(object object1, string menssagem)
        {
            if (object1 == null)
            {
                throw new DomainException(menssagem);
            }
        }

        public static void ValidarMinimoMaximo(double valor, double minimo, double maximo, string menssagem)
        {
            if (valor < minimo || valor > maximo)
            {
                throw new DomainException(menssagem);
            }
        }

        public static void ValidarMinimoMaximo(float valor, float minimo, float maximo, string menssagem)
        {
            if (valor < minimo || valor > maximo)
            {
                throw new DomainException(menssagem);
            }
        }

        public static void ValidarMinimoMaximo(int valor, int minimo, int maximo, string menssagem)
        {
            if (valor < minimo || valor > maximo)
            {
                throw new DomainException(menssagem);
            }
        }

        public static void ValidarMinimoMaximo(long valor, long minimo, long maximo, string menssagem)
        {
            if (valor < minimo || valor > maximo)
            {
                throw new DomainException(menssagem);
            }
        }

        public static void ValidarSeMenorQue(long valor, long minimo, string menssagem)
        {
            if (valor < minimo)
            {
                throw new DomainException(menssagem);
            }
        }

        public static void ValidarSeMenorQue(double valor, double minimo, string menssagem)
        {
            if (valor < minimo)
            {
                throw new DomainException(menssagem);
            }
        }

        public static void ValidarSeMenorQue(decimal valor, decimal minimo, string menssagem)
        {
            if (valor < minimo)
            {
                throw new DomainException(menssagem);
            }
        }

        public static void ValidarSeMenorQue(int valor, int minimo, string menssagem)
        {
            if (valor < minimo)
            {
                throw new DomainException(menssagem);
            }
        }

        public static void ValidarSeFalso(bool boolvalor, string menssagem)
        {
            if (!boolvalor)
            {
                throw new DomainException(menssagem);
            }
        }

        public static void ValidarSeVerdadeiro(bool boolvalor, string menssagem)
        {
            if (boolvalor)
            {
                throw new DomainException(menssagem);
            }
        }
    }
}
