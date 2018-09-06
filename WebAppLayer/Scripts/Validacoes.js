var botao = document.querySelector("#Botao");

botao.addEventListener("click", function (event) {
    

    var object = ObtemUsuarioFormulario();
    if (!ValidacaoCampos(object)) {
        event.preventDefault();
        return;
    }
});