using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public partial class pa_PicoYPlaca
    {
        [Key]
        public string resultado { get; set; }
    }
}
