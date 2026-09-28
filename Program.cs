Console.WriteLine("Inicio del Programa");

//VARIABLES
int dia_m=0, dia_s=0, mes=0;
string MES, SEMANA; //NOTA AL PROFESOR: El error de Enum era porque las variables 
                    //NUMERO_S y NUMERO_MES se declaraban aqui como string y como
                    //Enum mas abajo, tambien el Enum.GetNames no era necesario, bastaba
                    //simplemente con igualar la variable tipo Enum al Console.Readline
                    //y cambiar el nombre de la variables para que no chocoran. ESO ERA TO.




Console.WriteLine("\nSECUENCIA DE IF");
//ENTRADA DE DATOS
Console.WriteLine("Ingrese el dia del mes:");
dia_m = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Ingrese el numero del dia de la semana:");
dia_s = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el numero del mes:");
mes = Convert.ToInt32(Console.ReadLine());

//DIA DE LA SEMANA

    if (dia_s == 1){
    SEMANA = "Lunes";

}else if(dia_s == 2){
    SEMANA = "Martes";

}else if(dia_s == 3){
    SEMANA = "Miercoles";

}else if(dia_s == 4){
    SEMANA = "Jueves";

}else if(dia_s == 5){
    SEMANA = "Viernes";

}else if(dia_s == 6){
    SEMANA = "Sabado";

}else if(dia_s == 7){
    SEMANA = "Domingo";

} else{
    SEMANA = "Valor_Invalido";
}

//DIA DEL MES

    if (mes == 1){
    MES = "Enero";

}else if(mes == 2){
    MES = "Febrero";

}else if(mes == 3){
    MES = "Marzo";

}else if(mes == 4){
    MES = "Abril";

}else if(mes == 5){
    MES = "Mayo";

}else if(mes == 6){
    MES = "Junio";

}else if(mes == 7){
    MES = "Julio";

}else if(mes == 8){
    MES = "Agosto";

}else if(mes == 9){
    MES = "Septiembre";

}else if(mes == 10){
    MES = "Octubre";

}else if(mes == 11){
    MES = "Noviembre";

}else if(mes == 12){
    MES = "Diciembre";

} else{
    MES = "Valor_Invalido";
}

//SALIDA IF
Console.WriteLine($"Hoy es {SEMANA}, {dia_m} de {MES} del 2026");




Console.WriteLine("\nSECUENCIA DE SWITCH CASE");
//ENTRADA DE DATOS
Console.WriteLine("Ingrese el dia del mes:");
dia_m = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Ingrese el numero del dia de la semana:");
dia_s = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el numero del mes:");
mes = Convert.ToInt32(Console.ReadLine());

switch (dia_s)
{
    case 1:
    SEMANA = "Lunes";
    break;

    case 2:
    SEMANA = "Martes";
    break;
    
    case 3:
    SEMANA = "Miercoles";
    break;
    
    case 4:
    SEMANA = "Jueves";
    break;

    case 5:
    SEMANA = "Viernes";
    break;
    
    case 6:
    SEMANA = "Sabado";
    break;
    
    case 7:
    SEMANA = "Domingo";
    break;

    default:
    SEMANA = "Dia Invalido";
    break;
}

switch (mes)
{
    case 1:
    MES = "Enero";
    break;

    case 2:
    MES = "Febrero";
    break;

    case 3:
    MES = "Marzo";
    break;

    case 4:
    MES = "Abril";
    break;

    case 5:
    MES = "Mayo";
    break;

    case 6:
    MES = "Junio";
    break;

    case 7:
    MES = "Julio";
    break;

    case 8:
    MES = "Agosto";
    break;

    case 9:
    MES = "Septiembre";
    break;

    case 10:
    MES = "Octubre";
    break;

    case 11:
    MES = "Novimbre";
    break;

    case 12:
    MES = "Diciembre";
    break;

    default:
    MES = "Mes Invalido";
    break;
}



//SALIDA SWITCH CASE
Console.WriteLine($"Hoy es {SEMANA}, {dia_m} de {MES} del 2026");


Console.WriteLine("\nSECUENCIA DE ENUM");
//ENTRADA DE DATOS
Console.WriteLine("Ingrese el dia del mes:");
dia_m = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Ingrese el numero del dia de la semana:");
E_SEMANA diaEnum = (E_SEMANA)Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el numero del mes:");
E_MES mesEnum = (E_MES)Convert.ToInt32(Console.ReadLine());

//ESO NO ERA NECESARIA
//string [] nombres_1 = Enum.GetNames(typeof(E_SEMANA));
//string [] nombres_2 = Enum.GetNames(typeof(E_MES));


//SALIDA SWITCH ENUM
Console.WriteLine($"Hoy es {diaEnum}, {dia_m} de {mesEnum} del 2026");

public enum E_SEMANA
{
    Lunes = 1,
    Martes = 2,
    Miercoles =3,
    Jueves = 4,
    Viernes = 5,
    Sabado = 6,
    Domingo = 7
}

public enum E_MES
{
    Enero = 1,
    Febrero = 2,
    Marzo =3,
    Abril = 4,
    Mayo = 5,
    Junio = 6,
    Julio = 7,
    Agosto = 8,
    Septiembre = 9,
    Octubre = 10,
    Noviembre = 11,
    Diciembre = 12
}
