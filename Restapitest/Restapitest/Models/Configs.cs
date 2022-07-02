using System;
using System.Collections.Generic;
using System.Text;

namespace Restapitest.Models
{
    public class Configs
    {
        //ADDRESS
        public static String ipaddress = "192.168.0.10:8887"; //IP publica o privada para trabajar local 
        public static String carpeta = "pm02";
        //RUTAS
        public static String setAlumno = "Crear.php";
        public static String setUpdateAlumno = "actualizarAlumno.php";
        public static String deleteAlumno = "eliminaAlumno.php";
        public static String getListadoAlumos = "listadoAlumnos.php";
        public static String getCarrera = "listadoCarreras.php";

        //FORMATOS DE URL
        public static String webUrl = "http://{0}/{1}/{2}";
        //ENDPOINT
        public static String apiGetList = string.Format(webUrl,ipaddress,carpeta,getListadoAlumos);
        public static String apiSetAlumno = string.Format(webUrl, ipaddress, carpeta, setAlumno);
        public static String apiSetUpdateAlumno = string.Format(webUrl, ipaddress, carpeta, setUpdateAlumno);
        public static String apiDeleteAlumno = string.Format(webUrl, ipaddress, carpeta, deleteAlumno);
        public static String apigetCarreras = string.Format(webUrl, ipaddress, carpeta, getCarrera);
    }
}
