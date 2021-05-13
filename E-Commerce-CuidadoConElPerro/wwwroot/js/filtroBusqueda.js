$(document).ready(function () {
    $('#example').DataTable({
        language: {
            processing: "En proceso",
            search: "Buscar",
            lengthMenu: "Agrupar de _MENU_ ítems",
            info: "Mostrando del ítem  _START_ al _END_ de un total de_TOTAL_ ítems",
            infoEmpty: "No existen datos",
            infoFiltered: "(Filtrado de _MAX_ elementos en total)",
            infoPostFix: "",
            loadingRecords: "Cargando...",
            zeroRecords: "No se encontraron datos con tu busqueda",
            emptyTable: "No hay datos disponibles en la tabla",
            paginate: {
                first: "Primero",
                previous: "Anterior",
                next: "Siguiente",
                last: "Ultimo"
            },
            aria: {
                sortAscending: ": Ascendente",
                sortDescending: ": Descendente"
            }
        },
        scrollY: 400,
        lengthMenu: [[10, 25, -1], [10, 25, "All"]],
    });
});