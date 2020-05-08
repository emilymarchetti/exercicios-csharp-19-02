using System;

namespace exercicios {
    class Program {
        static void Main (string[] args) {
            Ex7 ();
        }

        struct Livro
        {
            public String Titulo;
            public String Autor;
            public Double Valor;
        }

        struct Aluno
        {
            public string Nome;
            public int RA;
            public double Nota;
            public double Frequencia;
        }

        public static string GetVogais (string texto) {
            string vogais = "";

            char[] palavra = texto.ToCharArray ();

            for (int i = 0; i < palavra.Length; i++) {
                char letra = palavra[i];
                if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u') {
                    if (i == 0) {
                        vogais += letra.ToString ();
                    } else {
                        vogais += ',' + letra.ToString ();
                    }
                }
            }
            return vogais;
        }


        public static string GetConsoantes (string texto) {
            texto = texto.Replace("a", "");
            texto = texto.Replace("e", "");
            texto = texto.Replace("i", "");
            texto = texto.Replace("o", "");
            texto = texto.Replace("u", "");
            return texto;
        }

        public static void Ex1 () {
            // Exercicio 1
            //1- Desenvolver uma aplicação de calculadora com as operações básicas: soma, subtração, multiplicação, divisão e resto da divisão.
            Console.WriteLine ("Digite o primeiro número: ");
            var num1 = decimal.Parse (Console.ReadLine ());
            Console.WriteLine ("Digite o segundo número: ");
            var num2 = decimal.Parse (Console.ReadLine ());

            Console.WriteLine ($"\nSoma: {num1 + num2}");
            Console.WriteLine ($"Subtração: {num1 - num2}");
            Console.WriteLine ($"Divisão: {num1 / num2}");
            Console.WriteLine ($"Multiplicação: {num1 * num2}");
            Console.WriteLine ($"Resto: {num1 % num2}");

        }

        public static void Ex2 () {
            // Exercicio 2
            // Desenvolver uma aplicação que leia uma string e informe a quantidade de vogais contidas nela.

            Console.WriteLine ("Digite uma palavra");
            var texto = Console.ReadLine ();

            string vogais = GetVogais (texto);
            string[] arrayVogais = vogais.Split (',');

            Console.WriteLine ($"A palavra '{texto}' tem {arrayVogais.Length} vogais");
        }

        public static void Ex3 () {
            // Exercicio 3
            // Desenvolver uma aplicação que leia uma string e imprima apenas as vogais.
            Console.WriteLine ("Digite uma palavra");
            var texto = Console.ReadLine ();

            string vogais = GetVogais (texto);
            // TODO: fazer um distinct
            Console.WriteLine ($"A palavra '{texto}' tem as vogais : '{vogais}'");
        }

        public static void Ex4 () {
            // Exercicio 4
            // Desenvolver uma aplicação que leia uma string e imprima apenas as consoantes.

            Console.WriteLine ("Digite uma palavra");
            var texto = Console.ReadLine ();

            string consoantes = GetConsoantes (texto);
            Console.WriteLine ($"A palavra '{texto}' sem as vogais : '{consoantes}'");
        }

        public static void Ex5 (){
            // Exercicio 5
            // Desenvolver uma aplicação que leia a idade de uma pessoa e informe em qual faixa etária ela esta.
            Console.WriteLine("Informe a sua idade: ");
            double idade = Double.Parse(Console.ReadLine());

            if (idade == 0 || idade <= 19) {
                Console.WriteLine($"{idade} anos, você é jovem!");
            } else if (idade == 20 || idade <= 59) {
                Console.WriteLine($"{idade} anos, você é adulto!");
            } else if (idade >= 60) {
                Console.WriteLine($"{idade} anos, você é idoso!");
            }
        }

        public static void Ex6 (){
            // Exercicio 6
            // Utilizando struct, desenvolver efetuar o cadastro de um livro, com seu Titulo, Autor e Valor, e os imprima na tela.
            Livro livro;
            Console.WriteLine("Informe um titulo: ");
            livro.Titulo = Console.ReadLine();

            Console.WriteLine("Informe um autor: ");
            livro.Autor = Console.ReadLine();

            Console.WriteLine("Informe um valor:");
            livro.Valor = double.Parse(Console.ReadLine());
            Console.WriteLine($"Livro cadastrado com sucesso! \nTitulo: {livro.Titulo} \nAutor: {livro.Autor} \nValor: {livro.Valor} reais");
        }

        public static void Ex7()
        {
            // Exercicio 7
            // Utilizando struct, efetuar o cadastro de um aluno, contendo nome, R.A., uma nota e frequência, 1 função para média e outra para ver se passou ou não pelas faltas, a julgar que o limite de faltas é 40 % de 25 aulas e a media é 7.
            Aluno aluno;
            Console.WriteLine("Informe o nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Informe o RA do aluno: ");
            aluno.RA = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota do aluno: ");
            aluno.Nota = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a frequencia do aluno: ");
            aluno.Frequencia = double.Parse(Console.ReadLine());

            Console.WriteLine("Aluno cadastrado com sucesso!");
            Console.WriteLine($"Aluno: {aluno.Nome}");
            Console.WriteLine($"RA: {aluno.RA}");
            Console.WriteLine($"Nota: {aluno.Nota}");
            Console.WriteLine($"Média: {aluno.Nota}, {Media(aluno.Nota)}");
            Console.WriteLine($"Frequência: {Frequencia(aluno.Frequencia)}");

            string Media(double nota) => nota < 7 ? "Reprovado" : "Aprovado";

            string Frequencia(double frequencia){
                double resultado = ((frequencia / 25) * 100);
                return resultado < 40 ? resultado + "% Reprovado por falta, a frequencia dele foi menor de 40% de 25 aulas " : resultado + "% Aprovado, a frequencia do aluno foi maior que 10% de 25 aulas";
            }
        }
    }
}