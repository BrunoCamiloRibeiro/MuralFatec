using Microsoft.EntityFrameworkCore;
using MuralFatecDomain.Enitities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuralFatecDal.Data
{
    public class SqlServerData : DbContext
    {
        //private const string conexao = @"Server=(localdb)\MSSQLLocalDB;Database=MuralFatecBd;Trusted_Connection=True;";
        private const string conexao = @"Server=NSL;Database=MuralFatecBd;Integrated Security=True;TrustServerCertificate=True;";
        //configuracao das tabelas do banco de dados
        public DbSet<InstituicaoEntity> Instituicoes { get; set; }
        public DbSet<UsuarioEntity> Usuarios { get; set; }
        public DbSet<ProfessorEntity> Professores { get; set; }
        public DbSet<CursoEntity> Cursos { get; set; }
        public DbSet<DisciplinaEntity> Disciplinas { get; set; }
        public DbSet<MensagemEntity> Mensagens { get; set; }
        public DbSet<AnexoEntity> Anexos { get; set; }
        public DbSet<TagEntity> Tags { get; set; }
        public DbSet<TagMensagemEntity> TagMensagens { get; set; }

        //metodos de configuracao do banco de dados
        public SqlServerData()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //configuracao da conexao com o banco de dados
            optionsBuilder.UseSqlServer(conexao);
            base.OnConfiguring(optionsBuilder);
        }

    }
}
