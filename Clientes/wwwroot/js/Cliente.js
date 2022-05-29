var datatable;

$(document).ready(function () {
    loadDataTable();



    function LoadDatable() {
        datatable = $('#tblData').DataTable({
            "ajax": {
                "url:": "/Cliente/ObtenerTodos"
            },
            "Columns": [

                { "data": "nombre", "width": "10 %" },
                { "data": "cedula", "width": "10 %" },
                { "data": "telefono", "width": "10 %" },
                { "data": "direccion", "width": "10 %" },
                {
                    "data": "estado", "render": function (data) {
                        if (data == true) {
                            return "Activo"
                        }
                        else {
                            return "Inactivo";
                        }

                    }, "width": "20%",

                }

            ]
        })
    }
})