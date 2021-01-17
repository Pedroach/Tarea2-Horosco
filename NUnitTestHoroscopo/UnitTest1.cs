using NUnit.Framework;
using WebHoroscopo.Controllers;

namespace NUnitTestHoroscopo
{
    public class TestHoroscopo
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestHorosco()
        {
            //Arrange=preparacion
            int num1 = 28;
            int num2 = 2;
            string esperado = "Picis: En el amor, el 2021 pinta para estar soltera, no quieres nada relacionado con los sentimientos. " +
                    "Eso s�, progresar�s mucho en el �mbito laborar y escolar, estar�s muy concentrada en tu vida y tus metas. " +
                    "El estr�s ser� uno de tus enemigos, por lo que ser� buena idea aprender algo de yoga o meditaci�n para sobrellevar otro a�o encerrada. ";
            HoroscopoController Hor = new HoroscopoController();


            //Act=ejecution
            string resultado = Hor.HoroscopoGet(num1, num2);

            //Assert=Verification
            Assert.AreEqual(esperado, resultado);
        }
    }
}