using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        public string nome 
        { 
            get => _nome.ToUpper();
            
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser vasio");
                }

                _nome = value;
            }
        }
       
        public string sobrenome { get; set; }
        public string NomeCompleto => $"{nome} {sobrenome}";
        public int idade
        { 
            get => _idade; 

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero!");
                }

                _idade = value;
            }
        
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto.ToUpper()}  \nIdade: {idade}"); 
        }
    }
}