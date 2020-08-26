﻿using Inafocam.core.Interfaces;
using Inafocam.core.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inafocam.core.Repository
{
    public class EducationTypeRepository : IEducationType
    {
        private readonly inafocam_tracingContext _context;

        public EducationTypeRepository(inafocam_tracingContext context)
        {
            _context = context;
        }

        public IQueryable<EducationType> GetAll => _context.EducationType
            .Include(x => x.Status)
            .Include(x => x.TeacherEducation);
    }
}
