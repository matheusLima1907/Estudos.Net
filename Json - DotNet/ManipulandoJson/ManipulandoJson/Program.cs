using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ManipulandoJson
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConverterObjetoParaJson();
            //ConverterJsonParaObjeto();
            SalvarObjetoEmArquivo();
            //LerObjetodeArquivo();
        }

        //converte objeto em string para formato Json
        static void ConverterObjetoParaJson()
        {
            //instancia um novo topico partindo da classe Topico
            Topico topico = new Topico
            {
                Id = 1,
                Titulo = "Erro ao publicar projeto",
                Conteudo = "Estou obtendo o erro XYZ ao publicar meu projeto na hospedagem",
                Tags = new string[3] { "Asp.Net", "C#", "Visual Studio" }
            };

            //converte topico criado em objeto Json
            string json = JsonConvert.SerializeObject(topico);

            //printa no console o resultado da operação
            Console.WriteLine(json);
        }

        //converte objeto em formato Json para String
        static void ConverterJsonParaObjeto()
        {
            //"declara" um objeto em formato Json
            string json = "{" +
                          " 'Id':1, " +
                          " 'Titulo':'Erro ao publicar projeto'," +
                          " 'Conteudo':'Estou obtendo o erro XYZ ao publicar meu projeto na hospedagem.'," +
                          " 'Usuario':'joel'," +
                          " 'Tags': ['ASP.NET','C#','Visual Studio']" +
                          "}";

            //desserializa, desconverte objeto Json para, novamente, uma string
            Topico topico = JsonConvert.DeserializeObject<Topico>(json);

            //printa no console o resultado da operação
            Console.WriteLine($"{topico.Id}\n{topico.Titulo}\n{topico.Conteudo}");
        }

        //Salva Objeto em Json em arquivo utilizando a classe Stream do namespace system.IO e o framework Json.Net
        static void SalvarObjetoEmArquivo()
        {
            //cria lista de produtos baseando-se no metodo de criar lista de produtos
            List<Produto> produtos = CriarListaDeProdutos();

            /*//adiciona novos elementos à lista de produtos
            produtos.Add(new Produto(1, "MousePad", 19.9m));
            produtos.Add(new Produto(2, "SmartPhone 8GB de Memoria", 1099.9m));
            produtos.Add(new Produto(3, "Teclado Gamer", 99.8m));*/

            //nos da acesso ao arquivo em questão do diretorio declarado no metodo, caso não exista, ele cria
            StreamWriter stream = new StreamWriter("C:\\Users\\mrodrili\\Documents\\Devmedia\\Json - DotNet\\Produtos.Json");
            //escreve o resultado da lista anterior utilizando Json, no arquivo criado anteriormente
            JsonTextWriter writer = new JsonTextWriter(stream);
            //serializa a lista anterior como formato Json
            JsonSerializer serializer = new JsonSerializer();

            /*//ignora valores nulos/defaut
            serializer.NullValueHandling = NullValueHandling.Ignore;
            serializer.DefaultValueHandling = DefaultValueHandling.Ignore;*/

            //gera o arquivo indentado, formatado
            writer.Formatting = Formatting.Indented;

            //pega a lista que criamos e a passa para o JsonTextWriter criado anteriormente, escrevendo o arquivo que criamos
            serializer.Serialize(writer, produtos);

            //fecha o arquivo indicando que não esta mais em uso
            stream.Close();
        }

        //Le Objeto em Json em arquivo utilizando a classe Stream do namespace system.IO e o framework Json.Net
        static void LerObjetodeArquivo()
        {
            //nos da acesso ao arquivo em questão do diretorio declarado no metodo, nos permitindo le-lo
            StreamReader stream = new StreamReader("C:\\Users\\mrodrili\\Documents\\Devmedia\\Json - DotNet\\Produtos.Json");
            //le o arquivo acessado pelo metodo anterior
            JsonTextReader reader = new JsonTextReader(stream);
            //serializa as informações listadas no arquivo
            JsonSerializer serializer = new JsonSerializer();

            //deserializa os objetos da lista anterior retirando-os do formato Json, informando o tipo, no caso uma lista
            List<Produto> produtos = serializer.Deserialize<List<Produto>>(reader);

            //percorre a lista deserializada anteriormente retornando cada objeto presente na mesma
            foreach (var prod in produtos)
            {
                Console.WriteLine(prod);
            }

            //informa que o arquivo não esta mais em uso, fechando-o
            stream.Close();

        }

        //cria lista de 1000 produtos a serem cadastrados e salvos em arquivo
        static List<Produto> CriarListaDeProdutos()
        {
            List<Produto> produtos = new List<Produto>();

            for (int i = 0; i < 1000; i++)
            {
                produtos.Add(new Produto(i + 1, $"Produto {i + 1}", (i + 1) * 5)
                {
                    ///as propriedades abaixo receberão valores defaut a partir de agora         
                    DataCadastro = DateTime.Today.AddDays(-i),
                    PrecoCusto = i * 3
                });                
            }
            return produtos;
        }


    }
}
