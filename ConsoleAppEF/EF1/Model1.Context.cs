﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SI2_Fase2Entities : DbContext
    {
        public SI2_Fase2Entities()
            : base("name=SI2_Fase2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Aluno> Alunos { get; set; }
        public virtual DbSet<Curso> Cursoes { get; set; }
        public virtual DbSet<Curso_Dep> Curso_Dep { get; set; }
        public virtual DbSet<Departamento> Departamentoes { get; set; }
        public virtual DbSet<Escola> Escolas { get; set; }
        public virtual DbSet<Inscricao> Inscricaos { get; set; }
        public virtual DbSet<Matricula> Matriculas { get; set; }
        public virtual DbSet<NotaFinal> NotaFinals { get; set; }
        public virtual DbSet<Nota> Notas { get; set; }
        public virtual DbSet<Oferta> Ofertas { get; set; }
        public virtual DbSet<Pessoa> Pessoas { get; set; }
        public virtual DbSet<Professor> Professors { get; set; }
        public virtual DbSet<Registo_Prof_Ano> Registo_Prof_Ano { get; set; }
        public virtual DbSet<Registo_Regente_Ano> Registo_Regente_Ano { get; set; }
        public virtual DbSet<Seccao> Seccaos { get; set; }
        public virtual DbSet<UC> UCs { get; set; }
    
        public virtual ObjectResult<sp_Catch_errors_Result> sp_Catch_errors()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Catch_errors_Result>("sp_Catch_errors");
        }
    
        public virtual int sp_createCurso(string dep_sigla, string cur_sigla, string descricao)
        {
            var dep_siglaParameter = dep_sigla != null ?
                new ObjectParameter("dep_sigla", dep_sigla) :
                new ObjectParameter("dep_sigla", typeof(string));
    
            var cur_siglaParameter = cur_sigla != null ?
                new ObjectParameter("cur_sigla", cur_sigla) :
                new ObjectParameter("cur_sigla", typeof(string));
    
            var descricaoParameter = descricao != null ?
                new ObjectParameter("descricao", descricao) :
                new ObjectParameter("descricao", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_createCurso", dep_siglaParameter, cur_siglaParameter, descricaoParameter);
        }
    
        public virtual ObjectResult<sp_deleteDepartamento_Result> sp_deleteDepartamento(string sigla)
        {
            var siglaParameter = sigla != null ?
                new ObjectParameter("sigla", sigla) :
                new ObjectParameter("sigla", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_deleteDepartamento_Result>("sp_deleteDepartamento", siglaParameter);
        }
    
        public virtual ObjectResult<sp_deleteOferta_Result> sp_deleteOferta(string curso, string uc)
        {
            var cursoParameter = curso != null ?
                new ObjectParameter("curso", curso) :
                new ObjectParameter("curso", typeof(string));
    
            var ucParameter = uc != null ?
                new ObjectParameter("uc", uc) :
                new ObjectParameter("uc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_deleteOferta_Result>("sp_deleteOferta", cursoParameter, ucParameter);
        }
    
        public virtual ObjectResult<sp_deleteSeccao_Result> sp_deleteSeccao(string sigla)
        {
            var siglaParameter = sigla != null ?
                new ObjectParameter("sigla", sigla) :
                new ObjectParameter("sigla", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_deleteSeccao_Result>("sp_deleteSeccao", siglaParameter);
        }
    
        public virtual ObjectResult<sp_deleteUC_Result> sp_deleteUC(string sigla)
        {
            var siglaParameter = sigla != null ?
                new ObjectParameter("sigla", sigla) :
                new ObjectParameter("sigla", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_deleteUC_Result>("sp_deleteUC", siglaParameter);
        }
    
        public virtual ObjectResult<sp_GetParams_Result> sp_GetParams(string sp)
        {
            var spParameter = sp != null ?
                new ObjectParameter("sp", sp) :
                new ObjectParameter("sp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetParams_Result>("sp_GetParams", spParameter);
        }
    
        public virtual ObjectResult<sp_GetSpecifics_Result> sp_GetSpecifics()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetSpecifics_Result>("sp_GetSpecifics");
        }
    
        public virtual ObjectResult<sp_insertDepartamento_Result> sp_insertDepartamento(string sigla, string descricao)
        {
            var siglaParameter = sigla != null ?
                new ObjectParameter("sigla", sigla) :
                new ObjectParameter("sigla", typeof(string));
    
            var descricaoParameter = descricao != null ?
                new ObjectParameter("descricao", descricao) :
                new ObjectParameter("descricao", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_insertDepartamento_Result>("sp_insertDepartamento", siglaParameter, descricaoParameter);
        }
    
        public virtual ObjectResult<sp_insertInscricao_Result> sp_insertInscricao(Nullable<int> aluno, string uc, Nullable<int> ano)
        {
            var alunoParameter = aluno.HasValue ?
                new ObjectParameter("aluno", aluno) :
                new ObjectParameter("aluno", typeof(int));
    
            var ucParameter = uc != null ?
                new ObjectParameter("uc", uc) :
                new ObjectParameter("uc", typeof(string));
    
            var anoParameter = ano.HasValue ?
                new ObjectParameter("ano", ano) :
                new ObjectParameter("ano", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_insertInscricao_Result>("sp_insertInscricao", alunoParameter, ucParameter, anoParameter);
        }
    
        public virtual ObjectResult<sp_insertMatricula_Result> sp_insertMatricula(Nullable<int> aluno, string curso, Nullable<int> ano)
        {
            var alunoParameter = aluno.HasValue ?
                new ObjectParameter("aluno", aluno) :
                new ObjectParameter("aluno", typeof(int));
    
            var cursoParameter = curso != null ?
                new ObjectParameter("curso", curso) :
                new ObjectParameter("curso", typeof(string));
    
            var anoParameter = ano.HasValue ?
                new ObjectParameter("ano", ano) :
                new ObjectParameter("ano", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_insertMatricula_Result>("sp_insertMatricula", alunoParameter, cursoParameter, anoParameter);
        }
    
        public virtual ObjectResult<sp_insertNota_Result> sp_insertNota(Nullable<int> aluno, Nullable<int> ano, Nullable<double> nota, string uc)
        {
            var alunoParameter = aluno.HasValue ?
                new ObjectParameter("aluno", aluno) :
                new ObjectParameter("aluno", typeof(int));
    
            var anoParameter = ano.HasValue ?
                new ObjectParameter("ano", ano) :
                new ObjectParameter("ano", typeof(int));
    
            var notaParameter = nota.HasValue ?
                new ObjectParameter("nota", nota) :
                new ObjectParameter("nota", typeof(double));
    
            var ucParameter = uc != null ?
                new ObjectParameter("uc", uc) :
                new ObjectParameter("uc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_insertNota_Result>("sp_insertNota", alunoParameter, anoParameter, notaParameter, ucParameter);
        }
    
        public virtual ObjectResult<sp_insertOferta_Result> sp_insertOferta(string curso, string uc, Nullable<int> semestre)
        {
            var cursoParameter = curso != null ?
                new ObjectParameter("curso", curso) :
                new ObjectParameter("curso", typeof(string));
    
            var ucParameter = uc != null ?
                new ObjectParameter("uc", uc) :
                new ObjectParameter("uc", typeof(string));
    
            var semestreParameter = semestre.HasValue ?
                new ObjectParameter("semestre", semestre) :
                new ObjectParameter("semestre", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_insertOferta_Result>("sp_insertOferta", cursoParameter, ucParameter, semestreParameter);
        }
    
        public virtual ObjectResult<sp_insertSeccao_Result> sp_insertSeccao(string sigla, string departamento, string descricao)
        {
            var siglaParameter = sigla != null ?
                new ObjectParameter("sigla", sigla) :
                new ObjectParameter("sigla", typeof(string));
    
            var departamentoParameter = departamento != null ?
                new ObjectParameter("departamento", departamento) :
                new ObjectParameter("departamento", typeof(string));
    
            var descricaoParameter = descricao != null ?
                new ObjectParameter("descricao", descricao) :
                new ObjectParameter("descricao", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_insertSeccao_Result>("sp_insertSeccao", siglaParameter, departamentoParameter, descricaoParameter);
        }
    
        public virtual ObjectResult<sp_insertUC_Result> sp_insertUC(string sigla, string descricao, Nullable<double> creditos)
        {
            var siglaParameter = sigla != null ?
                new ObjectParameter("sigla", sigla) :
                new ObjectParameter("sigla", typeof(string));
    
            var descricaoParameter = descricao != null ?
                new ObjectParameter("descricao", descricao) :
                new ObjectParameter("descricao", typeof(string));
    
            var creditosParameter = creditos.HasValue ?
                new ObjectParameter("creditos", creditos) :
                new ObjectParameter("creditos", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_insertUC_Result>("sp_insertUC", siglaParameter, descricaoParameter, creditosParameter);
        }
    
        public virtual ObjectResult<sp_updateDepartamento_Result> sp_updateDepartamento(Nullable<int> id, string sigla, string descricao)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var siglaParameter = sigla != null ?
                new ObjectParameter("sigla", sigla) :
                new ObjectParameter("sigla", typeof(string));
    
            var descricaoParameter = descricao != null ?
                new ObjectParameter("descricao", descricao) :
                new ObjectParameter("descricao", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_updateDepartamento_Result>("sp_updateDepartamento", idParameter, siglaParameter, descricaoParameter);
        }
    
        public virtual ObjectResult<sp_updateSeccao_Result> sp_updateSeccao(Nullable<int> id, string sigla, string descricao, string departamento)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var siglaParameter = sigla != null ?
                new ObjectParameter("sigla", sigla) :
                new ObjectParameter("sigla", typeof(string));
    
            var descricaoParameter = descricao != null ?
                new ObjectParameter("descricao", descricao) :
                new ObjectParameter("descricao", typeof(string));
    
            var departamentoParameter = departamento != null ?
                new ObjectParameter("departamento", departamento) :
                new ObjectParameter("departamento", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_updateSeccao_Result>("sp_updateSeccao", idParameter, siglaParameter, descricaoParameter, departamentoParameter);
        }
    
        public virtual ObjectResult<sp_updateUC_Result> sp_updateUC(Nullable<int> id, string sigla, string descricao, string creditos)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var siglaParameter = sigla != null ?
                new ObjectParameter("sigla", sigla) :
                new ObjectParameter("sigla", typeof(string));
    
            var descricaoParameter = descricao != null ?
                new ObjectParameter("descricao", descricao) :
                new ObjectParameter("descricao", typeof(string));
    
            var creditosParameter = creditos != null ?
                new ObjectParameter("creditos", creditos) :
                new ObjectParameter("creditos", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_updateUC_Result>("sp_updateUC", idParameter, siglaParameter, descricaoParameter, creditosParameter);
        }
    }
}