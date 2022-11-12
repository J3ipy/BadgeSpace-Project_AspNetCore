﻿using Domain.Argumentos.Estudante;
using Domain.Argumentos.Usuario;
using Domain.Entidades.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entidades.Estudante
{
    public class Estudante : EntidadeBase
    {
        public string Nome { get; private set; }

        public string CPF { get; private set; }

        public string Codigo { get; private set; }

        public string Curso { get; private set; }

        public string Tipo { get; private set; }

        public string Nivel { get; private set; }

        public string Tempo { get; private set; }

        public byte[]? Imagem { get; private set; }

        public string Descricao { get; private set; }

        [ForeignKey("Empresa")]
        public int EmpresaId { get; private set; }

        public Domain.Entidades.Usuario.Usuario? Empresa { get; private set; }

        public Estudante() { }

        public Estudante(EstudanteRequest request)
        {
            Nome = request.Nome;
            CPF = request.CPF;
            Codigo = request.Codigo;
            Curso = request.Curso;
            Imagem = request.Imagem;
            Tipo = request.Tipo;
            Nivel = request.Nivel;
            Tempo = request.Tempo;
            Descricao = request.Descricao;
            Empresa = request.Empresa;
            Status = true;
        }

        public void Atualizar(EstudanteRequest request)
        {
            Nome = request.Nome;
            CPF = request.CPF;
            Codigo = request.Codigo;
            Curso = request.Curso;
            Imagem = request.Imagem;
            Tipo = request.Tipo;
            Nivel = request.Nivel;
            Tempo = request.Tempo;
            Descricao = request.Descricao;
            Empresa = request.Empresa;

            if (request.Status.HasValue) Status = request.Status.Value;
        }
    }
}
