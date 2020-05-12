using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente:Personal
    {
        private double valorHora;

		#region Propiedades
		public double ValorHora
		{
			get { return this.valorHora; }
			set { this.valorHora = value; }
		}
		public int HorasMensuales
		{
			get { return -1; }
			set { int aux = value; }
		}
		#endregion
		#region Constructor
		public Docente(string nombre, string apellido, int dni, bool femenino, DateTime horaentrada, DateTime horasalida, double valorho): base(nombre, apellido, dni, femenino,horaentrada,horasalida)
		{
			this.valorHora = valorho;
		}

		#endregion

	
		public override double CalcularSalario()
		{
			return (valorHora * 4) * 20;
		}
	}
}
