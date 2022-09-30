function clearAll() {
    var inputs = $("input[type=text]");
    inputs.prop('value', '');

    var inputs = $("input[type=date]");
    inputs.prop('value', '');

    var inputs = $("input[type=radio]");
    inputs.prop('checked', false);
}

function confirmacaoExclusao(evento) {
    if (!confirm("Realmente deseja excluir?")) {
        evento.preventDefault();
    }
}

$(document).ready(function () {
    $("#tbl-clientes").DataTable({
        "ordering": false,
        "paging": true,
        "searching": true,
        "oLanguage": {
            "sEmptyTable": "Nenhum registro encontrado",
            "sInfo": "_START_ até _END_ de _TOTAL_ registros",
            "sInfoEmpty": "0 registros",
            "sInfoFiltered": "(Filtro de _MAX_ registros)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "Mostrar _MENU_ registros por página",
            "sLoadingRecords": "Carregando...",
            "sProcessing": "Processando...",
            "sZeroRecords": "Nenhum registro encontrado",
            "sSearch": "Pesquisar: ",
            "oPaginate": {
                "sNext": "Próximo",
                "sPrevious": "Anterior",
                "sFirst": "Primeiro",
                "sLast": "Último"
            }
        }
    });
});

