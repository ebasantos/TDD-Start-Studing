using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using NUnit.Framework;
using System;

namespace UnitTest
{
    [TestClass]
    public class ContaTeste
    {
        [TestCase(1.00)]
        public void TesteCredito(double saldoACreditar)
        {
            var saldo = new ContaCredito().AbrirConta(Convert.ToDecimal(saldoACreditar));

            NUnit.Framework.Assert.IsTrue(saldo > 0, "Saldo Crédito implementado erroneamente");
        }

        [TestCase(-1.00)]
        public void TesteDebito(double saldoACreditar)
        {
            var saldo = new ContaDebito().AbrirConta(Convert.ToDecimal(saldoACreditar));

            NUnit.Framework.Assert.IsTrue(saldo > 0, "Saldo Débito implementado erroneamente");
        }
    }
}
