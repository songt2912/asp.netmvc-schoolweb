using NewWed.Data;
using NewWed.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewWed.Service.Implement
{
    public class ClassRoomService: IClassRoomService
    {
        private ISchoolEntitiesData _schoolEntities;

        public ClassRoomService(ISchoolEntitiesData schoolEntities)
        {
            _schoolEntities = schoolEntities;
        }
        public IEnumerable<Models.ClassRoomDto> GetClassRoom()
        {
            var tests = _schoolEntities.ClassRooms.Take(20).ToList();
          

                

            
            
            return tests.Select(x => new Models.ClassRoomDto
            {
               ClassID=x.ClassID,
               ClassName=x.ClassName,
               TotalStudent=x.TotalStudent
               
            }).ToList();
           
        }
    }
}