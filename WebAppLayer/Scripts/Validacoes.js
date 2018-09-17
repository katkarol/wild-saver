var botao = document.querySelector("#Botao");

botao.addEventListener("click", function (event) {
    

    var object = ObtemInformacoesFormulario();
    if (!ValidacaoCampos(object)) {
        event.preventDefault();
        return;
    }
 
});