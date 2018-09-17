function NomeValido(nome) {
    if (nome.length < 3 || nome > 30) {
        return false;
    }
    return true;
}

function NomePopularValido(nomePopular) {
    if (nomePopular < 3 || nomePopular > 40) {
        return false;
    }
    return true;
}