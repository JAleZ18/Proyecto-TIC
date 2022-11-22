using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine
{
    public class acciones
    {
        //codigo peliculas
        public List<sp_select_peliculasResult> MostrarPeliculas()
        {
            ConexionDataContext p = new ConexionDataContext();
            var mostrarP = p.sp_select_peliculas();
            return mostrarP.ToList();
        }

        public void insertar_pelicula( string titulo, string dura, string gene, string clasi )
        {
            ConexionDataContext pp = new ConexionDataContext();
            var insertarP = pp.sp_insertar_pelicula(titulo, dura, gene, clasi);
        }

        public void eliminar_pelicula (int id_peli)
        {
            ConexionDataContext ppp = new ConexionDataContext();
            var eliminarP = ppp.sp_eliminar_pelicula(id_peli);
        }
        public void actualizar_pelicula (int id_peli, string titulo, string dura, string gene, string clasi)
        {
            ConexionDataContext pppp = new ConexionDataContext();
            var modificarP = pppp.sp_actualizar_peliculas(id_peli, titulo, dura, gene, clasi);
        }
        //codigo salas
        public List<sp_select_salasResult> MostrarSala()
        {
            ConexionDataContext s = new ConexionDataContext();
            var mostrarS = s.sp_select_salas();
            return mostrarS.ToList();
        }
        public void insertar_sala(string nom, string desc)
        {
            ConexionDataContext ss = new ConexionDataContext();
            var insertarS = ss.sp_insertar_sala(nom, desc);
        }

    public void actualizar_sala(int id_sala, string nom, string desc)
        {
            ConexionDataContext sss = new ConexionDataContext();
            var actulizarS = sss.sp_actualizar_sala(id_sala, nom, desc);
        }

        //codigo horarios
        public List<sp_select_horariosResult> MostrarHorarios()
        {
            ConexionDataContext h = new ConexionDataContext();
            var mostrarH = h.sp_select_horarios();
            return mostrarH.ToList();
        }
        public void insertar_horario( TimeSpan hora)
        {
            ConexionDataContext hh = new ConexionDataContext();
            var insertarH = hh.sp_insertar_horarios(hora);
        }

        public void actualizar_horario(int id_horario, TimeSpan hora)
        {
            ConexionDataContext hhh = new ConexionDataContext();
            var modificarH = hhh.sp_actualizar_horarios(id_horario, hora);
        }

        //codigo cartelera

        public List<sp_select_carteleraResult> MostrarCartelera()
        {
            ConexionDataContext c = new ConexionDataContext();
            var mostrarC = c.sp_select_cartelera();
            return mostrarC.ToList();
        }
        public void insertar_cartelera(int id_sala, int id_hora, int id_peli)
        {
            ConexionDataContext cc = new ConexionDataContext();
            var insertarC = cc.sp_insertar_cartelera(id_sala, id_hora, id_peli);
        }
    }
}
