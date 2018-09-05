var botao = document.querySelector("#Botao");

botao.addEventListener("click", function (event) {
    event.preventDefault();

    var object = ObtemUsuarioFormulario();
    if (!ValidacaoCampos(object)) {
        return;
    }
});