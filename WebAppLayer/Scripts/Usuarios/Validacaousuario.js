
function ObtemInformacoesFormulario() {
    var usuario = {
        nome: document.querySelector("#PessoaUsuaria_NomeCompleto").value,
        datanascimento: document.querySelector("#datetimepicker4").value,
        cpf: document.querySelector("#PessoaUsuaria_CPF").value,
        cep: document.querySelector("#PessoaUsuaria_Endereco_CEP").value,
        numero: document.querySelector("#PessoaUsuaria_Endereco_Numero").value,
        rua: document.querySelector("#PessoaUsuaria_Endereco_Rua").value,
        bairro: document.querySelector("#PessoaUsuaria_Endereco_Bairro").value,
        cidade: document.querySelector("#PessoaUsuaria_Endereco_Cidade").value,
        uf: document.querySelector("#PessoaUsuaria_Endereco_UF").value,
        email: document.querySelector("#PessoaUsuaria_Email").value,
        login: document.querySelector("#Login").value,
       senha:  document.querySelector("#Senha").value,
       RSenha = document.querySelector("#Repita_Senha").value
    }
    return usuario;
}
function ValidacaoCampos(usuario) {

    var erros = document.querySelectorAll(".text-danger");
    for (var i = 0; i < erros.length; i++) {
        erros[i].innerHTML = "";

        if (!NomeValido(usuario.nome)) {
            erros[0].textContent = "Nome inváido";
        }

        if (!CpfValido(usuario.cpf || isNumber(usuario.cpf))) {
            erros[2].textContent = "CPF inválido";
        }
        if (!CEPValido(usuario.cep)) {
            erros[3].textContent = "CEP inválido";
        }
        if (!NumeroValido(usuario.numero)) {
            erros[4].textContent = "Numero Reseidencial inválido";
        }
        if (!RuaValida(usuario.rua)) {
            erros[5].textContent = "Rua inválida";
        }
        if (!BairroValido(usuario.bairro)) {
            erros[6].textContent = "Bairro inválido";
        }
        if (!CidadeValida(usuario.cidade)) {
            erros[7].textContent = "Cidade inválida"
        }
        if (!UFValido(usuario.uf)) {
            erros[8].textContent = "UF deve conter somente 2 caracteres";
        }
        if (!SenhaValida(usuario.senha)) {
            erros[12].textContent = "A senha deve conter no mínimo 6 caracteres";
        }
        if (!SenhaCoincidentes(usuario.senha , usuario.RSenha)) {
            erros[13].textContent = "As senhas não conicidem";

        }
        

    }
    for (var i = 0; i < erros.length; i++) {
        if (erros[i].textContent != "") {
            return false;
        }
    }

    return true;

}

