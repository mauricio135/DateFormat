using NUnit.Framework;

namespace Program.Test
{
    public class Tests
    {
        [Test]
        public void EntradaVaciaDevuelveVacia()
        {
            string InputDate = string.Empty;
            string OutputDate = Program.ChangeFormat(InputDate);
            Assert.AreEqual(string.Empty, OutputDate);
        }

        [Test]
        public void FormatoCorrectoSalidaCorrecta()
        {
            string InputDate = "13/05/1997";
            Assert.AreEqual(Program.ChangeFormat(InputDate),"1997-05-13");
        }

        [Test]
        public void DiaMenorQueDiezSinCeroAdelante()
        {
            string InputDate = "3/05/1997";
            string OutputDate = Program.ChangeFormat(InputDate);
            Assert.AreEqual("1997-05-3", OutputDate);
        }

        [Test]
        public void MesMenorQueDiezSinCeroAdelante()
        {
            string InputDate = "13/5/1997";
            string OutputDate = Program.ChangeFormat(InputDate);
            Assert.AreEqual("1997-5-13", OutputDate);
        }

        [Test]
        public void SeparadorIncorrectoDevuelveVacio()
        {
            string InputDate = "13-05-1997";
            Assert.AreEqual(string.Empty, Program.ChangeFormat(InputDate));
        }

        [Test]
        public void DiaMayorQueTreintaYUnoDevuelveVacio()
        {
            string InputDate = "32/05/1997";
            Assert.AreEqual(string.Empty, Program.ChangeFormat(InputDate));
        }

        [Test]
        public void MesMayorQueDoceDevuelveVacio()
        {
            string InputDate = "13/15/1997";
            Assert.AreEqual(string.Empty, Program.ChangeFormat(InputDate));

        }
    }
}