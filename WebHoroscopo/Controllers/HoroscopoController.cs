using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebHoroscopo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HoroscopoController : Controller
    {
        [HttpGet]
        public string HoroscopoGet(int num1,int num2)
        {
            if (num1 > 31 || num1 < 1)
            {
                return "Fecha inexistente";
            }
            if (num2 > 12 || num2 < 1)
            {
                return "Mes inexistente";
            }
            if ((num1 >= 21 && num2 == 3) || (num1 <= 20 && num2 == 4))
            {
                return "Aries: El 2021 no tendrá un buen inicio para ti, " +
                    "pero no te desanimes, lo bueno tarda en llegar. " +
                    "Tendrás que ser muy paciente en estos meses y pensar positivo. " +
                    "El verano promete ser la mejor temporada para ti, el amor podría aparecer. " +
                    "En el trabajo o escuela, tendrás que aprovechar tus días de descanso, " +
                    "pues estarás muy ocupada pero lograrás una gran meta este año. ";
            }
            if ((num1 >= 21 && num2 == 4) || (num1 <= 20 && num2 == 5))
            {
                return "Tauro: El dinero no te faltara, " +
                    "ya sea que por fin cumplas tu propósito de ahorrar o que la abundancia en tu trabajo sea la mejor para ti. " +
                    "Trata de no gastar en cosas innecesarias. Este año tu salud mental y emocional mejorará mucho una vez que tus hábitos" +
                    " diarios cambien, verás la vida de una nueva forma y te sentirás feliz en todos los sentidos, " +
                    "incluso si ningún crush flecha tu corazón ";
            }
            if ((num1 >= 21 && num2 == 5) || (num1 <= 20 && num2 == 6))
            {
                return "Geminis: El inicio del 2021 pinta con la mejor de las suertes para ti, " +
                    "pero no te confíes, puede que el año esté lleno de pruebas para ti, depende de ti lograr lo que quieres. " +
                    "En las relaciones y en el amor, estarás muy sensible y puede que un amor del pasado retorne a tu vida. " +
                    "Debes aprender a ser más segura y no caer en chismes, dile adiós a lo tóxico este año";
            }
            if ((num1 >= 22 && num2 == 6) || (num1 <= 22 && num2 == 7))
            {
                return "Cancer: El 2021 no iniciará muy bien para tu estado emocional, " +
                    "pero debes aprender a ser feliz con las pequeñas cosas de tu vida, cambiar tu mentalidad y disfrutar que estás saludable. " +
                    "Sin embargo, pasando los meses crearás muchos recuerdos que prometen hacer del 2021 tu mejor año. " +
                    "Quizás sufras alguna crisis existencial y el amor… este año no será posible.";
            }
            if ((num1 >= 23 && num2 == 7) || (num1 <= 23 && num2 == 8))
            {
                return "Leo: Parece que los astros decidieron voltear tus cartas, si viviste un año 2020 fabuloso, " +
                    "puede que en 2021 no sea tan bueno. Tendrás que hacer uso de tus reservas de energía positiva para sobrevivir." +
                    " No hay buenas noticias para el trabajo o escuela, deberás aprender a salir adelante y esforzarte más. Eso sí, " +
                    "tu cumple será uno de tus mejores días. ";
            }
            if ((num1 >= 24 && num2 == 8) || (num1 <= 22 && num2 == 9))
            {
                return "Virgo: Tu ánimo estará un poco intenso durante el 2021, " +
                    "pues la situación mundial te preocupa mucho y puede que estropee de nuevo tus planes en este año. " +
                    "Estarás más organizada y decidida a lograr tus metas. En el amor, aunque no tengas pareja, " +
                    "te sentirás feliz y aprenderás a disfrutar de tu soledad y soltería.";
            }
            if ((num1 >= 23 && num2 == 9) || (num1 <= 22 && num2 == 10))
            {
                return "Libra: Estarás un poco insegura sobre las cosas que quieres hacer en 2021, " +
                    "con toda la situación mundial ya no sabes si es bueno hacer planes. Los astros estarán de tu lado, " +
                    "así que gozarás de rachas de buena suerte. En el amor, puede que por fin llegue esa persona que tanto esperaste," +
                    " también será un gran año para ti en cuestiones familiares.";
            }
            if ((num1 >= 23 && num2 == 10) || (num1 <= 22 && num2 == 11))
            {
                return "Escorpio: El 2021 no iniciará con el pie derecho, " +
                    "puede que atravieses dificultades en la escuela o en el trabajo una vez que se acaben las vacaciones.  " +
                    "El destino del año dependerá solo de ti, así que es hora de enfrentar tus miedos, " +
                    "esforzarte más y confiar en tus capacidades. En el amor, puede que ese chico especial llegué a tu vida, " +
                    "pero nada asegura que sea el indicado.";
            }
            if ((num1 >= 23 && num2 == 11) || (num1 <= 21 && num2 == 12))
            {
                return "Sagitario: El 2021 será una oportunidad positiva para ti, " +
                    "ya sea que encuentres por fin el trabajo que buscabas o que te vaya de lo mejor en la escuela. " +
                    "Los astros te darán el empujón que necesitabas para salir de tu rutina diaria, " +
                    "aunque la situación mundial no haya mejorado, debes cambiar tus hábitos y aprovechar tu tiempo para poder cumplir tus sueños. " +
                    "En el amor, formalizarás una relación y dejarás atrás la soltería.";
            }
            if ((num1 >= 22 && num2 == 12) || (num1 <= 20 && num2 == 1))
            {
                return "Capricornio: Serás uno de los signos más influencias por la posición de algunos planetas, " +
                    "así que estarás en un estado donde te cuestionarás todo o te sentirás muy presionada, " +
                    "así que las terapias anti estrés serán tu mejor aliado en 2021. " +
                    "También comenzarás a cambiar tu perspectiva sobre algunas cosas y descubrirás nuevas cosas que te harán madurar.";
            }
            if ((num1 >= 21 && num2 == 1) || (num1 <= 19 && num2 == 2))
            {
                return "Acuario: El 2021 iniciará con un torbellino de emociones para ti, " +
                    "pues el amor tocará a tu puerta varias veces, pero nadie logra ser el chico de tus sueños, " +
                    "pero el verano te dará una aventura amorosa inolvidable. " +
                    "Tus propósitos de año nuevo pueden ser un poco exigentes, " +
                    "así que dependerá de ti cumplirlos o desperdiciar otros 12 meses.";
            }
            if ((num1 >= 20 && num2 == 2) || (num1 <= 20 && num2 == 3))
            {
                return "Picis: En el amor, el 2021 pinta para estar soltera, no quieres nada relacionado con los sentimientos. " +
                    "Eso sí, progresarás mucho en el ámbito laborar y escolar, estarás muy concentrada en tu vida y tus metas. " +
                    "El estrés será uno de tus enemigos, por lo que será buena idea aprender algo de yoga o meditación para sobrellevar otro año encerrada. ";
            }
            return "";
        }
        /*
        Aries: Desde 21 Marzo al 20 Abril
        Tauro: Desde 21 Abril al 20 Mayo
        Geminis: Desde 21 Mayo al 21 Junio
        Cancer: Desde 22 Junio al 22 Julio
        Leo: Desde 23 Julio al 23 Agosto
        Virgo: Desde 24 Agosto al 22 Septiembre
        Libra: Desde 23 Septiembre al 22 Octubre 
        Escorpio: Desde 23 Octubre al 22 Noviembre
        Sagitario: Desde 23 Noviembre al 21 Diciembre
        Capricornio: Desde 22 Diciembre al 20 de Enero
        Acuario: Desde 21 Enero al 19 Febrero
        Piscis: Desde 20 Febrero al 20 Marzo

         */
        [HttpPost]
        public string HoroscopoPost([FromHeader] int num1, [FromHeader] int num2)
        {
            if (num1 > 31 || num1 < 1)
            {
                return "Fecha inexistente";
            }
            if (num2 > 12 || num2 < 1)
            {
                return "Mes inexistente";
            }
            if ((num1 >= 21 && num2 == 3) || (num1 <= 20 && num2 == 4))
            {
                return "Aries: El 2021 no tendrá un buen inicio para ti, " +
                    "pero no te desanimes, lo bueno tarda en llegar. " +
                    "Tendrás que ser muy paciente en estos meses y pensar positivo. " +
                    "El verano promete ser la mejor temporada para ti, el amor podría aparecer. " +
                    "En el trabajo o escuela, tendrás que aprovechar tus días de descanso, " +
                    "pues estarás muy ocupada pero lograrás una gran meta este año. ";
            }
            if ((num1 >= 21 && num2 == 4) || (num1 <= 20 && num2 == 5))
            {
                return "Tauro: El dinero no te faltara, " +
                    "ya sea que por fin cumplas tu propósito de ahorrar o que la abundancia en tu trabajo sea la mejor para ti. " +
                    "Trata de no gastar en cosas innecesarias. Este año tu salud mental y emocional mejorará mucho una vez que tus hábitos" +
                    " diarios cambien, verás la vida de una nueva forma y te sentirás feliz en todos los sentidos, " +
                    "incluso si ningún crush flecha tu corazón ";
            }
            if ((num1 >= 21 && num2 == 5) || (num1 <= 20 && num2 == 6))
            {
                return "Geminis: El inicio del 2021 pinta con la mejor de las suertes para ti, " +
                    "pero no te confíes, puede que el año esté lleno de pruebas para ti, depende de ti lograr lo que quieres. " +
                    "En las relaciones y en el amor, estarás muy sensible y puede que un amor del pasado retorne a tu vida. " +
                    "Debes aprender a ser más segura y no caer en chismes, dile adiós a lo tóxico este año";
            }
            if ((num1 >= 22 && num2 == 6) || (num1 <= 22 && num2 == 7))
            {
                return "Cancer: El 2021 no iniciará muy bien para tu estado emocional, " +
                    "pero debes aprender a ser feliz con las pequeñas cosas de tu vida, cambiar tu mentalidad y disfrutar que estás saludable. " +
                    "Sin embargo, pasando los meses crearás muchos recuerdos que prometen hacer del 2021 tu mejor año. " +
                    "Quizás sufras alguna crisis existencial y el amor… este año no será posible.";
            }
            if ((num1 >= 23 && num2 == 7) || (num1 <= 23 && num2 == 8))
            {
                return "Leo: Parece que los astros decidieron voltear tus cartas, si viviste un año 2020 fabuloso, " +
                    "puede que en 2021 no sea tan bueno. Tendrás que hacer uso de tus reservas de energía positiva para sobrevivir." +
                    " No hay buenas noticias para el trabajo o escuela, deberás aprender a salir adelante y esforzarte más. Eso sí, " +
                    "tu cumple será uno de tus mejores días. ";
            }
            if ((num1 >= 24 && num2 == 8) || (num1 <= 22 && num2 == 9))
            {
                return "Virgo: Tu ánimo estará un poco intenso durante el 2021, " +
                    "pues la situación mundial te preocupa mucho y puede que estropee de nuevo tus planes en este año. " +
                    "Estarás más organizada y decidida a lograr tus metas. En el amor, aunque no tengas pareja, " +
                    "te sentirás feliz y aprenderás a disfrutar de tu soledad y soltería.";
            }
            if ((num1 >= 23 && num2 == 9) || (num1 <= 22 && num2 == 10))
            {
                return "Libra: Estarás un poco insegura sobre las cosas que quieres hacer en 2021, " +
                    "con toda la situación mundial ya no sabes si es bueno hacer planes. Los astros estarán de tu lado, " +
                    "así que gozarás de rachas de buena suerte. En el amor, puede que por fin llegue esa persona que tanto esperaste," +
                    " también será un gran año para ti en cuestiones familiares.";
            }
            if ((num1 >= 23 && num2 == 10) || (num1 <= 22 && num2 == 11))
            {
                return "Escorpio: El 2021 no iniciará con el pie derecho, " +
                    "puede que atravieses dificultades en la escuela o en el trabajo una vez que se acaben las vacaciones.  " +
                    "El destino del año dependerá solo de ti, así que es hora de enfrentar tus miedos, " +
                    "esforzarte más y confiar en tus capacidades. En el amor, puede que ese chico especial llegué a tu vida, " +
                    "pero nada asegura que sea el indicado.";
            }
            if ((num1 >= 23 && num2 == 11) || (num1 <= 21 && num2 == 12))
            {
                return "Sagitario: El 2021 será una oportunidad positiva para ti, " +
                    "ya sea que encuentres por fin el trabajo que buscabas o que te vaya de lo mejor en la escuela. " +
                    "Los astros te darán el empujón que necesitabas para salir de tu rutina diaria, " +
                    "aunque la situación mundial no haya mejorado, debes cambiar tus hábitos y aprovechar tu tiempo para poder cumplir tus sueños. " +
                    "En el amor, formalizarás una relación y dejarás atrás la soltería.";
            }
            if ((num1 >= 22 && num2 == 12) || (num1 <= 20 && num2 == 1))
            {
                return "Capricornio: Serás uno de los signos más influencias por la posición de algunos planetas, " +
                    "así que estarás en un estado donde te cuestionarás todo o te sentirás muy presionada, " +
                    "así que las terapias anti estrés serán tu mejor aliado en 2021. " +
                    "También comenzarás a cambiar tu perspectiva sobre algunas cosas y descubrirás nuevas cosas que te harán madurar.";
            }
            if ((num1 >= 21 && num2 == 1) || (num1 <= 19 && num2 == 2))
            {
                return "Acuario: El 2021 iniciará con un torbellino de emociones para ti, " +
                    "pues el amor tocará a tu puerta varias veces, pero nadie logra ser el chico de tus sueños, " +
                    "pero el verano te dará una aventura amorosa inolvidable. " +
                    "Tus propósitos de año nuevo pueden ser un poco exigentes, " +
                    "así que dependerá de ti cumplirlos o desperdiciar otros 12 meses.";
            }
            if ((num1 >= 20 && num2 == 2) || (num1 <= 20 && num2 == 3))
            {
                return "Picis: En el amor, el 2021 pinta para estar soltera, no quieres nada relacionado con los sentimientos. " +
                    "Eso sí, progresarás mucho en el ámbito laborar y escolar, estarás muy concentrada en tu vida y tus metas. " +
                    "El estrés será uno de tus enemigos, por lo que será buena idea aprender algo de yoga o meditación para sobrellevar otro año encerrada. ";
            }
            return "";


        }
    }
}
