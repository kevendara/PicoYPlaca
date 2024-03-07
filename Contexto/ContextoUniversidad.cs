using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Contexto
{
    public partial class ContextoUniversidad : DbContext
    {
        public ContextoUniversidad()
            : base("Name=PicoYPlaca")
        {
            this.Configuration.ValidateOnSaveEnabled = true;

        }

        public virtual DbSet<pa_PicoYPlaca> pa_PicoYPlaca { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            
        }
    }

}