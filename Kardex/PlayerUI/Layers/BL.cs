using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Kardex.Layers;

namespace Kardex.Layers
{
    class BL //Buisness Layer
    {
        DAL dal = new DAL();


        /*AQUI EMPIEZA LOS PROCESOS DE CARRERA
         * 
         * 
         * 
         * 
         * 
         * 
         * */
        public DataTable ConsultaCarrera(string carrera)
        {
            
            if (carrera != "")
            {
                
                return dal.ConsultaCarrera(carrera);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para la carrera.", "Alerta", MessageBoxButtons.OK);
                return null;
            }

            
        }

        public void ActualizaCalificacion(int id, string cali, string uni)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            if (cali == "")
            {
                MessageBox.Show("Favor de escoger bien la calificacion a modificar", "Alerta", MessageBoxButtons.OK);

            }
            else
            {

                dal.ActualizaCalificacion(id, cali, uni);//, fechaalta, fechabaja, estatus);
                MessageBox.Show("La calificacion se modifico exitosamente", "Aviso", MessageBoxButtons.OK);

            }
        }

        public DataTable validacarrera(string carrera)
        {

            if (carrera != "")
            {

                return dal.ConsultaCarrera(carrera);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para la carrera.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }
        public DataTable ConsultaCarrerainactivo(string carrera)
        {

            if (carrera != "")
            {

                return dal.ConsultaCarrerainactivo(carrera);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para la carrera.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }


        public DataTable Consultarmainactivo(string carrera)
        {

            if (carrera != "")
            {

                return dal.Consultarmainactivo(carrera);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para la relacion.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }


        public void ReactivarCarrera(string carrera)
        {
            if (carrera != "")
            {

                dal.ReactivarCarrera(carrera);
                MessageBox.Show("La Carrera Se Reactivo Exitosamente", "SIN ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Es necesario selecciona una carrera.", "Alerta", MessageBoxButtons.OK);

            }
        }

        public void ReactivarRelmatalum(string carrera)
        {
            if (carrera != "")
            {

                dal.ReactivarRelmatalum(carrera);
                MessageBox.Show("La realcion Se Reactivo Exitosamente", "SIN ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Es necesario selecciona una relacion.", "Alerta", MessageBoxButtons.OK);

            }
        }

        public void ActualizaCarrera(string carrera, string carreranueva, string fechamodi)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            if (carrera == "")
            {
                MessageBox.Show("Favor de especificar la carrera a modificar", "Alerta", MessageBoxButtons.OK);

            }
            else
            {

                dal.ActualizaCarrera(carrera, carreranueva, fechamodi);//, fechaalta, fechabaja, estatus);
                MessageBox.Show("La carrera se modifico exitosamente", "Aviso", MessageBoxButtons.OK);

            }
        }

        public void AltaCarrera(string carrera, string fecha)
        {
            if (carrera == "")
            {
                MessageBox.Show("Es necesario especificar el nombre de la carrera", "Alerta", MessageBoxButtons.OK);
            }
            else
            {
                if (fecha == "")
                {
                    MessageBox.Show("La fecha de alta no puede ser mayor al dia de hoy", "Alerta", MessageBoxButtons.OK);
                }
                else
                {
                    dal.AltaCarrera(carrera, fecha);
                    MessageBox.Show("La carrera se dio de alta correctamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        public void BajaCarrera(string carrera)
        {
            if (carrera != "")
            {

                dal.BajaCarrera(carrera);
                MessageBox.Show("La Carrera Se Dio De Baja Exitosamente", "SIN ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Es necesario selecciona una carrera.", "Alerta", MessageBoxButtons.OK);

            }
        }

        /*AQUI EMPIEZA LOS PROCESOS DE MATERIA
         * 
         * 
         * 
         * 
         * 
         * 
         * */



        public DataTable ConsultaMateria(string materia)
        {

            if (materia != "")
            {

                return dal.ConsultaMateria(materia);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para la materia.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }

        public DataTable ConsultaMateriainactivo(string carrera)
        {

            if (carrera != "")
            {

                return dal.ConsultaMateriainactivo(carrera);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para la materia.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }

        public DataTable validamateria(string materia)
        {

            if (materia != "")
            {

                return dal.ConsultaMateria(materia);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para la materia.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }

        public void ReactivarMateria(string carrera)
        {
            if (carrera != "")
            {

                dal.ReactivarMateria(carrera);
                MessageBox.Show("La materia Se Reactivo Exitosamente", "SIN ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Es necesario selecciona una materia.", "Alerta", MessageBoxButtons.OK);

            }
        }

        public void AltaMateria(string materia, string fecha)
        {
            if (materia == "")
            {
                MessageBox.Show("Es necesario especificar el nombre de la materia", "Alerta", MessageBoxButtons.OK);

            }
            else
            {
                if (fecha == "")
                {
                    MessageBox.Show("La fecha de alta no puede ser mayor al dia de hoy", "Alerta", MessageBoxButtons.OK);

                }
                else
                {
                    dal.AltaMateria(materia, fecha);
                    MessageBox.Show("La materia se dio de alta correctamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        public void BajaMateria(string materia)
        {
            if (materia != "")
            {

                dal.BajaMateria(materia);
                MessageBox.Show("La Materia Se Dio De Baja Exitosamente", "SIN ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Es necesario selecciona una materia.", "Alerta", MessageBoxButtons.OK);

            }
        }

        public void ActualizaMateria(string materia, string materianueva,string fecha)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            if (materia == "")
            {
                MessageBox.Show("Favor de especificar la materia a modificar", "Alerta", MessageBoxButtons.OK);

            }
            else
            {

                dal.ActualizaMateria(materia, materianueva, fecha);//, fechaalta, fechabaja, estatus);
                MessageBox.Show("La materia se modifico exitosamente", "Aviso", MessageBoxButtons.OK);

            }
        }



        /*AQUI EMPIEZA LOS PROCESOS DE PERIODO
        * 
        * 
        * 
        * 
        * 
        * 
        * */
        public DataTable ConsultaPeriodoinactivo(string carrera)
        {

            if (carrera != "")
            {

                return dal.ConsultaPeriodoinactivo(carrera);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para el periodo.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }

        public DataTable ConsultaPeriodo(string materia)
        {

            if (materia != "")
            {

                return dal.ConsultaPeriodo(materia);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para el periodo.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }

        public DataTable validaperiodo(string periodo)
        {

            if (periodo != "")
            {

                return dal.ConsultaPeriodo(periodo);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor del peroiodo.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }

        public void ReactivarPeriodo(string carrera)
        {
            if (carrera != "")
            {

                dal.ReactivarPeriodo(carrera);
                MessageBox.Show("El periodo Se Reactivo Exitosamente", "SIN ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Es necesario selecciona un periodo.", "Alerta", MessageBoxButtons.OK);

            }
        }

        public void ActualizaPeriodo(string carrera, string carreranueva,string fecha)
        {
            if (carrera == "")
            {
                MessageBox.Show("Favor de especificar el periodo a modificar", "Alerta", MessageBoxButtons.OK);

            }
            else
            {

                dal.ActualizaPeriodo(carrera, carreranueva,fecha);//, fechaalta, fechabaja, estatus);
                MessageBox.Show("El periodo se modifico exitosamente", "Aviso", MessageBoxButtons.OK);

            }
        }

        public void BajaPeriodo(string carrera)
        {
            if (carrera != "")
            {

                dal.BajaPeriodo(carrera);
                MessageBox.Show("El Periodo Se Dio De Baja Exitosamente", "SIN ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Es necesario selecciona un Periodo.", "Alerta", MessageBoxButtons.OK);

            }
        }

        public void AltaPeriodo(string periodo, string fecha)
        {
            if (periodo == "")
            {
                MessageBox.Show("Es necesario especificar el nombre del Periodo", "Alerta", MessageBoxButtons.OK);
            }
            else
            {
                if (fecha == "")
                {
                    MessageBox.Show("La fecha de alta no puede ser mayor al dia de hoy", "Alerta", MessageBoxButtons.OK);
                }
                else
                {
                    dal.AltaPeriodo(periodo, fecha);
                    MessageBox.Show("El periodo se dio de alta correctamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }


        /*AQUI EMPIEZA LOS PROCESOS DE MAESTRO
        * 
        * 
        * 
        * 
        * 
        * 
        * */
        public DataTable ConsultaMaestroinactivo(string carrera)
        {

            if (carrera != "")
            {

                return dal.ConsultaMaestroinactivo(carrera);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para el Maestro.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }
        public DataTable validamaestro(string carrera)
        {

            if (carrera != "")
            {

                return dal.ConsultaMaestro(carrera);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para el maestro", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }

        public void AltaMaestro( string nombre, string direccion, string telefono, string pass, string fecha )
        {
            if (nombre == "")
            {
                MessageBox.Show("Es necesario especificar el nombre del Maestro", "Alerta", MessageBoxButtons.OK);
            }
            else
            {
                if (fecha == "")
                {
                    MessageBox.Show("La fecha de alta no puede ser mayor al dia de hoy", "Alerta", MessageBoxButtons.OK);
                }
                else
                {
                    dal.AltaMaestro(nombre, direccion, telefono, pass, fecha);
                    MessageBox.Show("El Maestro se dio de alta correctamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }
        
        public DataTable ConsultaMaestro(string materia)
        {

            if (materia != "")
            {

                return dal.ConsultaMaestro(materia);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para el maestro.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }

        public void ReactivarMaestro(string carrera)
        {
            if (carrera != "")
            {

                dal.ReactivarMaestro(carrera);
                MessageBox.Show("El Maestro Se Reactivo Exitosamente", "SIN ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Es necesario selecciona un Maestro.", "Alerta", MessageBoxButtons.OK);

            }
        }

        public void BajaMaestro(string carrera)
        {
            if (carrera != "")
            {

                dal.BajaMaestro(carrera);
                MessageBox.Show("El Maestro Se Dio De Baja Exitosamente", "SIN ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Es necesario selecciona un Maestro.", "Alerta", MessageBoxButtons.OK);

            }
        }

        public void ActualizaMaestro(string id,string nombre, string direccion, string telefono, string pass)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            if (nombre == "")
            {
                MessageBox.Show("Favor de especificar el nombre ", "Alerta", MessageBoxButtons.OK);

            }
            else
            {

                dal.ActualizaMaestro(id,nombre, direccion, telefono, pass);
                MessageBox.Show("El Maestro se modifico exitosamente", "Aviso", MessageBoxButtons.OK);

            }
        }



        /*AQUI EMPIEZA LOS PROCESOS DE ALUMNO
        * 
        * 
        * 
        * 
        * 
        * 
        * */

        public void AltaAlumno(string nombre, string direccion, string telefono, string fecha,string carrera, string user, string pass)
        {
            if (nombre == "")
            {
                MessageBox.Show("Es necesario especificar el nombre del Alumno", "Alerta", MessageBoxButtons.OK);
            }
            else
            {
                if (fecha == "")
                {
                    MessageBox.Show("La fecha de alta no puede ser mayor al dia de hoy", "Alerta", MessageBoxButtons.OK);
                }
                else
                {
                    dal.AltaAlumno(nombre, direccion, telefono,fecha, carrera, user, pass);
                    MessageBox.Show("El Alumno se dio de alta correctamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        public DataTable ConsultaAlumno(string materia)
        {

            if (materia != "")
            {

                return dal.ConsultaAlumno(materia);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para el alumno.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }

        public void BajaAlumno(string carrera)
        {
            if (carrera != "")
            {

                dal.BajaAlumno(carrera);
                MessageBox.Show("El Alumno Se Dio De Baja Exitosamente", "SIN ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Es necesario selecciona un Alumno.", "Alerta", MessageBoxButtons.OK);

            }
        }


        public DataTable ConsultaAlumnoinactivo(string carrera)
        {

            if (carrera != "")
            {

                return dal.ConsultaAlumnoinactivo(carrera);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para el Alumno.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }


        public DataTable ConsultaRelMatCarinactivo(string carrera)
        {

            if (carrera != "")
            {

                return dal.ConsultaRelMatCarinactivo(carrera);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para la relacion.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }


        public void ReactivarAlumno(string carrera)
        {
            if (carrera != "")
            {

                dal.ReactivarAlumno(carrera);
                MessageBox.Show("El Alumno Se Reactivo Exitosamente", "SIN ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Es necesario selecciona un Alumno.", "Alerta", MessageBoxButtons.OK);

            }
        }

        public void ReactivarRelMatCar(string carrera)
        {
            if (carrera != "")
            {

                dal.ReactivarRelMatCar(carrera);
                MessageBox.Show("La relacion Se Reactivo Exitosamente", "SIN ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Es necesario selecciona una relacion.", "Alerta", MessageBoxButtons.OK);

            }
        }

        public DataTable validaalumno(string carrera)
        {

            if (carrera != "")
            {

                return dal.ConsultaAlumno(carrera);
            }
            else
            {
                MessageBox.Show("Es ya existe este alumno.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }



        public DataTable user(string matricula, string pass)
        {
            if (matricula != "")
            {

                return dal.usuarios(matricula, pass);

            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor de matricula.", "Alerta", MessageBoxButtons.OK);
                return null;
            }
        }

        public DataTable userma(string matricula, string pass)
        {
            if (matricula != "")
            {

                return dal.usuariosma(matricula, pass);

            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor de matricula.", "Alerta", MessageBoxButtons.OK);
                return null;
            }
        }

        /*public DataTable useradmin(string matricula, string pass)
        {
            if (matricula != "")
            {

                return dal.usuariosadmin(matricula, pass);

            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor de matricula.", "Alerta", MessageBoxButtons.OK);
                return null;
            }
        }*/

        public void ActualizaCarrera(string carrera, string carreranueva)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            if (carrera == "")
            {
                MessageBox.Show("Favor de especificar la carrera a modificar", "Alerta", MessageBoxButtons.OK);

            }
            else
            {

                dal.ActualizaCarrera(carrera, carreranueva);//, fechaalta, fechabaja, estatus);
                MessageBox.Show("La carrera se modifico exitosamente", "Aviso", MessageBoxButtons.OK);

            }
        }



        public void ActualizaAlumno(int id, string nombre, string direccion, string carrera , string telefono, string pass, string fecha)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            if (carrera == "")
            {
                MessageBox.Show("Favor de especificar la carrera a modificar", "Alerta", MessageBoxButtons.OK);

            }
            else
            {

                dal.ActualizaAlumno(id, nombre, direccion, carrera, telefono, pass, fecha);//, fechaalta, fechabaja, estatus);
                MessageBox.Show("El alumno se modifico exitosamente", "Aviso", MessageBoxButtons.OK);

            }
        }

        public void ActualizaPeriodo(string carrera, string carreranueva)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            if (carrera == "")
            {
                MessageBox.Show("Favor de especificar la carrera a modificar", "Alerta", MessageBoxButtons.OK);

            }
            else
            {

                dal.ActualizaPeriodo(carrera, carreranueva);//, fechaalta, fechabaja, estatus);
                MessageBox.Show("La carrera se modifico exitosamente", "Aviso", MessageBoxButtons.OK);

            }
        }



        public void ActualizaMateria(string materia, string materianueva)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            if (materia == "")
            {
                MessageBox.Show("Favor de especificar la materia a modificar", "Alerta", MessageBoxButtons.OK);

            }
            else
            {

                dal.ActualizaMateria(materia, materianueva);//, fechaalta, fechabaja, estatus);
                MessageBox.Show("La materia se modifico exitosamente", "Aviso", MessageBoxButtons.OK);

            }
        }

        public DataTable Consultarmc(string rmc)
        {

            if (rmc != "")
            {

                return dal.ConsultaRmc(rmc);
            }
            else
            {
                MessageBox.Show("Es necesario especificar un valor para mostar la relacion.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }

        public DataTable llenadoca()
        {
            return dal.lleadoca();
        }
        public DataTable llenadoma()
        {
            return dal.lleadoma();
        }

        public void Altarmc(string carrera, string materia)
        {
            if (carrera == "" || materia == "")
            {
                MessageBox.Show("Es necesario especificar el nombre de la materia o de carrera", "Alerta", MessageBoxButtons.OK);

            }
            else
            {
                dal.Altarmc(carrera, materia);
                MessageBox.Show("La relacion se dio de alta correctamente", "Aviso", MessageBoxButtons.OK);
            }
        }

        public void Modificarmc(int id,  string materian, string carreran)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            if (materian == "")
            {
                MessageBox.Show("Favor de Ingresar un valor ", "Alerta", MessageBoxButtons.OK);

            }
            else
            {

                dal.Modificarcm(id,  materian, carreran);//, fechaalta, fechabaja, estatus);
                MessageBox.Show("Se modifico exitosamente", "Aviso", MessageBoxButtons.OK);

            }
        }

        public DataTable relrmcmateria(string materia)
        {

            if (materia != "")
            {

                return dal.relrmcmateria(materia);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para la carrera.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }

        public DataTable relrmccarrera(string carrera)
        {

            if (carrera != "")
            {

                return dal.relrmccarrera(carrera);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para la carrera.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }

        public void Bajarmc(int rmc)
        {

            dal.Bajarmc(rmc);
            MessageBox.Show("La Carrera Se Dio De Baja Exitosamente", "SIN ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        public DataTable Consultarma(string rma)
        {

            if (rma != "")
            {

                return dal.ConsultaRma(rma);
            }
            else
            {
                MessageBox.Show("Es necesario especificar un valor para mostar la relacion.", "Alerta", MessageBoxButtons.OK);
                return null;
            }




        }

        public void Bajarma(int rma)
        {

            dal.Bajarma(rma);
            MessageBox.Show("La Relacion Se Dio De Baja Exitosamente", "SIN ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public DataTable llenadoalumno()
        {
            return dal.llenadoalumno();
        }

        public DataTable llenadormc()
        {
            return dal.llenadormc();
        }

        public DataTable llenadomaestro()
        {
            return dal.llenadomaestro();
        }

        public DataTable llenadoperiodo()
        {
            return dal.llenadoperiodo();
        }

        public void Altarelmatalum(string alumnos, string rmc, string maestro, string periodo)
        {
            if (alumnos == "")
            {
                MessageBox.Show("Es necesario especificar el nombre de la carrera", "Alerta", MessageBoxButtons.OK);
            }
            else
            {

                dal.Altarelmatalum(alumnos, rmc, maestro, periodo);
                MessageBox.Show("se dio de alta la relacion", "Aviso", MessageBoxButtons.OK);

            }
        }

        public void Modificarma(int id, string alumno, string rmc, string maestro, string periodo, string alumnon, string rmcn, string maestron, string periodon)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            if (alumno == "")
            {
                MessageBox.Show("Favor de ", "Alerta", MessageBoxButtons.OK);

            }
            else
            {

                dal.Modificarma(id, alumno, rmc, maestro, periodo, alumnon, rmcn, maestron, periodon);//, fechaalta, fechabaja, estatus);
                MessageBox.Show("Lante", "Aviso", MessageBoxButtons.OK);

            }
        }
        public DataTable llenadorma()
        {
            return dal.llenadorma();
        }
        public DataTable ConsultaCalificacion()
        {

            return dal.ConsultaCalificacion();

        }
        public void AltaCalificacion(string id, string cali, string uni)
        {
            if (id == "")
            {
                MessageBox.Show("Es necesario especificar el id de la relacion materia alumno", "Alerta", MessageBoxButtons.OK);

            }
            else
            {

                dal.AltaCalificacion(id, cali, uni);
                MessageBox.Show("La calificacion se dio de alta correctamente", "Aviso", MessageBoxButtons.OK);

            }
        }
    }
}
