using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewWed.Service.Interfaces
{
    public interface IClassRoomService
    {

        IEnumerable<Models.ClassRoomDto> GetClassRoom();
       

    }
}