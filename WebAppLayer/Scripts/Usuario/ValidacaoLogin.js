function ObtemInformacoesFormulario() {
    var usuario = {
        login: document.querySelector("#Login").value,
        senha: document.querySelector("#Senha").value
    }
    return usuario;
}
function ValidacaoCampos(usuario) {

    var erros = document.querySelectorAll(".text-danger");
    for (var i = 0; i < erros.length; i++) {
        erros[i].innerHTML = "";

        if (usuario.login == 0) {
            erros[0].textContent = "O campo do login deve ser preenchido.";
        }
        if (usuario.senha == 0) {
            erros[1].textContent = "O campo da senha deve ser preenchido."
        }

    }
    for (var i = 0; i < erros.length; i++) {
        if (erros[i].textContent != "") {
            return false;
        }
    }

    return true;

}
