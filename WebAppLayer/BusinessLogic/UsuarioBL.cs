﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.DAL;
using WebAppLayer.Models;
using WebAppLayer.Models.Enums;

namespace WebAppLayer.BusinessLogic
{
    public class UsuarioBL
    {
        public static void AdicionarConta(Usuario usuario)
        {
            usuario.PessoaUsuaria.CPF = usuario.PessoaUsuaria.CPF.Replace(".", "").Replace("-", "");
            usuario.PessoaUsuaria.Endereco.CEP = usuario.PessoaUsuaria.Endereco.CEP.Replace("-", "");
            if (usuario.PessoaUsuaria.CPF.Length != 11)
            {
                throw new Exception("CPF Inválido! Tente novamente");

            }
            if (usuario.PessoaUsuaria.Endereco.CEP.Length != 8)
            {
                throw new Exception("CEP Inválido!");

            }
            if (usuario.PapelUsuario == PapelUsuario.Usuario && usuario.PessoaUsuaria.DataNascimento > DateTime.Now.AddYears(-14))
            {
                throw new Exception("Idade Inválida! Para se cadastrar deve ser maior de 14 anos.");
            }
            else if (usuario.PessoaUsuaria.DataNascimento > DateTime.Now.AddYears(-18) && usuario.PapelUsuario == PapelUsuario.Funcionario)
            {
                throw new Exception("Idade Inválida! Para cadastrar funcionario deve ser maior de 18 anos.");
            }
            if (UsuarioDAL.ExisteLogin(usuario.Login ) != 0)
            {
                throw new Exception("Usuário login já existe");
            }
            UsuarioDAL.Adicionar(usuario);

        }
        public static void ValidacoesLogin(Usuario usuario)
        {
            Usuario u = UsuarioDAL.BuscarUsuarioSenha(usuario);
            if (u.Login != usuario.Login)
            {
                throw new Exception("O usuario e/ou a senha estão incorretos");
            }
            if (u.Senha != usuario.Senha)
            {
                throw new Exception("O usuario e/ou a senha estão incorretos");
            }
            HttpContext.Current.Session["USUARIO"] = "nomeDoUsuario";
            HttpContext.Current.Session["SENHA"] = "senha";
        }
    }
}