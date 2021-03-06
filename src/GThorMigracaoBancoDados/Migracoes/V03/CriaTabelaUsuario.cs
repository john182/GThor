﻿using FluentMigrator;

namespace GThorMigracaoBancoDados.Migracoes.V03
{
    [Migration(3)]
    public class CriaTabelaUsuario : Migration
    {
        public override void Up()
        {
            Create.Table("usuario")
                .WithColumn("id")
                .AsInt32()
                .PrimaryKey()
                .Identity()
                .WithColumn("login")
                .AsString(20)
                .NotNullable()
                .WithColumn("senha")
                .AsString(40)
                .NotNullable();
        }

        public override void Down()
        {
            Delete.Table("usuario");
        }
    }
}