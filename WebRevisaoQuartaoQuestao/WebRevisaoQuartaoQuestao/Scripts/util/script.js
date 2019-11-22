$(document).ready(function () {
    $('input[name="botao"]').click(function () {
        var nome = $('input[name="nome"]').val();
        var idade = $('input[name="idade"]').val();
        if (idade < 18) {
            alert("Senhor, " + nome + ", o sistema não aceita menores de idade!");
            window.location = "http://www.tirol.com.br";
        }
        else {
            alert("Senhor, " + nome + ", seja bem-vindo à cervejaria ambev");
            window.location = "http://www.ambev.com.br";
        }
    });
});