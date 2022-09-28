using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;

namespace DeviceManagement_WebApp.Repository
{
    //I Created the IDeviceRepository and added the interface definition
    public interface IDeviceRepository : IGenericRepository<Device>
    {
        bool exists(Guid id); //added Guid as a datatype instead of int
        Device GetMostRecentDevice();
        IEnumerable<Device> GetAllDevice();
        Device GetDeviceById(Guid id); //added Guid as a datatype instead of int
    }
}
