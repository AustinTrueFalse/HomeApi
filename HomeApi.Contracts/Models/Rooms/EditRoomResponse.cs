using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApi.Contracts.Models.Rooms
{
    public class EditRoomResponse
    {
        public string Name { get; set; }
        public double Area { get; set; }
        public bool GasConnected { get; set; }
        public int Voltage { get; set; }
        public string Message { get; set; }
    }
}
