using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examen3EvNamespace;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //PNICOLAS 1CFSY
        public void CalcularMediaOk()
        {
            //PNICOLAS 1CFSY
            double notaObtenida;
            List<int> notas = new List<int>();

            notas.Add(0);
            notas.Add(5);
            notas.Add(9);
            notas.Add(3);
            notas.Add(7);
            notas.Add(4);
            notas.Add(8);

            // PNICOLAS 1CFSY
            EstadisticasNotas objeto = new EstadisticasNotas();
            notaObtenida = objeto.CalcularEstadisticas(notas);
            notaObtenida = Math.Round(notaObtenida, 3);

            double mediaEsperada = 5.143;
            Assert.AreEqual(mediaEsperada, notaObtenida);
        }
        //PNICOLAS 1CFSY
        [TestMethod]
        public void CalcularNumeroSuspensos()
        {
            double notaObtenida;
            List<int> notas = new List<int>();
            int susE = 3;

            notas.Add(0);
            notas.Add(5);
            notas.Add(9);
            notas.Add(3);
            notas.Add(7);
            notas.Add(4);
            notas.Add(8);

            EstadisticasNotas objeto = new EstadisticasNotas();
            notaObtenida = objeto.CalcularEstadisticas(notas);

            Assert.AreEqual(susE, objeto.suspensos);

        }

        [TestMethod]
        public void CalcularNumeroAprobados()
        {
            double notaObtenida;
            List<int> notas = new List<int>();
            int aprE = 1;

            notas.Add(0);
            notas.Add(5);
            notas.Add(9);
            notas.Add(3);
            notas.Add(7);
            notas.Add(4);
            notas.Add(8);

            EstadisticasNotas objeto = new EstadisticasNotas();
            notaObtenida = objeto.CalcularEstadisticas(notas);

            Assert.AreEqual(aprE, objeto.aprobados);

        }

        [TestMethod]
        public void CalcularNumeroNotables()
        {
            double notaObtenida;
            List<int> notas = new List<int>();
            int notE = 2;

            notas.Add(0);
            notas.Add(5);
            notas.Add(9);
            notas.Add(3);
            notas.Add(7);
            notas.Add(4);
            notas.Add(8);

            EstadisticasNotas objeto = new EstadisticasNotas();
            notaObtenida = objeto.CalcularEstadisticas(notas);

            Assert.AreEqual(notE, objeto.notables);

        }

        [TestMethod]
        public void CalcularNumeroSobresalientes()
        {
            double notaObtenida;
            List<int> notas = new List<int>();
            int sbrE = 1;

            notas.Add(0);
            notas.Add(5);
            notas.Add(9);
            notas.Add(3);
            notas.Add(7);
            notas.Add(4);
            notas.Add(8);

            EstadisticasNotas objeto = new EstadisticasNotas();
            notaObtenida = objeto.CalcularEstadisticas(notas);

            Assert.AreEqual(sbrE, objeto.sobresalientes);

        }


        [TestMethod]
        //PNICOLAS 1CFSY
        public void CalcularMediaVacio_Fallo()
        {
            //PNICOLAS 1CFSY
            double notaObtenida;
            List<int> notas = new List<int>();

            // PNICOLAS 1CFSY
            EstadisticasNotas objeto = new EstadisticasNotas();
            try
            {
                notaObtenida = objeto.CalcularEstadisticas(notas);
            }
            catch(Exception e)
            {
                if(e.Message.Contains("Las lista no puede ser vacía."))
                {
                    return;
                }
                else
                {
                    Assert.Fail();
                }
            }
            Assert.Fail();
        }

        [TestMethod]
        //PNICOLAS 1CFSY
        public void CalcularMedianotasDesbordadas_Fallo()
        {
            double notaObtenida;
            List<int> notas = new List<int>();

            notas.Add(-4);
            notas.Add(5);
            notas.Add(9);
            notas.Add(3);
            notas.Add(7);
            notas.Add(4);
            notas.Add(12);

            // PNICOLAS 1CFSY
            EstadisticasNotas objeto = new EstadisticasNotas();

            try
            {
                notaObtenida = objeto.CalcularEstadisticas(notas);

            } catch(Exception e)
            {
                if (e.Message.Contains("Las notas no pueden ser menores que cero ni mayores que 10"))
                {
                    return;
                }
                else
                {
                    Assert.Fail();
                }
            }
            Assert.Fail();
        }
    }
}
