using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cotizacion.BLL
{
    
    class LivianoBLL
    {
        EntidadBDCotizacion contex = new EntidadBDCotizacion();

        public string ObtenerPermiso(string Codigo, int Anno) 
        {
            Livianos busqueda = (from l in contex.Livianos where l.Anno==Anno && l.Codigo==Codigo select l).FirstOrDefault();
            if(busqueda.Anno>0){                  
                return string.Format("Tipo de vehiculo: {0} \nMarca: {1} \nModelo: {2} \nCilindrada: {3} \nCombustible: {4} \nTransmisión: {5} \nTasación: ${6} \nPermiso: ${7}\n", busqueda.Tipo, busqueda.Marca, busqueda.Modelo, busqueda.Cilindros, busqueda.Combustible, busqueda.Transmision, busqueda.Tasacion, busqueda.Permiso);      
            }else{
                return string.Format("El codigo y el año no pertenecen a ningun vehiculo");
            }
            
        }

        // Tablas

        public List<Livianos> ObtenerTodos() {
            return (from l in contex.Livianos select l).ToList();
        }

        public List<Livianos> ObtenerPorTipo(string tipo) {
            return (from l in contex.Livianos where l.Tipo == tipo select l).ToList();
        }

        public List<Livianos> ObtenerPorAnno(string tipo, int anno, string marca)
        {
            return (from l in contex.Livianos where l.Tipo == tipo && l.Anno == anno && l.Marca == marca select l).Distinct().ToList();
        }

        public List<Livianos> ObtenerPorMarca(string tipo, string marca){
            return (from l in contex.Livianos where l.Tipo == tipo && l.Marca == marca select l).Distinct().ToList();
        }

        public List<Livianos> ObtenerPorCilindrada(string tipo, int anno, string marca, string cilindrada) {
            return (from l in contex.Livianos where l.Tipo == tipo && l.Anno == anno && l.Marca == marca && l.Cilindros==cilindrada select l).Distinct().ToList();
        }

        public List<Livianos> ObtenerPorPuertas(string tipo, int anno, string marca, string cilindrada, string puertas)
        {
            return (from l in contex.Livianos where l.Tipo == tipo && l.Anno == anno && l.Marca == marca && l.Cilindros == cilindrada && l.Puertas==puertas select l).Distinct().ToList();
        }

        public List<Livianos> ObtenerPorTransmision(string tipo, int anno, string marca, string cilindrada, string puertas, string transmision)
        {
            return (from l in contex.Livianos where l.Tipo == tipo && l.Anno == anno && l.Marca == marca && l.Cilindros == cilindrada && l.Puertas == puertas && l.Transmision == transmision select l).Distinct().ToList();
        }

        // Listados

        public List<String> ListadoTipos() {
            return (from l in contex.Livianos select l.Tipo).Distinct().ToList();
        }

        public List<String> ListadoMarcas(string tipo) {
            return (from l in contex.Livianos where l.Tipo == tipo select l.Marca).Distinct().ToList();
        }

        public List<String> ListadoAnnos(string tipo, string marca){
            var listado = (from l in contex.Livianos where l.Tipo == tipo && l.Marca == marca select l.Anno).Distinct().ToList();
            List<String> list = new List<string>();
            foreach (var c in listado)
            {
                list.Add(c.ToString());
            }
            return list;
        }

        public List<String> ListadoCilindros(string tipo, string marca, int anno) {
            return (from l in contex.Livianos where l.Tipo == tipo && l.Marca == marca && l.Anno == anno select l.Cilindros).Distinct().ToList();
        }

        public List<String> ListadoPuertas(string tipo, string marca, int anno, string cilindrada)
        {
            return (from l in contex.Livianos where l.Tipo == tipo && l.Marca == marca && l.Anno == anno && l.Cilindros==cilindrada select l.Puertas).Distinct().ToList();
        }

        public List<String> ListadoTransmision(string tipo, string marca, int anno, string cilindrada, string puertas)
        {
            return (from l in contex.Livianos where l.Tipo == tipo && l.Marca == marca && l.Anno == anno && l.Cilindros == cilindrada && l.Puertas == puertas select l.Transmision).Distinct().ToList();
        }
    }
}
