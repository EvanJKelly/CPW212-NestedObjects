﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjectsSample
{
    /// <summary>
    /// Represents a single college course
    /// </summary>
    class Course
    {
        /// <summary>
        /// Creates a course object with an empty 
        /// student roster
        /// </summary>
        public Course()
        {
            Roster = new List<Student>();
        }
        /// <summary>
        /// The unique course number
        /// ex. CPW 212
        /// </summary>
        public string CourseNunmber { get; set; }

        /// <summary>
        /// The Official course title
        /// ex. Advanced. NET
        /// </summary>
        public string Title { get; set; }
        
        /// <summary>
        /// Number of college credits students receive for
        /// competing the class succesfully
        /// </summary>
        public byte NumberOfCredits { get; set; }

        /// <summary>
        /// The official description course description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The students currently enrolled in the course
        /// </summary>
        public List<Student> Student { get; set; }
        
        //The students curently enrolled in a course
        public List<Student> Roster { get; }
    }
}
