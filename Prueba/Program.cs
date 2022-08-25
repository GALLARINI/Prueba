using Prueba;

var alumno = new Alumno();

alumno.Legajo = 899238;
alumno.Apellido = "Gallarini";
alumno.Nombre = "Francisco";
alumno.FechaDeNacimiento = new DateTime(1999, 12, 22);

var materia = new Materia();


alumno.AnotarseA(materia);

var edad = alumno.CalcularEdadEnAños();