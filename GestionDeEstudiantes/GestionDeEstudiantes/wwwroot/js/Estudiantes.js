$.ajaxSetup  // ESTO SE COLOCA POR TEMA DE SEGURIDAD, PARA EVITAR QUE SE ENVIEN DATOS DESDE UN FORMULARIO QUE NO ESTE EN MI PAGINA WEB
    ({
        data:
        {
            __RequestVerificationToken: document.getElementsByName(
                "__RequestVerificationToken"
            )[0].value
        }

    });

// GUARDA Y VALIDA MI FORMULARIO
async function salvar() {
    alert("di click");

    var form = $("#FormEstudiante").dxForm("instance");

    var validationResults = form.validate();
    var valido = validationResults.isValid;

    if (valido) {
        alert("formulario valido");
        var data = form.option("formData");
        EnviarServidor(data);
        console.log(data);
    } else {
        alert("no sirvió");
    }
}



async function EnviarServidor(dataformulario)    //Esta funcion va a permitir hacer una peticion al servidor
{
    try  //se coloca por si sucede algun error inesperado
    {
        var respuesta = await $.ajax
            ({
                method: "POST",  //le pasamos el metodo que vamos a usar
                url: "/Estudiantes?handler=CrearEstudiante", //la url
                data: dataformulario // y la data que va a enviar
            });

        alert("usuario agregado");
        var form = $("#FormEstudiante").dxForm("instance").resetValues();
    }
    catch (error) {
        alert("algo salio mal");
    }




}