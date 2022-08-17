using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MVCDb.Models
{
    public partial class Dept
    {
        public Dept()
        {
            Emps = new HashSet<Emp>();
        }
		[Required(ErrorMessage ="ID is Required")]
		[Display(Name="Dept Code")]
        public int Id { get; set; }

		[Required(ErrorMessage ="Name cannot be blank")]
		[Display(Name="Dept Name")]
        public string Name { get; set; }

		[Display(Name="Location")]
		[StringLength(25,ErrorMessage ="Min 3 Chars",MinimumLength =3)]
        public string Location { get; set; }

        public virtual ICollection<Emp> Emps { get; set; }
    }
}
