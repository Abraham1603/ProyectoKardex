﻿using System;
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

        public DataTable validagrupo(string carrera)
        {

            if (carrera != "")
            {

                return dal.ConsultaGrupo(carrera);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para el grupo.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }


        public void ActualizaCampus(string carrera, string carreranueva, string carreranueva2, string fecha)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            if (carrera == "")
            {
                MessageBox.Show("Favor de especificar el campus a modificar", "Alerta", MessageBoxButtons.OK);

            }
            else
            {

                dal.ActualizaCampus(carrera, carreranueva, carreranueva2, fecha);//, fechaalta, fechabaja, estatus);
                MessageBox.Show("El campus se modifico exitosamente", "Aviso", MessageBoxButtons.OK);

            }
        }

        public DataTable ConsultaCampus(string carrera)
        {

            if (carrera != "")
            {

                return dal.ConsultaCampus(carrera);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para el Campus.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }



        public DataTable validagrupoinactivo(string carrera)
        {

            if (carrera != "")
            {

                return dal.ConsultaGrupoinactivo(carrera);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para el grupo.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }


        public void ReactivarGrupo(string carrera)
        {
            if (carrera != "")
            {

                dal.ReactivarGrupo(carrera);
                MessageBox.Show("El Grupo Se Reactivo Exitosamente", "SIN ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Es necesario selecciona un Grupo.", "Alerta", MessageBoxButtons.OK);

            }
        }



        public DataTable ConsultaGruposinactivo(string carrera)
        {

            if (carrera != "")
            {

                return dal.ConsultaGrupoinactivo(carrera);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para la carrera.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }

        public void ActualizaGrupo(string carrera, string carreranueva, string fecha)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            if (carrera == "")
            {
                MessageBox.Show("Favor de especificar el grupo a modificar", "Alerta", MessageBoxButtons.OK);

            }
            else
            {

                dal.ActualizaGrupo(carrera, carreranueva, fecha);//, fechaalta, fechabaja, estatus);
                MessageBox.Show("El grupo se modifico exitosamente", "Aviso", MessageBoxButtons.OK);

            }
        }

        public void BajaRelmatcarr_horario_alumno(string carrera)
        {


            dal.BajaRelmatcarr_horario_alumno(carrera);
            MessageBox.Show("La relacion Se Dio De Baja Exitosamente", "SIN ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }




        public void BajaRelmatcarr_horario_maestro(string carrera)
        {


            dal.BajaRelmatcarr_horario_maestro(carrera);
            MessageBox.Show("La relacion Se Dio De Baja Exitosamente", "SIN ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }


        public void AltaGrupo(string carrera, string fecha)
        {
            if (carrera == "")
            {
                MessageBox.Show("Es necesario especificar el nombre del grupo", "Alerta", MessageBoxButtons.OK);
            }
            else
            {
                if (fecha == "")
                {
                    MessageBox.Show("La fecha de alta no puede ser mayor al dia de hoy", "Alerta", MessageBoxButtons.OK);
                }
                else
                {
                    dal.AltaGrupo(carrera, fecha);
                    MessageBox.Show("El Grupo se dio de alta correctamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }
        public void Altacampus(string carrera, string fecha)
        {
            if (carrera == "")
            {
                MessageBox.Show("Es necesario especificar el nombre del Campus", "Alerta", MessageBoxButtons.OK);
            }
            else
            {
                if (fecha == "")
                {
                    MessageBox.Show("La fecha de alta no puede ser mayor al dia de hoy", "Alerta", MessageBoxButtons.OK);
                }
                else
                {
                    dal.Altacampus(carrera, fecha);
                    MessageBox.Show("El campus se dio de alta correctamente", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        public DataTable ConsultaCampusinactivo(string carrera)
        {

            if (carrera != "")
            {

                return dal.ConsultaCampusinactivo(carrera);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para el Campus.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }

        public void ReactivarCampus(string carrera)
        {
            if (carrera != "")
            {

                dal.ReactivarCampus(carrera);
                MessageBox.Show("El Campus Se Reactivo Exitosamente", "SIN ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Es necesario selecciona un Campus.", "Alerta", MessageBoxButtons.OK);

            }
        }

        public void BajaCampus(string carrera)
        {
            if (carrera != "")
            {

                dal.BajaCampus(carrera);
                MessageBox.Show("El Campus Se Dio De Baja Exitosamente", "SIN ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Es necesario selecciona un Campus.", "Alerta", MessageBoxButtons.OK);

            }
        }






        public void BajaRelmatcarr_horario(string carrera)
        {
            

                 dal.BajaRelmatcarr_horario(carrera);
                MessageBox.Show("La relacion Se Dio De Baja Exitosamente", "SIN ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }






        public DataTable validacampus(string materia)
        {

            if (materia != "")
            {

                return dal.ConsultaCampus(materia);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para el Campus.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }

        public DataTable validacampusinactivo(string materia)
        {

            if (materia != "")
            {

                return dal.ConsultaCampusinactivo(materia);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para el Campus.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }






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


        public DataTable ConsultaRelmatcarr_horario()
        {

            return dal.ConsultaRelmatcarr_horario();
           
        }

        public DataTable ConsultaRelmatcarr_horarioinactivo()
        {

            return dal.ConsultaRelmatcarr_horarioinactivo();

        }

        

        public DataTable validarelacionhorarioalumnoinactivo(string carrera, string carrera2)
        {

            return dal.ConsultaRelmatcarr_horario_alumnoinactivo2(carrera,carrera2);

        }


        public DataTable ConsultaRelmatcarr_horario_alumnoinactivo()
        {

            return dal.ConsultaRelmatcarr_horario_alumnoinactivo();

        }


        public DataTable ConsultaRelmatcarr_horario_Maestroinactivo()
        {

            return dal.ConsultaRelmatcarr_horario_Maestroinactivo();

        }

        

        


        public DataTable validahorarioalumno(string carrera, string carrera2)
        {

            return dal.ConsultaRelmatcarr_horario_alumno2(carrera,carrera2);

        }



        public DataTable ConsultaRelmatcarr_horario_alumno()
        {

            return dal.ConsultaRelmatcarr_horario_alumno();

        }





        /**/
        public DataTable validarelacionhorariomaestroinactivo(string carrera, string carrera2)
        {

            return dal.ConsultaRelmatcarr_horario_Maestroinactivo2(carrera, carrera2);

        }

        public DataTable Valida_maestro_nombre(string maestro)
        {

            return dal.Valida_maestro_nombre(maestro);

        }
        /**/


        public DataTable ConsultaRelmatcarr_horario_Maestro()
        {

            return dal.ConsultaRelmatcarr_horario_Maestro();

        }

        public void ActualizaCalificacion(string id, string p1, string p2,string p3, string cf)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            if (p1 == "" || p2 == "" || p3 == "" || cf == "")
            {
                MessageBox.Show("Favor de escoger bien la calificacion a modificar", "Alerta", MessageBoxButtons.OK);

            }
            else
            {

                dal.ActualizaCalificacion(id, p1,p2,p3,cf);//, fechaalta, fechabaja, estatus);
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

        public DataTable validacarrerainactivo(string carrera)
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


        public DataTable validamateriainactivo(string carrera)
        {

            if (carrera != "")
            {

                return dal.ConsultaMateriainactivo(carrera);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para la carrera.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }


        public void BajaGrupo(string carrera)
        {
            if (carrera != "")
            {

                dal.BajaGrupo(carrera);
                MessageBox.Show("El grupo Se Dio De Baja Exitosamente", "SIN ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Es necesario selecciona un grupo.", "Alerta", MessageBoxButtons.OK);

            }
        }

        public DataTable ConsultaGrupo(string carrera)
        {

            if (carrera != "")
            {

                return dal.ConsultaGrupo(carrera);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para el grupo.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }

        public DataTable validaperiodoinactivo(string carrera)
        {

            if (carrera != "")
            {

                return dal.ConsultaPeriodoinactivo(carrera);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para la carrera.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }



        public DataTable validaalumnoinactivo(string carrera)
        {

            if (carrera != "")
            {

                return dal.ConsultaAlumnoinactivo(carrera);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para la carrera.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }


        public DataTable traer_grupos(string carrera)
        {

            if (carrera != "")
            {

                return dal.traer_grupos(carrera);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para la carrera.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }



        public DataTable validaalumnoinactivo2(string carrera)
        {

            if (carrera != "")
            {

                return dal.ConsultaAlumnoinactivo2(carrera);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para la carrera.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }



        public DataTable validamaestroinactivo(string carrera)
        {

            if (carrera != "")
            {

                return dal.validamaestroinactivo(carrera);
            }
            else
            {
                MessageBox.Show("Es necesario especificar el valor para la carrera.", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }



        public DataTable No_puede_tener_dos_materias_en_el_mismo_horario (string matcarr, string periodo, string grupo)
        {

            if (matcarr != "")
            {

                return dal.No_puede_tener_dos_materias_en_el_mismo_horario(matcarr,periodo,grupo);
            }
            else
            {
                MessageBox.Show("Es necesario especificar una relacion de horario", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }



        public DataTable No_debe_permitir_asignar_una_materia_que_ya_esta_aprobada(string matcarr, string alumno)
        {

            if (matcarr != "")
            {

                return dal.No_debe_permitir_asignar_una_materia_que_ya_esta_aprobada(matcarr, alumno);
            }
            else
            {
                MessageBox.Show("Es necesario especificar una relacion de horario", "Alerta", MessageBoxButtons.OK);
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


        public void ReactivarRelmatcarr_horario(string carrera)
        {
            if (carrera != "")
            {

                dal.ReactivarRelmatcarr_horario(carrera);
                MessageBox.Show("La Relacion Se Reactivo Exitosamente", "SIN ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Es necesario selecciona una relacion.", "Alerta", MessageBoxButtons.OK);

            }
        }

        public void ReactivarRelmatcarr_horario_maestro(string carrera)
        {
            if (carrera != "")
            {

                dal.ReactivarRelmatcarr_horario_maestro(carrera);
                MessageBox.Show("La Relacion Se Reactivo Exitosamente", "SIN ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Es necesario selecciona una relacion.", "Alerta", MessageBoxButtons.OK);

            }
        }




        public void ReactivarRelmatcarr_horario_alumno(string carrera)
        {
            if (carrera != "")
            {

                dal.ReactivarRelmatcarr_horario_alumno(carrera);
                MessageBox.Show("La Relacion Se Reactivo Exitosamente", "SIN ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Es necesario selecciona una relacion.", "Alerta", MessageBoxButtons.OK);

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


        public DataTable No_debe_permitir_asignar_una_materia_que_ya_esta_aprobada_Docente(string matcarr, string maestro)
        {

            if (matcarr != "")
            {

                return dal.No_debe_permitir_asignar_una_materia_que_ya_esta_aprobada_Docente(matcarr, maestro);
            }
            else
            {
                MessageBox.Show("Es necesario especificar una relacion de horario", "Alerta", MessageBoxButtons.OK);
                return null;
            }


        }


        public void Alta_rel_matcarr_horario_Maestro(string matcarr, string maestro)
        {


            dal.Alta_rel_matcarr_horario_Maestro(matcarr, maestro);
            MessageBox.Show("se dio de alta la relacion", "Aviso", MessageBoxButtons.OK);


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

        public void AltaAlumno(string nombre, string direccion, string telefono, string fecha,string carrera,string campus, string grupo)
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
                    dal.AltaAlumno(nombre, direccion, telefono,fecha, carrera,campus,grupo);
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







        public DataTable los_grupos_solo_pueden_pertenecer_a_una_carrera( string pass)
        {
            if (pass != "")
            {

                return dal.los_grupos_solo_pueden_pertenecer_a_una_carrera(pass);

            }
            else
            {
                MessageBox.Show("Es necesario especificar el usuario.", "Alerta", MessageBoxButtons.OK);
                return null;
            }
        }









        public DataTable validaadmin(string matricula, string pass)
        {
            if (matricula != "")
            {

                return dal.usuariosadmin(matricula, pass);

            }
            else
            {
                MessageBox.Show("Es necesario especificar el usuario.", "Alerta", MessageBoxButtons.OK);
                return null;
            }
        }

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

        public DataTable llenadocampus()
        {
            return dal.llenadocampus();
        }

        public DataTable llenadoma()
        {
            return dal.lleadoma();
        }

        public void Altarmc(string carrera, string materia,string campus)
        {
            if (carrera == "" || materia == "")
            {
                MessageBox.Show("Es necesario especificar el nombre de la materia o de carrera", "Alerta", MessageBoxButtons.OK);

            }
            else
            {
                dal.Altarmc(carrera, materia,campus);
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



        public void Actualizarel_matcarr_horario(string id, string matcarr, string horario, string horario2, string periodo, string grupo)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            if (matcarr == "")
            {
                MessageBox.Show("Favor de Ingresar un valor ", "Alerta", MessageBoxButtons.OK);

            }
            else
            {

                dal.Actualizarel_matcarr_horario(id, matcarr, horario, horario2, periodo, grupo);//, fechaalta, fechabaja, estatus);
                MessageBox.Show("Se modifico exitosamente", "Aviso", MessageBoxButtons.OK);

            }
        }

        public void Actualizarel_matcarr_horario_alumno(string id, string matcarr, string horario)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            if (matcarr == "")
            {
                MessageBox.Show("Favor de Ingresar un valor ", "Alerta", MessageBoxButtons.OK);

            }
            else
            {

                dal.Actualizarel_matcarr_horario_alumno(id, matcarr, horario);//, fechaalta, fechabaja, estatus);
                MessageBox.Show("Se modifico exitosamente", "Aviso", MessageBoxButtons.OK);

            }
        }




        public void Actualizarel_matcarr_horario_maestro(string id, string matcarr, string horario)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            if (matcarr == "")
            {
                MessageBox.Show("Favor de Ingresar un valor ", "Alerta", MessageBoxButtons.OK);

            }
            else
            {

                dal.Actualizarel_matcarr_horario_maestro(id, matcarr, horario);//, fechaalta, fechabaja, estatus);
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



        public DataTable alumno_solo_puede_tener_un_grupo(string alumno)
        {

            return dal.alumno_solo_puede_tener_un_grupo(alumno);

        }


        public DataTable alumno_solo_puede_tener_un_grupo2(string cd)
        {

            return dal.alumno_solo_puede_tener_un_grupo2( cd);

        }



        public void AltaCalificacion(string id)
        {
            if (id == "")
            {
                MessageBox.Show("Es necesario especificar el id de la relacion materia alumno", "Alerta", MessageBoxButtons.OK);

            }
            else
            {

                dal.AltaCalificacion(id);
                MessageBox.Show("La calificacion se dio de alta correctamente", "Aviso", MessageBoxButtons.OK);

            }
        }

        public void Alta_rel_matcarr_horario(string matcarr, string horario, string horario2, string periodo, string grupo)
        {
        

                dal.Alta_rel_matcarr_horario(matcarr, horario, horario2, periodo, grupo);
                MessageBox.Show("se dio de alta la relacion", "Aviso", MessageBoxButtons.OK);

           
        }

        public void Alta_rel_matcarr_horario_alumno(string matcarr, string alumno)
        {


            dal.Alta_rel_matcarr_horario_alumno(matcarr, alumno);
            MessageBox.Show("se dio de alta la relacion", "Aviso", MessageBoxButtons.OK);


        }

        public DataTable llenadomatcar()
        {
            return dal.llenadomatcar();
        }

        public DataTable llenadomatcarr_horario()
        {
            return dal.llenadomatcarr_horario();
        }

        public DataTable llenadomatcarr_horario_alumno()
        {
            return dal.llenadomatcarr_horario_alumno();
        }

        public DataTable llenadogrupo()
        {
            return dal.llenadogrupo();
        }

        public DataTable llenadohorario()
        {
            return dal.llenadohorario();
        }

        public DataTable Valida_materia(string carrera, string periodo, string grupo)
        {
            return dal.Valida_materia(carrera, periodo, grupo);
        }

        public DataTable Valida_horario(string horario1, string horario2, string periodo, string grupo)
        {
            return dal.Valida_horario(horario1,horario2, periodo, grupo);
        }



        public DataTable Valida_maestro_matcarr(string maestro, string matcarr)
        {
            return dal.Valida_maestro_matcarr(maestro, matcarr);
        }

        public DataTable Valida_carrera(string matcar)
        {
            return dal.Valida_carrera(matcar);
        }

        public DataTable valida_horario_maestro_matcarr(string matcar,string maestro)
        {
            return dal.valida_horario_maestro_matcarr(matcar,maestro);
        }


    }
}
