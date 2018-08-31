﻿var botao = document.querySelector("#Botao");

botao.addEventListener("click", function (event) {
    event.preventDefault();
    alert("Oi");
    Console.log("12");

    ValidarSenha();
    var form = document.querySelector(".form-horizontal")
    var usuario = ObtemUsuarioFormulario(form);
    if (!UsuarioValido(usuario)) {
        return;
    }
});
function ValidarSenha() {
    var Senha = document.querySelector("#txtSenha");
    var RSenha = document.querySelector("#txtRepitaSenha");
    if (Senha.lenght < 8) {
        var erro = document.querySelector("#SenhaDanger");
        erro.textContent = "A senha deve conter no mínimo 8 caracteres";
    }
    if (Senha != RSenha) {
        var erro = document.querySelector("#RepitaSenhaDanger");
        erro.textContent = "As senhas não conicidem";
    }
    return Senha;
}
function ObtemUsuarioFormulario(form) {
    var usuario = {
        nome: form.nome.value,
        datanascimento: form.datanascimento.value,
        cpf: form.cpf.value,
        email: form.email.value,
        cep: form.cep.value,
        rua: form.numero.value,
        bairro: form.bairro.value,
        cidade: form.cidade.value,
        uf: form.uf.value,
        pais: form.pais.value,
        login: form.login.value,
        senha: ValidarSenha()
    }
    return usuario;
}
function UsuarioValido(usuario) {
    var erros = document.querySelectorAll(".text-danger");
    if (!NomeValido(usuario.nome)) {
        erro[0] = "Nome inváido";
    }
    if (!DataNascimentoValido(usuario.datanascimento)) {
        erro[1] = "Data de nascimento inválido";
    }
    if (!CpfValido(usuario.cpf)) {
        erro[2] = "CPF inválido";
    }
    if (!CEPValido(usuario.cep)) {
        erro[3] = "CEP inválido";
    }
    if (!NumeroValido(usuario.numero)) {
        erro[4] = "Numero Reseidencial inválido";
    }
    if (!RuaValido(usuario.rua)) {
        erro[5] = "Rua inválida";
    }
    if (!BairroValido(usuario.bairro)) {
        erro[6] = "Bairro inválido";
    }
    if (!CidadeValida(usuario.cidade)) {
        erro[7] = "Cidade inválida"
    }
    if (!UFValido(usuario.uf)) {
        erro[8] = "UF deve conter somente 2 caracteres";
    }
    if (!EmailValido(usuario.email)) {
        erro[9] = "Email inválido";
    }
    for (var i = 0; i < erros.length; i++) {
        if (erros[i] != "") {
            return false;
        } 
    }
    return true;

}
