function ExportaParaExcel(id, nome) { //id da <table> e nome do arquivo a ser gerado
    var hoje = new Date();
    var data = ('0' + hoje.getDate()).slice(-2) + "-" + ('0' + (hoje.getMonth() + 1)).slice(-2) + "-" + hoje.getFullYear();
    var nome_arquivo = nome + "_" + data + ".xls"; //nome final do arquivo
    var meta = '<meta http-equiv="content-type" content="text/html; charset=UTF-8" />';
    var html = $("#" + id).clone();/*Faz o clone do documento, que no caso é a tabela*/
    html.find('.remove').remove();/*Remove tudo que está vinculado com a classe desejada*/
    html.find('a').each(function () { /*Pega toda a tag do link*/
        var txt = $(this).text();/*Pega o texto e armazena em "txt"*/
        $(this).after(txt).remove(); /*Insere após o objeto, logo em seguida apaga o mesmo objetos*/
    });
    html.find('input, textarea').each(function () {
        var txt = $(this).val().replace(/\r\n|\r|\n/g, "<br>");/*substitui os caracteres mostrados por "<br>"*/

        $(this).after(txt).remove();/*Insere após o objeto, logo em seguida apaga o mesmo objetos*/
    });
    html.find('select').each(function () {

        var txt = $(this).find('option:selected').text();/*Pega a opção que está selecionada*/
        $(this).after(txt).remove();/*Insere após o objeto, logo em seguida apaga o mesmo objetos*/

    });

    html.find('br').attr('style', "mso-data-placement:same-cell");
    html = "<table>" + html.html() + "</table>";
    var uri = 'data:application/vnd.ms-excel,' + encodeURIComponent(meta + html);
    var a = $("<a>", {
        href: uri,
        download: nome_arquivo
    });
    $(a)[0].click();
}