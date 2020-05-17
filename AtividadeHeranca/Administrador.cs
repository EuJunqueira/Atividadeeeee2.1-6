using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeHeranca
{
    class Administrador:Colaborador
    {
        private double ajudaDeCusto;
        public Administrador(string Nome, string End, string Tel) : base(Nome, End, Tel)
        {

        }
        public double AjudaDeCusto
        {
            get { return ajudaDeCusto; }
            set { ajudaDeCusto = value; }
        }
        public override double calcularSalario()
        {
            return base.calcularSalario() + AjudaDeCusto;
        }
    }
}