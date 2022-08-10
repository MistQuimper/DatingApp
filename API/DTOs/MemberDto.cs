using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.DTOs
{
    public class MemberDto
    {
         public int Id { get; set; }
        public string Username { get; set; }
        
        public string PhotoUrl { get; set; }
        public int Age { get; set; }

        public string KnownAs { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        public DateTime LastActive { get; set; } = DateTime.Now;

        public string Gender { get; set; }

        public string Introduction { get; set; }

        public string LookingFor { get; set; }

        public string Interests { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        //The photos.cs class has a AppUser return
        /*
        variable thus creating a circular
        reference exception wont do any 
        harm.
        Thus giving a 500 server error 
        with a message of:
        "A possible object cycle was detected."
        to solve the problem shape the data
        before returning it, and to do so
        we will use a DTO.
        Instead of returning an AppUser
        from our method what we need to return
        from our usersController is our 
        memberDto instead of the AppUser
        We are going to look at a utility 
        to help MAP one property from the 
        other and that is called AutoMapper
        */
        public ICollection<PhotoDto> Photos { get; set; }

    }
}