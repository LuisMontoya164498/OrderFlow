using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFlow.Shared.Entities
{
    public class Customer
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "El documento es requerido")]
        public string Name { get; set; } = null;

        [Required(ErrorMessage = "El nombre es requerido")]
        public string email { get; set; } = null;

        [Required(ErrorMessage = "El correo es requerido")]
        public string Address { get; set; } = null;

        





    }







}
