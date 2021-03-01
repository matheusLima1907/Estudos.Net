using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDeSignos
{
    class InterpretadorSigno
    {
        private Signo[] signos = new Signo[12];

        public InterpretadorSigno()
        {
            signos[0] = new Signo
            {
                diaInicio = 20,
                mesInicio = 1,
                diaFim = 18,
                mesFim = 2,
                nome = "Aquario",
                caracteristicas = "Aquario nos ensina a amizade, a fraternidade, a originalidade, a inovacao, o respeito as diferencas,o amor incondicional ao ser humano e a natureza.Liberdade e a palavra de Aquario."
            };
            signos[1] = new Signo
            {
                diaInicio = 19,
                mesInicio = 2,
                diaFim = 20,
                mesFim = 3,
                nome = "Peixes",
                caracteristicas = "Peixes nos ensina a fe, a conexao com uma dimensao superior, a simplicidade, o desprendimento, a entrega a vida.Aceitacao e a palavra de Peixes."
            };
            signos[2] = new Signo
            {
                diaInicio = 21,
                mesInicio = 3,
                diaFim = 19,
                mesFim = 4,
                nome = "Aries",
                caracteristicas = "Aries nos ensina a coragem, a lideranca, o impulso, a motivacao para iniciar projetos e seguir em frente,mesmo com obstaculos.Superacao e a palavra de Aries."
            };
            signos[3] = new Signo
            {
                diaInicio = 20,
                mesInicio = 4,
                diaFim = 20,
                mesFim = 5,
                nome = "Touro",
                caracteristicas = "Touro nos ensina o cuidado, o carinho, a paciencia para observar, ver crescer, acompanhar o proprio processo de desenvolvimento e o crescimento de outros.Persistencia e a palavra de Touro."
            };
            signos[4] = new Signo
            {
                diaInicio = 21,
                mesInicio = 5,
                diaFim = 21,
                mesFim = 6,
                nome = "Gemeos",
                caracteristicas = "Gemeos nos ensina a comunicacao, a boa palavra, a gentileza, a diplomacia para fazer contatos,transmitir informacoes e trocar opinioes com as pessoas.Conexao e a palavra de Gemeos."
            };
            signos[5] = new Signo
            {
                diaInicio = 22,
                mesInicio = 6,
                diaFim = 22,
                mesFim = 7,
                nome = "Cancer",
                caracteristicas = "Cancer nos ensina o amor, a intimidade, a protecao, o aconchego e o suporte emocional para nos sentirmos queridos e seguros,participando de uma familia.Pertencer e a palavra de Cancer."
            };
            signos[6] = new Signo
            {
                diaInicio = 23,
                mesInicio = 7,
                diaFim = 22,
                mesFim = 8,
                nome = "Leao",
                caracteristicas = "Leao nos ensina a criatividade, a alegria, a espontaneidade, a vaidade, a autoestima para seguirmos agindo corretamente e nos orgulhando de nos mesmos.Nobreza e a palavra de Leao."
            };
            signos[7] = new Signo
            {
                diaInicio = 23,
                mesInicio = 8,
                diaFim = 22,
                mesFim = 9,
                nome = "Virgem",
                caracteristicas = "Virgem nos ensina a produtividade, o amor ao trabalho, o desejo de ser util, de servir,de ajudar a nos mesmos e as outras pessoas.Eficiencia e a palavra de Virgem."
            };
            signos[8] = new Signo
            {
                diaInicio = 23,
                mesInicio = 9,
                diaFim = 22,
                mesFim = 10,
                nome = "Libra",
                caracteristicas = "Libra nos ensina o compromisso, o laco, o engajamento com os outros, a sofisticacao, o amor as artes e a delicadeza que encanta e cativa as pessoas ao redor.Charme e a palavra de Libra."
            };
            signos[9] = new Signo
            {
                diaInicio = 23,
                mesInicio = 10,
                diaFim = 21,
                mesFim = 11,
                nome = "Escorpiao",
                caracteristicas = "Escorpiao nos ensina o silencio, a profundidade, o misterio, as emocoes, a possibilidade de nos despojar e nos transformar em pessoas melhores.Transcendencia e a palavra de Escorpiao."
            };
            signos[10] = new Signo
            {
                diaInicio = 22,
                mesInicio = 11,
                diaFim = 21,
                mesFim = 12,
                nome = "Sagitario",
                caracteristicas = "Sagitario nos ensina a esperanca, a fe no futuro, a energia positiva, o interesse em ir muito mais longe para descobrir que o mundo e maior.Expansao a palavra de Sagitario."
            };
            signos[11] = new Signo
            {
                diaInicio = 22,
                mesInicio = 12,
                diaFim = 19,
                mesFim = 1,
                nome = "Capricornio",
                caracteristicas = "Capricornio nos ensina a responsabilidade, a disciplina, a etica, a sabedoria obtida pela idade,o respeito aos mais velhos,a forca de vontade.Consciencia e a palavra de Capricornio."
            };
        }
        public Signo Interpretar(int dia, int mes)
        {


            Signo signo = null;
            for (int i = 0; i < signos.Length; i++)
            {
                if ((dia >= signos[i].diaInicio && mes == signos[i].mesInicio) ||
                    (dia <= signos[i].diaFim && mes == signos[i].mesFim))
                {
                    signo = signos[i];

                }
            }
            return signo;

        }
    }
}
