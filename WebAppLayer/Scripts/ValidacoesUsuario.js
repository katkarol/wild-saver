
var botao = document.querySelector("#Botao");

botao.addEventListener("click", function (event) {
    event.preventDefault();

    ValidarSenha();
    var form = document.querySelector(".form-horizontal")
    console.log(form);
    var usuario = ObtemUsuarioFormulario(form);
    if (!UsuarioValido(usuario)) {
        return;
    }
});
function ValidarSenha() {
    var erro = document.querySelector("#SenhaDanger");
    var Rerro = document.querySelector("#RepitaSenhaDanger");
    erro.innerHTML = "";
    Rerro.innerHTML = "";

    var Senha = document.querySelector("#Senha");
    var RSenha = document.querySelector("#txtRepitaSenha");
    if (Senha.value.length < 8) {
        erro.textContent = "A senha deve conter no mínimo 8 caracteres";
    }
    if (Senha != RSenha) {
        Rerro.textContent = "As senhas não conicidem";
    }
    return Senha;
}
function ObtemUsuarioFormulario(form) {
    
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
