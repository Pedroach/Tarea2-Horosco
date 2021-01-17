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
                    "Eso sí, progresarás mucho en el ámbito laborar y escolar, estarás muy concentrada en tu vida y tus metas. " +
                    "El estrés será uno de tus enemigos, por lo que será buena idea aprender algo de yoga o meditación para sobrellevar otro año encerrada. ";
            HoroscopoController Hor = new HoroscopoController();


            //Act=ejecution
            string resultado = Hor.HoroscopoGet(num1, num2);

            //Assert=Verification
            Assert.AreEqual(esperado, resultado);
        }
    }
}