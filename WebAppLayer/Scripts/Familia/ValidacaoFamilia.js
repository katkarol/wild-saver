﻿function ObtemInformacoesFormulario() {
    var Familia = {
        Nome: document.querySelector("#Nome").value,
        NomePopular: document.querySelector("#NomePopular").value,
        Ordem: document.querySelector("#Ordem").value
    }
    return Classe

}
function ValidacaoCampos(classe) {

    var erros = document.querySelectorAll(".text-danger");
    for (var i = 0; i < erros.length; i++) {
        erros[i].innerHTML = "";

        if (!NomeValido(classe.nome)) {
            erros[0].textContent = "Nome inváido";
        }
        if (!NomePopularValido(classe.NomePopular)) {
            erros[1].textContent = "Nome popular inválido";
        }
    }



    for (var i = 0; i < erros.length; i++) {
        if (erros[i].textContent != "") {
            return false;
        }
    }

    return true;

}