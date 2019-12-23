using System;
using System.ComponentModel.DataAnnotations;

namespace Jobs.Models
{
    public class Profissional
    {
        [Key]
        public int IdProfissional { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório", AllowEmptyStrings = false)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O sobrenome é obrigatório", AllowEmptyStrings = false)]
        public string SobreNome { get; set; }

        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Nascimento { get; set; }


        public char Genero { get; set; }

        [Display(Name = "Estado Civíl")]
        public string EstadoCivil { get; set; }

        public string Nacionalidade { get; set; }

        [Display(Name = "CNH")]
        public string Cnh { get; set; }

        [Display(Name = "Atualmente Empregado")]
        public bool Empregado { get; set; }







        [Display(Name = "Currículo")]
        [DataType(DataType.Upload)]
        public byte[] Curriculo { get; set; }

        public string MimeType { get; set; }



        public string Cep { get; set; }

        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Display(Name = "Número")]
        public int? NumeroEndereco { get; set; }

        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }



        public string Telefone { get; set; }
        public string TipoTelefone { get; set; }
        public string Operadora { get; set; }


        [Required(ErrorMessage = "O e-mail é obrigatório", AllowEmptyStrings = false)]
        public string Email { get; set; }

        [Display(Name = "Grau de Formação")]
        public string GrauFormacao { get; set; }


        [Display(Name = "Curso de Formação")]
        public string CursoFormacao { get; set; }

        [Display(Name = "Curso e Treinamentos")]
        public string CursoTreinamentos { get; set; }


        public string Idiomas { get; set; }

        [Display(Name = "Experiencia Profissional")]
        public string ExperienciaProfissional { get; set; }


        public string Empresa { get; set; }

        [Display(Name = "Data de Entrada")]
        public DataType DataEntrada { get; set; }

        [Display(Name = "Data de Saída")]
        public DataType DataSaida { get; set; }

        [Display(Name = "Emprego Atual")]
        public bool EmpregoAtual { get; set; }

        [Display(Name = "Função Exercida")]
        public string FuncaoExercida { get; set; }

        [Display(Name = "Resumo da Função")]
        public string ResumoFuncao { get; set; }

        [Display(Name = "Cargo Pretendido")]
        public string CargoPretendido { get; set; }

        [Display(Name = "Pretensão Salarial")]
        public string PretensaoSalarial { get; set; }

        [Display(Name = "Disponibilida de Viagem")]
        public bool DisponibilidadeViagem { get; set; }

        [Display(Name = "Disponibilidade de Morar Fora")]
        public bool DisponibilidadeMorarFora { get; set; }

        
    }
}
