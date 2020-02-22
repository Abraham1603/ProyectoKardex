using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Kardex.Layers; //Podemos acceder a cada una de las clases dentro de la carpeta Layers
using System.Windows.Forms; //Puede tirar mensajitos

namespace Kardex.Layers
{
    class DAL //DAL - Data Acces Layer
    {
        dbConn conn = new dbConn();
        
        public DataTable ConsultaCarrera(string carrera)
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "ConsultaCarrera '" + carrera +"'";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error", MessageBoxButtons.OK);
            }

            return dt;
        }

        public DataTable ConsultaRelmatcarr_horario()
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "ConsultaRelmatcarr_horario ";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }



        public DataTable ConsultaRelmatcarr_horarioinactivo()
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "ConsultaRelmatcarr_horarioinactivo ";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }





        public DataTable ConsultaRelmatcarr_horario_alumno()
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "ConsultaRelmatcarr_horario_alumno ";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }

        public void ActualizaCalificacion(string id, string p1, string p2,string p3, string cf)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            try
            {
                string query = "ActualizaCalificacion '" + id + "','" + p1 + "','" + p2 + "','" + p3 + "','" + cf + "'"; // + "," + fechaalta + "," + fechabaja + "," + estatus;

                conn.ExcQry(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }

        public void ActualizaAlumno(int id,  string nombre, string direccion, string carrera, string telefono, string pass, string fecha)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            try
            {
                string query = "ActualizaAlumno '" + id + "','" + nombre + "','" + direccion + "','"  + carrera + "','" + telefono + "','" + pass + "','" + fecha + "'"; // + "," + fechaalta + "," + fechabaja + "," + estatus;

                conn.ExcQry(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }

        public DataTable ConsultaGrupo(string carrera)
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "ConsultaGrupo '" + carrera + "'";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }



        public void AltaGrupo(string carrera, string fecha)
        {
            try
            {
                string query = "AltaGrupo '" + carrera + "','" + fecha + "'";
                conn.ExcQry(query);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }


        public void Altacampus(string carrera, string fecha)
        {
            try
            {
                string query = "Altacampus '" + carrera + "','" + fecha + "'";
                conn.ExcQry(query);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }


        public DataTable ConsultaCampus(string carrera)
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "ConsultaCampus '" + carrera + "'";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }




        public DataTable ConsultaMaestro(string carrera)
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "ConsultaMaestro '" + carrera + "'";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }


        public DataTable ConsultaAlumno(string carrera)
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "ConsultaAlumno '" + carrera  + "'";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }





        public DataTable ConsultaCarrerainactivo(string carrera)
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "ConsultaCarrerainactivo '" + carrera + "'";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }



        public DataTable Consultarmainactivo(string carrera)
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "Consultarmainactivo '" + carrera + "'";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }


        public DataTable ConsultaPeriodoinactivo(string carrera)
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "ConsultaPeriodoinactivo '" + carrera + "'";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }

        public DataTable ConsultaMateriainactivo(string carrera)
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "ConsultaMateriainactivo '" + carrera + "'";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }



        public DataTable ConsultaMaestroinactivo(string carrera)
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "ConsultaMaestroinactivo '" + carrera + "'";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }



        public DataTable ConsultaAlumnoinactivo(string carrera)
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "ConsultaAlumnoinactivo '" + carrera + "'";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }



        public DataTable ConsultaRelMatCarinactivo(string carrera)
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "ConsultaRelMatCarinactivo '" + carrera + "'";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }


        public DataTable ConsultaPeriodo(string periodo)
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "ConsultaPeriodo '" + periodo + "'";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }


        public void AltaPeriodo(string periodo, string fecha)
        {
            try
            {
                string query = "AltaPeriodo '" + periodo + "','" + fecha + "'";
                conn.ExcQry(query);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }

        public void AltaMaestro( string nombre, string direccion, string telefono,string  pass, string fecha )
        {
            try
            {
                string query = "AltaMaestro '" + nombre + "','" + direccion +"','" + telefono + "','" + pass + "','" + fecha + "'";
                conn.ExcQry(query);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }


        public void AltaAlumno(string nombre, string direccion, string telefono, string fecha, string carrera,string campus, string grupos)
        {
            try
            {
                string query = "AltaAlumno '" + nombre + "','" + direccion + "','" + telefono + "','" + fecha + "','" + carrera + "','" + campus + "','" + grupos + "'";
                conn.ExcQry(query);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }






        public void ReactivarAlumno(string carrera)
        {
            try
            {
                string query = "ReactivarAlumno '" + carrera + "'";
                conn.ExcQry(query);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }


        }



        public void ReactivarRelmatcarr_horario(string carrera)
        {
            try
            {
                string query = "ReactivarRelmatcarr_horario '" + carrera + "'";
                conn.ExcQry(query);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }


        }




        public void ReactivarRelmatalum(string carrera)
        {
            try
            {
                string query = "ReactivarRelmatalum '" + carrera + "'";
                conn.ExcQry(query);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }


        }



        public void ReactivarRelMatCar(string carrera)
        {
            try
            {
                string query = "ReactivarRelMatCar '" + carrera + "'";
                conn.ExcQry(query);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }


        }






        public void ReactivarCarrera(string carrera)
        {
            try
            {
                string query = "ReactivarCarrera '" + carrera + "'";
                conn.ExcQry(query);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }


        }

        public void ReactivarMaestro(string carrera)
        {
            try
            {
                string query = "ReactivarMaestro '" + carrera + "'";
                conn.ExcQry(query);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }


        }


        public void ReactivarPeriodo(string carrera)
        {
            try
            {
                string query = "ReactivarPeriodo '" + carrera + "'";
                conn.ExcQry(query);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }


        }


        public void ReactivarMateria(string materia)
        {
            try
            {
                string query = "ReactivarMateria '" + materia + "'";
                conn.ExcQry(query);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }


        }

        public DataTable usuarios(string matricula, string pass)
        {
            DataTable dt = new DataTable();


            string query;

            try
            {
                query = "usuarios '" + matricula + "','" + pass + "'";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);

            }


            return dt;

        }

        public DataTable usuariosma(string matricula, string pass)
        {
            DataTable dt = new DataTable();


            string query;

            try
            {
                query = "usuariosmaestros '" + matricula + "','" + pass + "'";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }


            return dt;

        }

        public void ActualizaCarrera(string carrera, string carreranueva, string fechamodi)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            try
            {
                string query = "ActualizaCarrera '" + carrera + "','" + carreranueva + "','" + fechamodi + "'"; // + "," + fechaalta + "," + fechabaja + "," + estatus;

                conn.ExcQry(query);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }

        public void ActualizaMaestro(string id, string nombre, string direccion, string telefono,string pass)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            try
            {
                string query = "ActualizaMaestro '" + id + "','" + nombre + "','" + direccion + "','" + telefono + "','" + pass + "'"; // + "," + fechaalta + "," + fechabaja + "," + estatus;

                conn.ExcQry(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }
        public void ActualizaPeriodo(string carrera, string carreranueva,string fecha)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            try
            {
                string query = "ActualizaPeriodo '" + carrera + "','" + carreranueva + "','" + fecha + "'"; // + "," + fechaalta + "," + fechabaja + "," + estatus;

                conn.ExcQry(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }

        public void AltaCarrera(string carrera, string fecha)
        {
            try
            {
                string query = "AltaCarrera '" + carrera + "','" + fecha + "'";
                conn.ExcQry(query);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }

        public void BajaCarrera(string carrera)
        {
            try
            {
                string query = "BajaCarrera '" + carrera+ "'";
                conn.ExcQry(query);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            
        }



        public void BajaRelmatcarr_horario(string carrera)
        {
            try
            {
                string query = "BajaRelmatcarr_horario '" + carrera + "'";
                conn.ExcQry(query);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }


        }



        public void BajaMaestro(string carrera)
        {
            try
            {
                string query = "BajaMaestro '" + carrera + "'";
                conn.ExcQry(query);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }


        }

        public void BajaAlumno(string carrera)
        {
            try
            {
                string query = "BajaAlumno '" + carrera + "'";
                conn.ExcQry(query);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }


        }




        public void BajaPeriodo(string carrera)
        {
            try
            {
                string query = "BajaPeriodo '" + carrera + "'";
                conn.ExcQry(query);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }


        }


        public void AltaMateria(string materia, string fecha)
        {
            try
            {
                string query = "AltaMateria '" + materia + "','" + fecha + "'";
                conn.ExcQry(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }



        public DataTable ConsultaMateria(string Materia)
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "ConsultaMateria '" + Materia + "'";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }



        public void BajaMateria(string materia)
        {
            try
            {
                string query = "BajaMateria '" + materia + "'";
                conn.ExcQry(query);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }


        }

        public void ActualizaMateria(string materia, string materianueva, string fecha)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            try
            {
                string query = "ActualizaMateria '" + materia + "','" + materianueva +"','" + fecha + "'"; // + "," + fechaalta + "," + fechabaja + "," + estatus;

                conn.ExcQry(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }


        public void ActualizaCarrera(string carrera, string carreranueva)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            try
            {
                string query = "ActualizaCarrera '" + carrera + "','" + carreranueva + "'"; // + "," + fechaalta + "," + fechabaja + "," + estatus;

                conn.ExcQry(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }


        public void ActualizaPeriodo(string carrera, string carreranueva)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            try
            {
                string query = "ActualizaPeriodo '" + carrera + "','" + carreranueva + "'"; // + "," + fechaalta + "," + fechabaja + "," + estatus;

                conn.ExcQry(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }

        public void ActualizaMateria(string materia, string materianueva)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            try
            {
                string query = "ActualizaMateria '" + materia + "','" + materianueva + "'"; // + "," + fechaalta + "," + fechabaja + "," + estatus;

                conn.ExcQry(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }


        public DataTable ConsultaRmc(string rmc)
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "Cosultarelmatcarr '" + rmc + "'";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }

        public DataTable lleadoca()
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "llenadoca ";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }

        public DataTable llenadocampus()
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "llenadocampus ";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }


        public DataTable lleadoma()
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "llenadoma ";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }   

        public void Altarmc(string carrera, string materia,string campus)
        {
            try
            {
                string query = "AltaMateriaCarrera '" + materia + "','" + carrera + "','" + campus + "'";
                conn.ExcQry(query);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }

        public void Modificarcm(int id, string materian, string carreran)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            try
            {
                string query = "Actualizarelmatcarr '" + id + "','" + materian + "','" + carreran + "'"; // + "," + fechaalta + "," + fechabaja + "," + estatus;

                conn.ExcQry(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }


        public void Actualizarel_matcarr_horario(string id, string matcarr, string horario, string horario2, string periodo, string grupo)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            try
            {
                string query = "Actualizarel_matcarr_horario '" + id + "','" + matcarr + "','" + horario + "','" + horario2 + "','" + periodo + "','" + grupo + "'"; // + "," + fechaalta + "," + fechabaja + "," + estatus;

                conn.ExcQry(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }



        public DataTable relrmcmateria(string rmc)
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "relrmcmateria '" + rmc + "'";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }


        public DataTable relrmccarrera(string rmc)
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "relrmccarrera '" + rmc + "'";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }


        public void Bajarmc(int rmc)
        {
            try
            {
                string query = "Bajarmc '" + rmc + "'";
                conn.ExcQry(query);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }


        }


        public DataTable ConsultaRma(string rma)
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "ConsultaRelmatalum '" + rma + "'";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }


        public void Bajarma(int rma)
        {
            try
            {
                string query = "Bajarma '" + rma + "'";
                conn.ExcQry(query);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }


        }

        public DataTable llenadoalumno()
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "llenadoalumno ";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }

        public DataTable llenadormc()
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "llenadormc ";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }

        public DataTable llenadomaestro()
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "llenadomaestro ";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }

        public DataTable llenadoperiodo()
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "llenadoperiodo ";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }


        public void Altarelmatalum(string alumno, string rmc, string maestro, string periodo)
        {
            try
            {
                string query = "AltaRelmatalum2 '" + alumno + "','" + rmc + "','" + maestro + "','" + periodo + "'";
                conn.ExcQry(query);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }

        public void Modificarma(int id, string alumno, string rmc, string maestro, string periodo, string alumnon, string rmcn, string maestron, string periodon)//, DateTime fechaalta, DateTime fechabaja, bool estatus)
        {
            try
            {
                string query = "ModificaRelmatalu '" + id + "','" + alumno + "','" + rmc + "','" + maestro + "','" + periodo + "','" + alumnon + "','" + rmcn + "','" + maestron + "','" + periodon + "'"; // + "," + fechaalta + "," + fechabaja + "," + estatus;

                conn.ExcQry(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }

        public DataTable ConsultaCalificacion()
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "ConsultaCalificacion ";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }
        public void AltaCalificacion(string id)
        {
            try
            {
                string query = "AltaCalificaciones '" + id + "'";
                conn.ExcQry(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }



        public void Alta_rel_matcarr_horario(string matcarr, string horario,string horario2, string periodo, string grupo)
        {
            try
            {
                string query = "Alta_rel_matcarr_horario '" + matcarr + "','" + horario + "','" + horario2 + "','" + periodo + "','" + grupo + "'";
                conn.ExcQry(query);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }



        public void Alta_rel_matcarr_horario_alumno(string matcarr, string alumno)
        {
            try
            {
                string query = "Alta_rel_matcarr_horario_alumno '" + matcarr + "','" + alumno + "'";
                conn.ExcQry(query);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }


        public DataTable llenadorma()
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "llenadorma ";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }

        public DataTable llenadomatcar()
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "llenadomatcarr ";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }

        public DataTable llenadomatcarr_horario()
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "llenadomatcarr_horario ";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }


        public DataTable llenadomatcarr_horario_alumno()
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "llenadomatcarr_horario_alumno ";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }



        public DataTable llenadogrupo()
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "llenadogrupo ";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }


        public DataTable llenadohorario()
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "llenadohorario ";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }

        public DataTable No_puede_tener_dos_materias_en_el_mismo_horario(string matcarr, string periodo, string grupo)
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "No_puede_tener_dos_materias_en_el_mismo_horario '" + matcarr + "','" + periodo + "','" + grupo + "'";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }


        public DataTable No_debe_permitir_asignar_una_materia_que_ya_esta_aprobada(string matcarr, string alumno)
        {
            string query;
            DataTable dt = new DataTable();
            try
            {
                //Le asignamos a query el valor del SP "nombre" mas el parametro carrera
                //Para ejecutarlo posteriormente.
                query = "No_debe_permitir_asignar_una_materia_que_ya_esta_aprobada '" + matcarr + "','" + alumno + "'";
                dt = conn.ExcQryDt(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }

            return dt;
        }
    }

}
