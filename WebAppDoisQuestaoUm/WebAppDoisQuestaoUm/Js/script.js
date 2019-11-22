$(document).ready(function () {
    $('input[name="botao"]').click(function () {
        var nome = $('input[name="nome"]').val();
        $('span[name="nomeModal"]').text(nome);
    });
});