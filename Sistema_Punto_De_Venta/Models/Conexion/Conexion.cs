﻿using LinqToDB;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Conexion
{
    public class Conexion : DataConnection
    {
        public Conexion() : base("PDHN2") { }
        public ITable<TClientes> TClientes => this.GetTable<TClientes>();
        public ITable<TReportes_clientes> TReportes_clientes => this.GetTable<TReportes_clientes>(); 
    }
}
