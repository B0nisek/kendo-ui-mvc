using BL.DTO;
using System.Collections.Generic;

namespace BL.Service.Addresses
{
    public interface IAddressService
    {
        void CreateAddress(AddressDTO addressDto);

        void EditAddress(AddressDTO addressDto);

        void DeleteAddress(int id);

        AddressDTO GetAddress(int id);

        IList<AddressDTO> GetAddressesById(int[] ids);
    }
}