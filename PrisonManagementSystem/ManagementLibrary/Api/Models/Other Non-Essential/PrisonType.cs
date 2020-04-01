using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementLibrary.Api.Models.Other_Non_Essential
{
    public static class PrisonType
    {

        private static List<string> PrisonTypes_ = new List<string>();

        /// <summary>
        /// Returns list of prison types
        /// </summary>
        /// <returns>List<string></returns>
        public static List<string> PRISONTYPES()
        {

            var files = File.ReadAllLines(Resource1.PrisonTypes);
            foreach (var line in files)
            {
                PrisonTypes_.Add(line);
            }

            return PrisonTypes_;
        }
        /// <summary>
        /// Add prison type to list and returns list
        /// </summary>
        /// <returns>List<string></returns>
        public static List<string> PRISONTYPES(string prisontype)
        {
            using (StreamWriter sw = new StreamWriter(Resource1.PrisonTypes))
            {
                for (int i = 0; i < PrisonTypes_.Count; i++)
                {
                    sw.WriteLine(PrisonTypes_[i]);

                }

                var files = File.ReadAllLines(Resource1.PrisonTypes);
                foreach (var line in files)
                {
                    if(!PrisonTypes_.Contains(line))
                        PrisonTypes_.Add(line);
                }

                return PrisonTypes_;


            }
        }
                
            
    }

}

