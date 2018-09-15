function ValidarSenha() {
    var erro = document.querySelector("#SenhaDanger");
    var Rerro = document.querySelector("#RepitaSenhaDanger");
    erro.innerHTML = "";
    Rerro.innerHTML = "";

    var Senha = document.querySelector("#Senha").value;
    var RSenha = document.querySelector("#Repita_Senha").value;
    if (Senha.length < 6) {
        erro.textContent = "A senha deve conter no mínimo 6 caracteres";
    }
    if (Senha != RSenha) {
        Rerro.textContent = "As senhas não conicidem";
    }
    return Senha;
}
function NomeValido(nome) {
    if (nome.length < 5 || nome.length > 60) {
        return false;
    }
    return true;
}
function DataNascimentoValido(datanascimento) {

    return true;
}
function CpfValido(cpf) {
    if (cpf.length != 14) {
        return false;
    }
   
    return true;
}
function isNumber(n) {
    return !isNaN(parseFloat(n)) && isFinite(n);
}

function CEPValido(cep) {
    if (cep.length != 9) {
        return false;
    }
    return true;
}
function NumeroValido(numero) {
    if (numero.length > 7) {
        return false;
    }
    return true;
}
function RuaValida(rua) {
    if (rua.length < 3 || rua.length > 60) {
        return false;
    }
    return true;
}
function BairroValido(bairro) {
    if (bairro.length < 3 || bairro.length > 30) {
        return false;
    }
    return true;
}
function CidadeValida(cidade) {
    if (cidade.length < 5 || cidade.length > 30) {
        return false;
    }
    return true;
}
function UFValido(uf) {
    if (uf.length != 2) {
        return false;
    }
    return true;
}
function EmailValido(email) {
    usuario = email.value.substring(0, email.value.indexOf("@"));
    dominio = email.value.substring(email.value.indexOf("@") + 1, email.value.length);

    if ((usuario.length >= 1) &&
        (dominio.length >= 3) &&
        (usuario.search("@") == -1) &&
        (dominio.search("@") == -1) &&
        (usuario.search(" ") == -1) &&
        (dominio.search(" ") == -1) &&
        (dominio.search(".") != -1) &&
        (dominio.indexOf(".") >= 1) &&
        (dominio.lastIndexOf(".") < dominio.length - 1)) {
        return true;
    }
    else {
        return false;
    }
}

function AdicionaExemplos() {
    var cpf = $("#PessoaUsuaria_CPF");

    cpf.on("input", function () {
        var exemplo = $("#ExemploCpf").text;
        exemplo = "Exemplo: 000.000.000-00";
    });
}

