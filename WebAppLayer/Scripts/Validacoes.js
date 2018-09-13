var botao = document.querySelector("#Botao");
AdicionaExemplos()

botao.addEventListener("click", function (event) {
    

    var object = ObtemInformacoesFormulario();
    if (!ValidacaoCampos(object)) {
        event.preventDefault();
        return;
    }
 
});