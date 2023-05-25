﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Service.DTOs.Roles
{
    public class RoleCreationDto
    {
        [Required]
        public string Name { get; set; }
    }
}